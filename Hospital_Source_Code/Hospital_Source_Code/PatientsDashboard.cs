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
    public partial class PatientsDashboard : Form
    {
        DAO dao = new DAO();
        Regex numbersOnly = new Regex(@"^[0-9]+$");
        Regex alphabetOnly = new Regex(@"^[a-zA-Z]+$");

        UserRole role;
        public PatientsDashboard(UserRole role, string userName)
        {
            InitializeComponent();
            test();
            pnlInsertPatient.Hide();
            btnSearchPatient.Enabled = false;
            hideErrors();
            this.role = role;
            if (role == UserRole.Admin)
            {
                tabPatient.SelectTab("tabPatients");
                Console.WriteLine((int)role);
            }
            else if (role == UserRole.Doctor)
            {
                tabPatient.SelectTab("tabBeds");
                btnAddPatient.Hide();
                lblAddPatients.Hide();
            }
        }
        // --------------------------- PATIENT SEARCH ----------------------------------------------------------------------------------------------
        private void comboSearchPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSearchPatient.Enabled = true;
            label1.Show();
            label1.ForeColor = Color.MidnightBlue;
            txtSearchPat.Text = "";
        }

        private void txtSearchLastName_Enter(object sender, EventArgs e)
        {
            label1.Hide();
            label1.ForeColor = Color.MidnightBlue;
            if (txtSearchPat.Text == " Type..." || txtSearchPat.Text == " Enter ID..." || txtSearchPat.Text == " Enter last name...")
                txtSearchPat.Text = "";
        }

        private void txtSearchLastName_Leave(object sender, EventArgs e)
        {
            if (txtSearchPat.Text == "")
            {
                label1.Show();
            }
        }
        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            string searchCriteria = comboSearchPatient.SelectedItem.ToString();
            if (searchCriteria.Equals("ID"))
            {
                if (int.TryParse(txtSearchPat.Text, out int docId))
                {
                    //populateDetails(docId);
                }
                else
                    label1.ForeColor = Color.Red;
            }
            else
            {
                string surname = txtSearchPat.Text;

                if (!surname.Equals(string.Empty))
                {
                    SearchPatients searchDoctors = new SearchPatients(this, surname);
                    searchDoctors.Show();
                }
                else label1.ForeColor = Color.Red;
            }
        }
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            pnlInsertPatient.Show();
            pnlHomescreen.Hide();
        }
        //------------- Insert patient -------------------------------------------------------------------------------------------------------------------------------------------
        private void btnInsertPatient_Click(object sender, EventArgs e)
        {
            bool aintRed = RedLabels();
            if (aintRed)
            {
                string forename = txtPatientForename.Text;
                string surname = txtPatientSurname.Text;
                bool gender = false;
                if (cmbPatientGender.SelectedIndex == 0)
                {
                    gender = true;
                }
                string address = txtPatientAddress.Text;
                string phone = txtPatientPhone.Text;
                string kin = txtPatientNOK.Text;

                DateTime.TryParse(txtPatientDOB.Text, out DateTime birth);
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
            else
                MessageBox.Show("ain't gonna happen...");
        }
        //--------------- PATIENT: Clear all fields -----------------------
        public void Clear()
        {
            foreach (Control c in pnlInsertPatient.Controls)
            {
                if (c is TextBox)
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
        private bool RedLabels() //Label check
        {
            bool aintRed = true;
            foreach (Control control in pnlInsertPatient.Controls)
            {
                if (control.ForeColor == Color.Red)
                {
                    aintRed = false;
                }
            }
            return aintRed;
        }
        //-------------------- PATIENT: Leave textbox event -------------------------------------------------------------------
        private void txtPatientForename_Leave_1(object sender, EventArgs e)
        {
            if (txtPatientForename.Text == string.Empty || !alphabetOnly.IsMatch(txtPatientForename.Text.ToString()))
            {
                lblPatientForename.ForeColor = Color.Red;
                lblNameError.Show();
            }
            else
            {
                lblPatientSurname.ForeColor = Color.MidnightBlue;
                lblSurnameError.Hide();
                test();
            }

        }
        private void txtPatientSurname_Leave_1(object sender, EventArgs e)
        {
            if (txtPatientSurname.Text == string.Empty || !alphabetOnly.IsMatch(txtPatientSurname.Text.ToString()))
            {
                lblPatientSurname.ForeColor = Color.Red;
                lblSurnameError.Show();
            }
            else
            {
                lblPatientSurname.ForeColor = Color.MidnightBlue;
                lblSurnameError.Hide();
                test();
            }
        }
        private void txtPatientDOB_Leave_1(object sender, EventArgs e)
        {
            if (txtPatientDOB.Text == string.Empty)
            {
                lblPatientDOB.ForeColor = Color.Red;
                lblDOBError.Show();
            }
            else
            {
                lblPatientDOB.ForeColor = Color.MidnightBlue;
                lblDOBError.Hide();
                test();
            }
        }
        private void txtPatientAddress_Leave_1(object sender, EventArgs e)
        {
            if (txtPatientAddress.Text == string.Empty)
            {
                lblPatientAddress.ForeColor = Color.Red;
            }
            else
            {
                lblPatientAddress.ForeColor = Color.MidnightBlue;
                lblAddressError.Hide();
                test();
            }
        }
        private void txtPatientPhone_Leave_1(object sender, EventArgs e)
        {
            if (txtPatientPhone.Text == string.Empty || !numbersOnly.IsMatch(txtPatientPhone.Text.ToString()))
            {
                lblPatientPhone.ForeColor = Color.Red;
                lblPhoneError.Show();
            }
            else
            {
                lblPatientPhone.ForeColor = Color.MidnightBlue;
                lblPhoneError.Hide();
                test();
            }
        }
        private void txtPatientNOK_Leave_1(object sender, EventArgs e)
        {
            if (txtPatientNOK.Text == string.Empty || !alphabetOnly.IsMatch(txtPatientNOK.Text.ToString()))
            {
                lblPatientKin.ForeColor = Color.Red;
                lblKinError.Show();
            }
            else
            {
                lblPatientKin.ForeColor = Color.MidnightBlue;
                lblKinError.Hide();
                test();
            }
        }
        private void cmbPatientGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            test();
        }
        private void txtPatientForename_TextChanged(object sender, EventArgs e)
        {
            test();
        }

        private void PatientsDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
