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
        public Login()
        {
            InitializeComponent();
        }

        //passwords not even hashed lol
        private static readonly string[] Passwords = new string[] {"123456", "123456"}; //should be with form constants in designer

        //TODO JMC: move into a class library and use password hashing and SALTing
        //THIS IS COMPLETELY AGAINST CONVENTION AND SECURITY IDEALS
        private bool ValidatePassword(string password, string recievedInput, bool blnValidInput)
        {
            if (!password.Equals(recievedInput))
                blnValidInput = false;
            return blnValidInput;
        }

        private int CheckPassword(int tryCount)
        {
            bool blnValidPassword = true;
            if (userCmboBox.SelectedIndex == 0)
            {
                //admin
                string password = Passwords[0];
                blnValidPassword = ValidatePassword(password, passwordTxtBox.Text, blnValidPassword);
            }
            else if (userCmboBox.SelectedIndex == 1)
            {
                //client
                string password = Passwords[1];
                blnValidPassword = ValidatePassword(password, passwordTxtBox.Text, blnValidPassword);
            }

            if (blnValidPassword && userCmboBox.SelectedIndex == 0)
            {
                tryCount = 0; // rest tries
                AdminFrm AdminInstance = new AdminFrm(_bookingDataHandlerClass);
                this.Visible = false; //SO much lols how wrong this is
                AdminInstance.ShowDialog();
            }
            else if (blnValidPassword && userCmboBox.SelectedIndex == 1)
            {
                tryCount = 0; // rest tries
                BookingFrm BookingInstance = new BookingFrm(_bookingDataHandlerClass);
                this.Visible = false; //SO much lols how wrong this is
                BookingInstance.ShowDialog();
            }

            tryCount ++;
            return tryCount;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int tryCount = 0;
            if (tryCount < 3)
            {
                CheckPassword(tryCount);
            }
            else
            {
                //WTF? this is really bad. Not even a message dialogue
                Application.Exit();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userCmboBox.SelectedIndex = -1;
            passwordTxtBox.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
