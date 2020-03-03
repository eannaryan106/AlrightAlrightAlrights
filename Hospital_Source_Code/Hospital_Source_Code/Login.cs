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
    public partial class Login : Form
    {
        DAO dao;
        public Login()
        {
            InitializeComponent();
            dao = new DAO();
            //conTest();
        }

        private void conTest() {
            
            dao.testCon();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {            
            string userName = txtUsername.Text;
            string password = txtPassword.Text;

            // check if field left empty
            if (VerifyInput(userName, password))
            {
                    // Check for login data that matches
                    LoginModel login = dao.GetLogin(userName, password);
                    UserRole role = UserRole.None;
                    Console.WriteLine(login.UserType);
                    // Set user role -- if no data matched inputs user role remains none
                    switch (login.UserType)
                    {
                        case "Doctor":
                            role = UserRole.Doctor;
                            break;
                        case "Admin":
                            role = UserRole.Admin;
                            break;
                        case "Accounts":
                            role = UserRole.Accounts;
                            break;
                        case "HR":
                            role = UserRole.HR;
                            break;
                        case "SuperUser":
                            role = UserRole.SuperUser;
                            break;
                        default:
                            break;
                    }

                    DeterminePermissions(role, userName);          // Determines if user exists and where to go     
            }
        }

        private void DeterminePermissions(UserRole role, string userName)
        {
            // determine where the user is brought to and if user role is none then user is invalid and nothing happens
            if (role == UserRole.SuperUser)
            {
                AddLogin addLogin = new AddLogin();
                addLogin.Show();
                this.Hide();
            } else if (role == UserRole.HR)
            {
                DoctorsDashboard docDashboard = new DoctorsDashboard(role, userName);
                docDashboard.Show();
                this.Hide();
            }
            else if (role == UserRole.Admin)
            {
                PatientsDashboard patientDashboard = new PatientsDashboard(role, userName);
                patientDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(this, "User doe's not match with any in our system please try again", "Invalid User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.ForeColor = Color.DarkRed;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.ForeColor = Color.Transparent;
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "An Email has been sent with your password reset link", "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // aligning & hiding textbox characters
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '•';
            txtPassword.TextAlign = HorizontalAlignment.Center;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.TextAlign = HorizontalAlignment.Center;
        }
    }
}
