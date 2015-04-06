using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleFormsClassLibrary
{
    public class LoginClass
    {
        public int tryCount = 0;

        //passwords not even hashed lol
        private static readonly string[] Passwords = new string[] { "123456", "123456" }; //should be with form constants in designer
        
        //use password hashing and SALTing - just no time ;-(
        //THIS IS COMPLETELY AGAINST CONVENTION AND SECURITY IDEALS
        private bool ValidatePassword(string password, string recievedInput, bool blnValidInput)
        {
            if (!password.Equals(recievedInput))
                blnValidInput = false;
            return blnValidInput;
        }

        private bool PasswordCompare(int selectedIndex, string passwordTxt, bool blnValidPassword)
        {
            if (selectedIndex == 0)
            {
                //admin
                var password = Passwords[0];
                blnValidPassword = ValidatePassword(password, passwordTxt, blnValidPassword);
            }
            else if (selectedIndex == 1)
            {
                //client
                var password = Passwords[1];
                blnValidPassword = ValidatePassword(password, passwordTxt, blnValidPassword);
            }

            tryCount++;
            return blnValidPassword;
        }

        public bool CheckPassword(int selectedIndex, string passwordTxt)
        {
            var blnValidPassword = true;
            blnValidPassword = PasswordCompare(selectedIndex, passwordTxt, blnValidPassword);
            return blnValidPassword;
        }
    }
}
