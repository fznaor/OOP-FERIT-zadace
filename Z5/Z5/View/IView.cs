using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5
{
    public interface IView
    {
        TVPresenter presenter { set; }
        void addShowsToList(TVShow[] shows);
        void displayShowInfo(TVShow tvshow);
        void addSeasonsToList(Season[] seasons);
        void addEpisodesToList(Episode[] episodes);
    }
}
