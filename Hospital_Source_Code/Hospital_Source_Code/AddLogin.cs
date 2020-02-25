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
            UserRole role = new UserRole();        

            // check if field left empty
            if (VerifyInput(userName, password, password2))
            {
                // Check if no account with that username exists in database
                if (CheckForAccount() == true)
                {
                    // Create Login
                    role = userTypeCheck();
                    bool success = dao.testAddUser(userName, password, role);
                    if (role == UserRole.Doctor)
                    {
                        int id = dao.GetLoginId(userName);
                        dao.AddDoctor(id);
                    }
                    MessageBox.Show("User " + userName + " inserted successfully", "Insert completed", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("This username is already taken, please insert another username.\n Try " + userName + "1 or " + userName + "TheEejit instead", userName);
            }
        }

        private UserRole userTypeCheck()
        {
            UserRole role;
            if (comboUserType.SelectedIndex == 0)
                role = UserRole.Admin;
            else if (comboUserType.SelectedIndex == 1)
                role = UserRole.Doctor;
            else if (comboUserType.SelectedIndex == 2)
                role = UserRole.HR;
            else if (comboUserType.SelectedIndex == 3)
                role = UserRole.SuperUser;
            else
                role = UserRole.None;
            return role;
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
                lblUsername.ForeColor = Color.MidnightBlue;
            }
            if (password == string.Empty)
            {
                lblPassword.ForeColor = Color.Red;
                detailCorrect = false;
            } else
            {
                lblPassword.ForeColor = Color.MidnightBlue;
            }
            if (password2 == string.Empty || !password2.Equals(password))
            {
                lblPassword2.ForeColor = Color.Red;
                detailCorrect = false;
            }
            else
            {
                lblPassword2.ForeColor = Color.MidnightBlue;
            }
            if (comboUserType.SelectedIndex < 0)
            {
                lblUserType.ForeColor = Color.Red;
                detailCorrect = false;
            }
            else
            {
                lblUserType.ForeColor = Color.MidnightBlue;
            }
            return detailCorrect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
