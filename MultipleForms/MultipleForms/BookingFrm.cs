using System;
using System.Windows.Forms;
using MultipleFormsClassLibrary;

namespace MultipleForms
{
    public partial class BookingFrm : Form
    {
        readonly BookingDataHandlerClass _bookingDataHandlerClass = new BookingDataHandlerClass();
        public BookingFrm(BookingDataHandlerClass bookingDataHandlerClass)
        {
            _bookingDataHandlerClass = bookingDataHandlerClass;

            //if no shows then go back to login because admin must add data
            if (_bookingDataHandlerClass.HasContent == true)
            {
                var showNames = _bookingDataHandlerClass.GetShowNames();
                combBoxShows.Items.AddRange(showNames);
                InitializeComponent();
            }
            else
            {
                //return to login
            }
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login LoginInstance = new Login();
            this.Visible = false; //TODO JMC use a proper destructor so that you don't eventually run out of mem from a million windows
            LoginInstance.Show();
            
        }

        private void makeABookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var outputs = BookingClass.CalculateBookingsMessages(_bookingDataHandlerClass, combBoxShows.SelectedIndex, (int)numericUpDownNumPeople.Value, dateTimePickerShow.Value,
                chkBoxLimoService.Checked, rdoBtnAlcohol.Checked, rdoBtnSoftDrinks.Checked);
            lblOutDetails.Text = outputs[0];
            lblOutCost.Text = outputs[1];
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            combBoxShows.SelectedIndex = -1;
            numericUpDownNumPeople.Value = 0;
            dateTimePickerShow.Value = DateTime.Now;
            chkBoxLimoService.Checked = false;
            rdoBtnAlcohol.Checked = false;
            rdoBtnSoftDrinks.Checked = false;


            lblOutDetails.Text = "";
            lblOutCost.Text = "";
        }
    }
}
