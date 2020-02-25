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
    public partial class DoctorsDashboard : Form
    {
        DAO dao = new DAO();
        Regex numbersOnly = new Regex(@"^[0-9]+$");
        Regex alphabetOnly = new Regex(@"^[a-zA-Z]+$");

        public DoctorsDashboard()
        {
            InitializeComponent();
            loadDeptIds();
        }

        private void HomeDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void cmbSearchCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSearchCriteria_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtSearchDoc1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
