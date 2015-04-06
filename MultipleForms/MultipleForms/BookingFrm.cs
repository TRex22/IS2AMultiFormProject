using System;
using System.Windows.Forms;
using MultipleForms.Properties;
using MultipleFormsClassLibrary;

namespace MultipleForms
{
    public partial class BookingFrm : Form
    {
        private readonly Login _loginForm = new Login();
        private readonly BookingDataHandlerClass _bookingDataHandlerClass = new BookingDataHandlerClass();

        public BookingFrm(Login loginForm, BookingDataHandlerClass bookingDataHandlerClass)
        {
            _loginForm = loginForm;
            _bookingDataHandlerClass = bookingDataHandlerClass;

            //if no shows then go back to login because admin must add data
            if (_bookingDataHandlerClass.HasContent == true)
            {
               InitializeComponent();
               var showNames = _bookingDataHandlerClass.GetShowNames();
               combBoxShows.Items.AddRange(showNames);
            }
            else
            {
                //return to login
                MessageBox.Show(Resources.BookingFrm_BookingFrm_Unfortunately_no_shows_have_been_added_to_the_program__The_admin_must_login_to_add_shows_);
                LogOut();
            }
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogOut();
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

        private void LogOut()
        {
            _loginForm.Show();
            this.Close();
        }
    }
}
