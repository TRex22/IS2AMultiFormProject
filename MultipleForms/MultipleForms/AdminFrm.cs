using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MultipleForms
{
    public partial class AdminFrm : Form
    {
        public AdminFrm()
        {
            InitializeComponent();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login LoginInstance = new Login();
            this.Visible = false; //TODO JMC use a proper destructor so that you don't eventually run out of mem from a million windows
            LoginInstance.Show();
        }
    }
}
