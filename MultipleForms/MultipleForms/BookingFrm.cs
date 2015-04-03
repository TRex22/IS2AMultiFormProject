using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MultipleFormsClassLibrary;

namespace MultipleForms
{
    public partial class BookingFrm : Form
    {
        public BookingFrm()
        {
            //TODO fix this
            combBoxShows.Items.AddRange(BookingClass.Shows);
            InitializeComponent();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login LoginInstance = new Login();
            this.Visible = false; //TODO JMC use a proper destructor so that you don't eventually run out of mem from a million windows
            LoginInstance.Show();
            
        }

        private void makeABookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var outputs = BookingClass.CalculateBookingsMessages(combBoxShows.SelectedIndex, (int)numericUpDownNumPeople.Value, dateTimePickerShow.Value,
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
