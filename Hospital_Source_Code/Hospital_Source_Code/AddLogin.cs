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

        private DAO dao = new DAO();

        public AddLogin()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            string password2 = txtPassword2.Text;
            //string userType = comboUserType.SelectedItem.ToString();

            UserRole role = UserRole.Admin;



            // check if field left empty
            if (VerifyInput(userName, password, password2))
            {
                Console.WriteLine(CheckForAccount().ToString());
                MessageBox.Show("The statement is: " + CheckForAccount().ToString());
                // Check if no account with that username exists in database
                //if (!CheckForAccount())
                //{
                //    // Create Login
                //    //bool success = dao.testAddUser(userName, password, role);

                //    MessageBox.Show("User " + userName + " inserted successfully", "Insert completed", MessageBoxButtons.OK);
                //} else
                //MessageBox.Show("This username is already taken, please insert another username.\n Try " + userName + "1 or " + userName + "TheEejit instead", userName);
            }
        }

        private bool CheckForAccount()
        {
            string username = txtUsername.Text;
            bool accountAvailable = dao.CheckForAccount(username);
            // Check if no account with that username exists in database 
            return accountAvailable;
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
            if (password2 == string.Empty || !password2.Equals(password))
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
