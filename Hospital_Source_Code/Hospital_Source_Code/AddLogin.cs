using Hospital_Source_Code.Classes;
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
        DAO dao;

        public AddLogin()
        {
            InitializeComponent();
            dao = new DAO();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            string password2 = txtPassword2.Text;
            string userType = comboUserType.SelectedIndex.ToString();

            // check if field left empty
            if (VerifyInput(userName, password, password2, userType))
            {
                // Check if no account with that username exists in database
                if (!CheckForAccount(userName))
                {
                    // Create Login
                } else
                {
                    MessageBox.Show(this, "User already exists in system", "User Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool CheckForAccount(string userName)
        {
            // Check if no account with that username exists in database 
            bool exist = dao.CheckLoginExist(userName);
            return exist;
        }

        private bool VerifyInput(string userName, string password, string password2, string userType)
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
            if (password2 == string.Empty || !password2.Equals(password))
            {
                lblPassword2.ForeColor = Color.Red;
                detailCorrect = false;
            }
            else
            {
                lblPassword2.ForeColor = Color.Black;
            }
            if (userType.Equals(string.Empty))
            {
                detailCorrect = false;
                comboUserType.ForeColor = Color.Red;
            } else
            {
                comboUserType.ForeColor = Color.Black;
            }
            return detailCorrect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
