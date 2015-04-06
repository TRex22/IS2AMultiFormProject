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
    public partial class Login : Form
    {
        //This "static" domain level class is not the way to go. I ran out of time to use csv or whatever. I'm tired so pretty
        //much I'm keeping all the haxes
        BookingDataHandlerClass _bookingDataHandlerClass = new BookingDataHandlerClass();
        LoginClass _loginClass = new LoginClass();

        public Login()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            var blnValidPassword = true;
            if (_loginClass.tryCount < 3)
            {
                blnValidPassword = _loginClass.CheckPassword(userCmboBox.SelectedIndex, passwordTxtBox.Text);
            }
            else
            {
                MessageBox.Show("Unfortunately You have entered the wrong password three times. Goodbye Dave.");
                Application.Exit();
            }

            if (blnValidPassword == true && userCmboBox.SelectedIndex == 0)
            {
                _loginClass.tryCount = 0;
                AdminFrm admin = new AdminFrm(this, _bookingDataHandlerClass);
                userCmboBox.SelectedIndex = -1;
                passwordTxtBox.Text = "";
                this.Hide();
                admin.Show();
            }
            else if (blnValidPassword == true && userCmboBox.SelectedIndex == 1)
            {
                _loginClass.tryCount = 0;
                BookingFrm booking = new BookingFrm(this, _bookingDataHandlerClass);
                userCmboBox.SelectedIndex = -1;
                passwordTxtBox.Text = "";
                this.Hide();
                booking.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
