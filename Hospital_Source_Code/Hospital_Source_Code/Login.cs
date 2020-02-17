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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;

            // check if field left empty
            if (VerifyInput(userName, password))
            {
                // Verify Login Credentials
                if (VerifyCredentials())
                {
                    UserRole role = UserRole.Admin;
                    DeterminePermissions(role, userName);
                }                
            }
        }

        private void DeterminePermissions(UserRole role, string userName)
        {
            if (role == UserRole.SuperUser)
            {
                AddLogin addLogin = new AddLogin();
                addLogin.Show();
                this.Hide();
            } else
            {
                HomeDashboard homeDashboard = new HomeDashboard(role, userName);
                homeDashboard.Show();
                this.Hide();
            }
        }

        private bool VerifyCredentials()
        {
            // Compare to database
            return true;
        }

        private bool VerifyInput(string userName, string password)
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
            return detailCorrect;
        }
    }
}
