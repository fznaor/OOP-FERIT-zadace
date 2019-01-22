namespace Z5
{
    public class TVModel:IModel
    {
        TVShow[] tvshows;
        Season[] seasons;
        Episode[] episodes;
        public TVShow[] getShows() { return tvshows; }
        public Season[] getSeasons() { return seasons; }
        public Episode[] getEpisodes() { return episodes; }
        public void loadShows(TVShow[] shows) {
            tvshows = shows;
        }
        public void loadSeasons(Season[] newseasons)
        {
            seasons = newseasons;
        }
        public void loadEpisodes(Episode[] newepisodes)
        {
            episodes = newepisodes;
        }
    }
}
