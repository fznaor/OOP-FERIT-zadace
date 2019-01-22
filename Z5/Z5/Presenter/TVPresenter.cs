using System;
using Newtonsoft.Json;

namespace Z5
{
    public class TVPresenter:IPresenter
    {
        private readonly IView view;
        private readonly IModel model;

        public TVPresenter(IView view, IModel model)
        {
            this.view = view;
            this.model = model;
            this.view.presenter = this;
        }

        public string RemoveHTMLTags(string HTMLCode)
        {
            if (HTMLCode != null)
                return System.Text.RegularExpressions.Regex.Replace(HTMLCode, "<[^>]*>", "");
            else return String.Empty;
        }

        public void loadShows(string path)
        {
            var json = new System.Net.WebClient().DownloadString(path);
            model.loadShows(JsonConvert.DeserializeObject<TVShow[]>(json));
            view.addShowsToList(model.getShows());
        }

        public void getShowInfo(int index)
        {
            TVShow[] tvshows = model.getShows();
            TVShow currentShow = tvshows[index];
            view.displayShowInfo(currentShow);
        }

        public void loadSeasons(int i)
        {
            TVShow[] tvshows = model.getShows();
            string path = "http://api.tvmaze.com/shows/" + tvshows[i].show.id + "/seasons";
            var json = new System.Net.WebClient().DownloadString(path);
            model.loadSeasons(JsonConvert.DeserializeObject<Season[]>(json));
            view.addSeasonsToList(model.getSeasons());
        }

        public void loadEpisodes(int i)
        {
            Season[] seasons = model.getSeasons();
            string path = "http://api.tvmaze.com/seasons/" + seasons[i].id + "/episodes";
            var json = new System.Net.WebClient().DownloadString(path);
            model.loadEpisodes(JsonConvert.DeserializeObject<Episode[]>(json));
            view.addEpisodesToList(model.getEpisodes());
        }

        public Episode getSelectedEpisode(int i)
        {
            Episode[] episodes = model.getEpisodes();
            return episodes[i];
        }
    }
}
