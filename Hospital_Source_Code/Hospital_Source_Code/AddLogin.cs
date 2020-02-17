using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Source_Code
{
    public partial class AddLogin : Form
    {
        public AddLogin()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            string password2 = txtPassword2.Text;

            // check if field left empty
            if (VerifyInput(userName, password, password2))
            {
                // Check if no account with that username exists in database
                if (!CheckForAccount())
                {
                    // Create Login
                }
            }
        }

        private bool CheckForAccount()
        {
            // Check if no account with that username exists in database 
            return true;
        }

        private bool VerifyInput(string userName, string password, string password2)
        {
            bool detailCorrect = true;
            if (userName == string.Empty)
            {
                lblUsername.ForeColor = Color.Red;
                detailCorrect = false;
            } else
            {
                lblUsername.ForeColor = Color.Black;
            }
            if (password == string.Empty)
            {
                lblPassword.ForeColor = Color.Red;
                detailCorrect = false;
            } else
            {
                lblPassword.ForeColor = Color.Black;
            }
            if (password2 == string.Empty && password2.Equals(password))
            {
                lblPassword2.ForeColor = Color.Red;
                detailCorrect = false;
            }
            else
            {
                lblPassword2.ForeColor = Color.Black;
            }
            return detailCorrect;
        }

    }
}
