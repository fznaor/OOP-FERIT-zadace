using System;
using System.Drawing;
using System.Windows.Forms;


namespace Z5
{
    public partial class FormTV : Form, IView
    {
      

        public FormTV()
        {
            InitializeComponent();
        }

        public TVPresenter presenter { private get; set; }

        private void FormTV_Load(object sender, EventArgs e)
        {
            ChangeLabelVisibility(false);
        }

        public void ChangeLabelVisibility(bool visibility)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Label && c != labelShowSelect && c != labelSeasonSelect && c != labelEpisodeSelect && c != labelShowSearch
                    && c != labelSeasonList && c != labelEpisodeList)
                {
                    Label lbl = (Label)c;
                    lbl.Visible = visibility;
                }
            }
        }

        public void addShowsToList(TVShow[] shows)
        {
            foreach (TVShow s in shows)
                listViewShows.Items.Add(new ListViewItem(new string[] { s.show.name, s.show.status, s.show.premiered }));
        }

        public void displayShowInfo(TVShow tvshow)
        {
            
            labelDescription.MaximumSize = new Size(this.Width - labelDescription.Location.X - 15, 0);
            labelDescription.AutoSize = true;
            labelDescription.Text = presenter.RemoveHTMLTags(tvshow.show.summary);
            labelName.Text = tvshow.show.name;
            labelType.Text = tvshow.show.type;
            labelStatus.Text = tvshow.show.status;
            labelRuntime.Text = tvshow.show.runtime.ToString();
            labelPremiered.Text = tvshow.show.premiered;
            labelLanguage.Text = tvshow.show.language;
            if (tvshow.show.network != null)
                labelNetwork.Text = tvshow.show.network.name;
            else labelNetwork.Text = string.Empty;
            labelOfficialSite.Text = tvshow.show.officialSite;
            labelGenres.Text = String.Empty;
            foreach (string s in tvshow.show.genres)
                labelGenres.Text += s + ", ";
            if (tvshow.show.genres.Count != 0)
                labelGenres.Text = labelGenres.Text.Remove(labelGenres.Text.Length - 2);
            if (tvshow.show.image != null)
                pictureBoxShowPic.Load(tvshow.show.image.medium);
            else pictureBoxShowPic.Image = null;
        }

        public void addSeasonsToList(Season[] seasons)
        {
            foreach (Season s in seasons)
            {
                if (s.network != null)
                    listViewSeasons.Items.Add(new ListViewItem(new string[] { s.number.ToString(), s.episodeOrder.ToString(), s.premiereDate, s.endDate, s.network.name }));
                else listViewSeasons.Items.Add(new ListViewItem(new string[] { s.number.ToString(), s.episodeOrder.ToString(), s.premiereDate, s.endDate, null }));
            }
        }

        public void addEpisodesToList(Episode[] episodes)
        {
            foreach (Episode ep in episodes)
            {
                if (ep.summary != null)
                    listViewEpisodes.Items.Add(new ListViewItem(new string[] { ep.number.ToString(), ep.name, ep.airdate, ep.runtime.ToString() }));
                else listViewEpisodes.Items.Add(new ListViewItem(new string[] { ep.number.ToString(), ep.name, ep.airdate, ep.runtime.ToString() }));
            }
        }

        public void displayEpisodeSummary(Episode ep)
        {
            labelEpSummary.Visible = true;
            labelEpSummary.MaximumSize = new Size(this.Width - labelDescription.Location.X - 15, 0);
            if (ep.summary == String.Empty || ep.summary == null)
                labelEpSummary.Text = "No summary available for selected episode";
            else labelEpSummary.Text = "Episode " + ep.number.ToString() + ": " + presenter.RemoveHTMLTags(ep.summary);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ChangeLabelVisibility(false);
            pictureBoxShowPic.Image = null;
            listViewSeasons.Visible = false;
            labelSeasonList.Visible = false;
            labelSeasonSelect.Visible = false;
            listViewEpisodes.Visible = false;
            labelEpisodeList.Visible = false;
            labelEpisodeSelect.Visible = false;
            listViewShows.Items.Clear();
            string path = "http://api.tvmaze.com/search/shows?q=" + textBoxSearch.Text;
            presenter.loadShows(path);
        }

        private void listViewShows_doubleClick(object sender, MouseEventArgs e)
        {
            ChangeLabelVisibility(true);
            presenter.getShowInfo(listViewShows.Items.IndexOf(listViewShows.SelectedItems[0]));
            listViewSeasons.Visible = true;
            labelSeasonList.Visible = true;
            labelSeasonSelect.Visible = true;
            listViewSeasons.Items.Clear();
            presenter.loadSeasons(listViewShows.Items.IndexOf(listViewShows.SelectedItems[0]));
            listViewEpisodes.Visible = false;
            labelEpisodeList.Visible = false;
            labelEpisodeSelect.Visible = false;
            labelEpSummary.Visible = false;
        }

        private void listViewSeasons_doubleClick(object sender, MouseEventArgs e)
        {
            listViewEpisodes.Visible = true;
            labelEpisodeList.Visible = true;
            labelEpisodeSelect.Visible = true;
            listViewEpisodes.Items.Clear();
            presenter.loadEpisodes(listViewSeasons.Items.IndexOf(listViewSeasons.SelectedItems[0]));
            labelEpSummary.Visible = false;
        }

        private void listViewEpisodes_doubleClick(object sender, MouseEventArgs e)
        {
            Episode ep=presenter.getSelectedEpisode(listViewEpisodes.Items.IndexOf(listViewEpisodes.SelectedItems[0]));
            displayEpisodeSummary(ep);
        }
    }
}
