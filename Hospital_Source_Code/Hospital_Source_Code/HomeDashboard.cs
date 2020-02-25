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
            else if (role == UserRole.HR)
            {
                tabControl1.SelectTab("tabDoctor");
                tabControl1.TabPages.Remove(tabPatient);
                tabControl1.TabPages.Remove(tabBilling);
                tabControl1.TabPages.Remove(tabBeds);
            }
            else if (role == UserRole.Accounts)
            {
                tabControl1.SelectTab("tabBilling");
                tabControl1.TabPages.Remove(tabBeds);
                tabControl1.TabPages.Remove(tabPatient);
                tabControl1.TabPages.Remove(tabDoctor);
            }
            else if (role == UserRole.Doctor)
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

        private void loadDeptIds()
        {
            List<int> listOfIds = dao.GetDeptIds();
            cmbDocDeptID.Items.Clear();
            foreach (var item in listOfIds)
            {
                cmbDocDeptID.Items.Add(item);
            }
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

        private void btnSearchDoc_Click(object sender, EventArgs e)
        {
            string searchCriteria = cmbSearchCriteria.SelectedItem.ToString();
            if (searchCriteria.Equals("ID"))
            {
                if (int.TryParse(txtSearchDoc1.Text, out int docId))
                {
                    populateDetails(docId);
                }
            }
            else
            {
                string surname = txtSearchDoc1.Text;

                if (!surname.Equals(string.Empty))
                {
                    SearchDoctorsSurname searchDoctors = new SearchDoctorsSurname(this, surname);
                    searchDoctors.Show();
                }
            }
        }

        public void populateDetails(int docId)
        {
            Doctor doc = dao.GetDoctor(docId);
            if (doc.ID == 0)
            {
                MessageBox.Show(this, "ID does not match any in our system, please enter valid ID", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblDocID.Text = doc.ID.ToString();
            txtDocFirstName.Text = doc.FirstName;
            txtDocLastName.Text = doc.LastName;
            txtDocAddress.Text = doc.Address;
            if (doc.Gender == true)
            {
                cmbDocGender.Text = "Female";
            }
            else
            {
                cmbDocGender.Text = "Male";
            }
            txtDocPhoneNo.Text = doc.PhoneNumber;
            txtDocQualification.Text = doc.Qualification;
            cmbDocDeptID.Text = doc.DepartID.ToString();

        }
        private void btnUpdateDoctor_Click(object sender, EventArgs e)
        {
            ////// TODO - make error check method for all this
            int.TryParse(lblDocID.Text, out int id);
            string firstName = txtDocFirstName.Text;
            string lastName = txtDocLastName.Text;
            string address = txtDocAddress.Text;
            bool gender = false;
            if ((cmbDocGender.SelectedItem.ToString()).Equals("Female"))
            {
                gender = true;
            }
            string phoneNumber = txtDocPhoneNo.Text;
            string qualification = txtDocQualification.Text;
            int deptId = 0;
            string tempId = cmbDocDeptID.SelectedItem.ToString();
            int.TryParse(tempId, out deptId);
            /////////

            Doctor doc = new Doctor(id, firstName, lastName, gender, address, phoneNumber, qualification, deptId);

            dao.UpdateDoctor(doc);
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
                lblPatientForename.ForeColor = Color.MidnightBlue;
                lblNameError.Hide();
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
        private void cmbSearchCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchCriteria.SelectedItem.ToString() == "ID")
            {
                lblSearchDoc1.Text = "Enter ID";
            }
            else if (cmbSearchCriteria.SelectedItem.ToString() == "Surname")
            {
                lblSearchDoc1.Text = "Enter Surname";
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



