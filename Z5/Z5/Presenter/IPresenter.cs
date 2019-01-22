namespace Z5
{
    public interface IPresenter
    {
        void loadShows(string path);
        void getShowInfo(int index);
        void loadSeasons(int i);
        void loadEpisodes(int i);
        Episode getSelectedEpisode(int i);
    }
}
