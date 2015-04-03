using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleFormsClassLibrary
{
    public class BookingClass
    {
        //Constants

        //windows forms uses objects in comboboxes
        public static object[] Shows
        {
            get { return _shows; }
        }
        private static readonly object[] _shows =
        {
            "Inglourious Basterds", 
            "The Hateful Eight (Pre-book)", 
            "Death Proof", 
            "Django Unchained", 
            "Kill Bill Volume 3 (Pre-book)", 
            "Kill Bill Volume 2", 
            "Kill Bill Volume 1", 
            "Reservoir Dogs", 
            "Jackie Brown", 
            "Pulp Fiction", 
            "Fight Club", 
            "The Avengers 66", 
            "The Guardians of the Galaxy", 
            "The Matrix", 
            "CSI: Las Vegas"
        };

        private const double LimoServiceCost = 100.00; //max 8 people can be catered for
        private const double WineMaltSoftDrinksCost = 90.00;
        private const double SoftDrinksCost = 50.00;
        private const double VAT = 0.10;

        public static string[] CalculateBookingsMessages(int intShowIndex, int intNumPeople, DateTime selectedDate, bool blnLimoService, bool blnWineMaltSoftDrinks, bool blnSoftDrinksOnly)
        {
            var outputs = new[] {"", ""};

            var bookedDay = string.Format("{0:dd MMMM}", selectedDate);
            var limoServiceStr = "You have not booked a limo service.";
            if (blnLimoService)
            {
                limoServiceStr = "You have booked a limo service.";
            }
            //The string.Format here works like a string builder. It is better than just using ""+""+int 
            outputs[0] = String.Format("You are booked to see {0} for {1} person/people on {2}. {3}", _shows[intShowIndex], intNumPeople, bookedDay, limoServiceStr);

            var dblShowCost = 0.00; //TODO JMC FIX THIS
            var dblCalculatedCost = CalculateCost(dblShowCost, blnLimoService, blnWineMaltSoftDrinks, blnSoftDrinksOnly);
            outputs[1] = string.Format("The cost will be {0} including VAT", dblCalculatedCost);

            return outputs;
        }

        private static double CalculateCost(double dblShowCost, bool blnLimoService, bool blnWineMaltSoftDrinks, bool blnSoftDrinksOnly)
        {
            var cost = dblShowCost;
            
            if (blnLimoService)
                cost += LimoServiceCost;
            if (blnWineMaltSoftDrinks)
                cost += WineMaltSoftDrinksCost;
            else if (blnSoftDrinksOnly)
                cost += SoftDrinksCost;

            var vat = cost*VAT;
            cost += vat;

            return cost;
        }
    }
}
