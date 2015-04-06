using System;
using System.Windows.Forms;
using MultipleForms.Properties;
using MultipleFormsClassLibrary;

namespace MultipleForms
{
    public partial class AdminFrm : Form
    {
        private readonly Login _loginForm = new Login();
        private readonly BookingDataHandlerClass _bookingDataHandlerClass = new BookingDataHandlerClass();
        public AdminFrm(Login loginForm, BookingDataHandlerClass bookingDataHandlerClass)
        {
            _loginForm = loginForm;
            _bookingDataHandlerClass = bookingDataHandlerClass;
            InitializeComponent();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //a troublesome hack to get this to work before the deadline
            LogOut();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var cost = Convert.ToDouble(txtBxShowCost.Text);
                var show = new Show(txtBxShowName.Text, cost);
                _bookingDataHandlerClass.AddShow(show);
                MessageBox.Show(String.Format("Added {0}", show.ShowName));
            }
            catch (FormatException)
            {
                Console.WriteLine(Resources.AdminFrm_addToolStripMenuItem_Click_Unable_to_convert___0___to_a_Double_, txtBxShowCost.Text);
            }
            catch (OverflowException)
            {
                Console.WriteLine(Resources.AdminFrm_addToolStripMenuItem_Click___0___is_outside_the_range_of_a_Double_, txtBxShowCost.Text);
            }

            txtBxShowName.Text = "";
            txtBxShowCost.Text = "";
        }

        private void LogOut()
        {
            _loginForm.Show();
            this.Close();
        }
    }
}