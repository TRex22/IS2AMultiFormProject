using System;
using System.Windows.Forms;
using MultipleForms.Properties;
using MultipleFormsClassLibrary;

namespace MultipleForms
{
    public partial class AdminFrm : Form
    {
        BookingDataHandlerClass _bookingDataHandlerClass = new BookingDataHandlerClass();
        public AdminFrm(BookingDataHandlerClass bookingDataHandlerClass)
        {
            _bookingDataHandlerClass = bookingDataHandlerClass;
            InitializeComponent();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var LoginInstance = new Login();
            Visible = false;
                //TODO JMC use a proper destructor so that you don't eventually run out of mem from a million windows
            LoginInstance.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                double cost = Convert.ToDouble(txtBxShowCost.Text);
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
        }
    }
}