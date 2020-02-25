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
        public PatientsDashboard()
        {
            InitializeComponent();
            test();
            pnlInsertPatient.Hide();
            hideErrors();
            this.role = role;
            if (role == UserRole.Admin)
            {
                tabControl1.SelectTab("tabPatient");
                Console.WriteLine((int)role);
            }
            else if (role == UserRole.Doctor)
            {
                tabControl1.SelectTab("tabBeds");
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
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            pnlHomescreen.Hide();
            pnlInsertPatient.Show();
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
    }
}
