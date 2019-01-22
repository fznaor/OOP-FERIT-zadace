namespace Z5
{
    public interface IModel
    {
        TVShow[] getShows();
        Season[] getSeasons();
        Episode[] getEpisodes();
        void loadShows(TVShow[] shows);
        void loadSeasons(Season[] newseasons);
        void loadEpisodes(Episode[] newepisodes);
    }
}
