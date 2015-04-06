using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace MultipleFormsClassLibrary
{
    public class BookingClass
    {
        //Constants

        private const double LimoServiceCost = 100.00; //max 8 people can be catered for
        private const double WineMaltSoftDrinksCost = 90.00;
        private const double SoftDrinksCost = 50.00;
        private const double VAT = 0.10;

        public static string[] CalculateBookingsMessages(BookingDataHandlerClass bookingDataHandlerClass, int intShowIndex, int intNumPeople, DateTime selectedDate, bool blnLimoService, bool blnWineMaltSoftDrinks, bool blnSoftDrinksOnly)
        {
            //if no shows then go back to login because admin must add data - will be in form that makes sense

            var outputs = new[] {"", ""};

            var bookedDay = string.Format("{0:dd MMMM}", selectedDate);
            var limoServiceStr = "You have not booked a limo service.";
            if (blnLimoService)
            {
                if (intNumPeople <= 8)
                    limoServiceStr = "You have booked a limo service.";
                else
                {
                    MessageBox.Show("Unfortunately, you have tried to book a limo service with more than 8 people." +
                                    "\nSO the program will continue but not book a limo service.");
                    blnLimoService = false; //HAHAHAHAHAHAHAHAHAHA

                }
            }
            //The string.Format here works like a string builder. It is better than just using ""+""+int 
            var shows = bookingDataHandlerClass.GetShows();
            outputs[0] = String.Format("You are booked to see {0} for {1} person/people on {2}. {3}", shows[intShowIndex].ShowName, intNumPeople, bookedDay, limoServiceStr);

            var dblCalculatedCost = CalculateCost(shows[intShowIndex].ShowCost, blnLimoService, blnWineMaltSoftDrinks, blnSoftDrinksOnly);
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
