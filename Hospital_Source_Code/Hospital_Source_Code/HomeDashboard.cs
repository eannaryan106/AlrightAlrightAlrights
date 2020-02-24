using Hospital_Source_Code.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Source_Code
{
    public partial class HomeDashboard : Form
    {
        DAO dao = new DAO();
        Regex numbersOnly = new Regex(@"^[0-9]+$");
        Regex alphabetOnly = new Regex(@"^[a-zA-Z]+$");

        UserRole role;
        public HomeDashboard(UserRole role, string userName)
        {
            InitializeComponent();
            test();
            pnlInsertPatient.Hide();
            hideErrors();
            this.role = role;
            loadDeptIds();
            if (role == UserRole.Admin)
            {
                tabControl1.SelectTab("tabPatient");
                tabControl1.TabPages.Remove(tabDoctor);
                tabControl1.TabPages.Remove(tabBilling);
                Console.WriteLine((int)role);
            }
            else if(role == UserRole.HR)
            {
                tabControl1.SelectTab("tabDoctor");
                tabControl1.TabPages.Remove(tabPatient);
                tabControl1.TabPages.Remove(tabBilling);
                tabControl1.TabPages.Remove(tabBeds);
            }
            else if(role == UserRole.Accounts)
            {
                tabControl1.SelectTab("tabBilling");
                tabControl1.TabPages.Remove(tabBeds);
                tabControl1.TabPages.Remove(tabPatient);
                tabControl1.TabPages.Remove(tabDoctor);
            }
            else if(role == UserRole.Doctor)
            {
                tabControl1.SelectTab("tabBeds");
                tabControl1.TabPages.Remove(tabDoctor);
                tabControl1.TabPages.Remove(tabBilling);
                btnAddPatient.Hide();
                lblAddPatients.Hide();
            }

        }

        private void HomeDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        // --------------------------- PATIENT SEARCH ----------------------------------------------------------------------------------------------
        private void comboSearchPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSearchPatient.SelectedIndex == 0)
                txtSearchLastName.Text = " Enter ID...";
            else if (comboSearchPatient.SelectedIndex == 1)
                txtSearchLastName.Text = " Enter last name...";
        }

        private void txtSearchLastName_Enter(object sender, EventArgs e)
        {
            if (txtSearchLastName.Text == " Type..." || txtSearchLastName.Text == " Enter ID..." || txtSearchLastName.Text == " Enter last name...")
                txtSearchLastName.Text = "";
        }

        private void txtSearchLastName_Leave(object sender, EventArgs e)
        {
            if (txtSearchLastName.Text == "")
            {
                if (comboSearchPatient.SelectedIndex == 0)
                    txtSearchLastName.Text = " Enter ID...";
                else if (comboSearchPatient.SelectedIndex == 1)
                    txtSearchLastName.Text = " Enter last name...";
                else
                    txtSearchLastName.Text = " Type...";
            }
        }

        private void loadDeptIds ()
        {
            List<int> listOfIds = dao.GetDeptIds();
            cmbDeptID.Items.Clear();
            foreach (var item in listOfIds)
            {
                cmbDeptID.Items.Add(item);
            }
        }

        private void btnInsertDoctor_Click(object sender, EventArgs e)
        {
            ////// TODO - make error check method for all this
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string address = txtAddress.Text;
            bool gender = false;
            if ((cmbGender.SelectedItem.ToString()).Equals("Female"))
            {
                gender = true;
            }            
            string phoneNumber = txtPhoneNo.Text;
            string qualification = txtQualifcation.Text;
            int deptId = 0;
            string tempId = cmbDeptID.SelectedItem.ToString();
            int.TryParse(tempId, out deptId);
            /////////

            Doctor doc = new Doctor(firstName, lastName, address, gender, phoneNumber, qualification, deptId);

            dao.InsertDoctor(doc);
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            pnlHomescreen.Hide();
            pnlInsertPatient.Show();
        }

        private void HomeDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDatabaseDataSet.PatientDetails' table. You can move, or remove it, as needed.
            this.patientDetailsTableAdapter.Fill(this.hospitalDatabaseDataSet.PatientDetails);

        }
        //------------- Insert patient ------------------------------------------------------------------------------------
        private void btnInsertPatient_Click(object sender, EventArgs e)
        {
            string forename = txtPatientForename.Text;
            string surname = txtPatientSurname.Text;
            bool gender = false;
            if(cmbPatientGender.SelectedIndex == 0)
            {
                gender = true;
            }
            string address = txtPatientAddress.Text;
            string phone = txtPatientPhone.Text;
            string kin = txtPatientNOK.Text;
            string dob = txtPatientDOB.Text;

            DateTime birth = Convert.ToDateTime(txtPatientDOB.Text);
            Patient sickboi = new Patient(forename, surname, birth, address, gender, phone, kin);

            bool inserted = dao.InsertPatient(sickboi);

            if (inserted == true)
            {
                MessageBox.Show("Patient inserted succesfully");
                //clear the screen and go back to home page
                Clear();
                pnlHomescreen.Show();
                pnlInsertPatient.Hide();
            }
            else
                MessageBox.Show("Failed");

        }
        //--------------- PATIENT: Clear all fields -----------------------
        public void Clear()
        {
            foreach(Control c in pnlInsertPatient.Controls) {
                if(c is TextBox)
                {
                    c.Text = "";
                }
            }
        }
        //-------------- PATIENT: Hide error messages
        private void hideErrors()
        {
            foreach (Control lbl in pnlErrors.Controls)
            {
                lbl.Hide();
            }
        }
        //--------------------- PATIENT: Checking is fields are empty
        private void test()
        {
            btnInsertPatient.Enabled = false;
            
            var emptyTextboxes = from tb in pnlInsertPatient.Controls.OfType<TextBox>()
                                 where string.IsNullOrEmpty(tb.Text)
                                 select tb;
            if (emptyTextboxes.Any() || cmbPatientGender.SelectedIndex == -1)
            {
                btnInsertPatient.Enabled = false;
            }
            else
                btnInsertPatient.Enabled = true;
        }
        //-------------------- PATIENT: Leave textbox event -------------------------------------------------------------------
        private void txtPatientForename_Leave(object sender, EventArgs e)
        {
            if (txtPatientForename.Text == string.Empty || !alphabetOnly.IsMatch(txtPatientForename.Text.ToString()))
            {
                lblPatientForname.ForeColor = Color.Red;
                lblNameError.Show();
                btnInsertPatient.Enabled = false;

            } else
            {
                lblPatientForname.ForeColor = Color.MidnightBlue;
                lblNameError.Hide();
                test();
            }
        }
        private void txtPatientSurname_Leave(object sender, EventArgs e)
        {
            if (txtPatientSurname.Text == string.Empty || !alphabetOnly.IsMatch(txtPatientSurname.Text.ToString()))
            {
                lblPatientSurname.ForeColor = Color.Red;
                lblSurnameError.Show();
                btnInsertPatient.Enabled = false;
            }
            else
            {
                lblPatientSurname.ForeColor = Color.MidnightBlue;
                lblSurnameError.Hide();
                test();
            }
        }

        private void txtPatientAddress_Leave(object sender, EventArgs e)
        {
            if (txtPatientAddress.Text == string.Empty)
            {
                lblPatientAddress.ForeColor = Color.Red;
                LblAddressError.Show();
                btnInsertPatient.Enabled = false;
            }
            else
            {
                lblPatientAddress.ForeColor = Color.MidnightBlue;
                LblAddressError.Hide();
                test();
            }
        }

        private void txtPatientNOK_Leave(object sender, EventArgs e)
        {
            if (txtPatientNOK.Text == string.Empty || !alphabetOnly.IsMatch(txtPatientNOK.Text.ToString()))
            {
                lblPatientKin.ForeColor = Color.Red;
                LblKinError.Show();
                btnInsertPatient.Enabled = false;
            }
            else
            {
                lblPatientKin.ForeColor = Color.MidnightBlue;
                LblKinError.Hide();
                test();
            }
        }

        private void txtPatientPhone_Leave(object sender, EventArgs e)
        {
            if (txtPatientPhone.Text == string.Empty || !numbersOnly.IsMatch(txtPatientPhone.Text.ToString()))
            {
                lblPatientPhone.ForeColor = Color.Red;
                LblPhoneError.Show();
                btnInsertPatient.Enabled = false;
            }
            else
            {
                lblPatientPhone.ForeColor = Color.MidnightBlue;
                LblPhoneError.Hide();
                test();
            }
        }

        private void txtPatientDOB_Leave(object sender, EventArgs e)
        {
            if (txtPatientDOB.Text == string.Empty)
            {
                lblPatientDOB.ForeColor = Color.Red;
                lblDOBError.Show();
                btnInsertPatient.Enabled = false;
            }
            else
            {
                lblPatientDOB.ForeColor = Color.MidnightBlue;
                lblDOBError.Hide();
                test();
            }
        }

        private void cmbPatientGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            test();
        }
    }
}
