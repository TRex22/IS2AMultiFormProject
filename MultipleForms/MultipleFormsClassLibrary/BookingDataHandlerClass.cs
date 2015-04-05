namespace MultipleFormsClassLibrary
{
    public class BookingDataHandlerClass
    {
        //windows forms uses objects in comboboxes

        private static Show[] _shows =
        {
        };

        public void SetShows(Show[] shows)
        {
            _shows = shows;
        }

        public static Show[] GetShows()
        {
            return _shows;
        }
    }

    //don't do this but hey its only a few lines and the definition of a show can sit here since it will only be here.
    //All magic ie evil happens in this file
    public class Show
    {
        public Show(string showName, double showCost)
        {
            ShowName = showName;
            ShowCost = showCost;
        }

        public string ShowName { get; set; }
        public double ShowCost { get; set; }
    }
}