namespace MultipleFormsClassLibrary
{
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