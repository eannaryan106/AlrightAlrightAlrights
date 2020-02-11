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
            if (VerifyInput())
            {
                // Verify Login Credentials
                if (VerifyCredentials())
                {
                    HomeDashboard homeDashboard = new HomeDashboard();
                    homeDashboard.Show();
                    this.Hide();
                }                
            }
        }

        private bool VerifyCredentials()
        {
            // Compare to database
            return true;
        }

        private bool VerifyInput()
        {
            bool detailCorrect = true;
            if (txtUsername.Text == string.Empty)
            {
                Console.WriteLine("got here");
                lblUsername.ForeColor = Color.Red;
                detailCorrect = false;
            }
            if (txtPassword.Text == string.Empty)
            {
                lblPassword.ForeColor = Color.Red;
                detailCorrect = false;
            }
            return detailCorrect;
        }
    }
}
