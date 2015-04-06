using System;

namespace MultipleFormsClassLibrary
{
    //THIS IS ABSOLUTELY NASTY WAY OF VARIABLE THINGS. NOT A SEMAPHORE OR ANYTHING REALLY PLEASE NEVER DO THIS!!!!
    //IT'S JUST FOR MY SMALL COURSE PROJECT
    public class BookingDataHandlerClass
    {
        //windows forms uses objects in comboboxes

        private Show[] _shows = {};
        public bool HasContent = false;

        public Show[] GetShows()
        {
            return _shows;
        }

        public object[] GetShowNames()
        {
            var showNames = new object[_shows.Length];
            for (var i = 0; i < _shows.Length; i++)
            {
                showNames[i] = _shows[i].ShowName;
            }
            return showNames;
        }

        //super hack to get this working
        public void AddShow(Show show)
        {
            var tmpShows = _shows;
            if (tmpShows.Length <= 0)
                _shows = new[]{show};
            else
            {
                _shows = new Show[tmpShows.Length];
                for (var i = tmpShows.Length-1; i > 0; i--)
                    _shows[i] = tmpShows[i];
                _shows[tmpShows.Length - 1] = show;
            }
            HasContent = true;
        }
    }
}