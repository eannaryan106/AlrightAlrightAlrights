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
    public partial class HomeDashboard : Form
    {
        DAO dao = new DAO();

        UserRole role;
        public HomeDashboard(UserRole role, string userName)
        {
            InitializeComponent();
            pnlInsertPatient.Hide();
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
            else {
                string surname = txtSearchDoc1.Text;

                if (!surname.Equals(string.Empty))
                {
                    SearchDoctorsSurname searchDoctors = new SearchDoctorsSurname(this, surname);
                    searchDoctors.Show();
                }
            }
        }

            public void populateDetails(int docId) {
                Doctor doc = dao.GetDoctor(docId);
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
            //------------- Insert patient ------------------------------------------------------------------------------------
            private void btnInsertPatient_Click(object sender, EventArgs e)
            {
                string forename = txtPatientForename.Text;
                string surname = txtPatientSurname.Text;
                DateTime dob = Convert.ToDateTime(txtPatientDOB.Text);
                bool gender = false;
                if (cmbPatientGender.SelectedIndex == 0)
                {
                    gender = true;
                }
                string address = txtPatientAddress.Text;
                string phone = txtPatientPhone.Text;
                string kin = txtPatientNOK.Text;

                Patient sickboi = new Patient(forename, surname, dob, address, gender, phone, kin);

                bool inserted = dao.InsertPatient(sickboi);

                if (inserted == true)
                {
                    MessageBox.Show("Inserted");
                }
                else
                    MessageBox.Show("Failed");

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

        private void cmbSearchCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchCriteria.SelectedItem.ToString() == "ID")
            {
                lblSearchDoc1.Text = "Enter ID";
            } else if (cmbSearchCriteria.SelectedItem.ToString() == "Surname") {
                lblSearchDoc1.Text = "Enter Surname";
            }
        }
    }
    }
