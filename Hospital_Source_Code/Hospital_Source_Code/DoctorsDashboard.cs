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

        public DoctorsDashboard(UserRole role, string userName)
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
            if (cmbSearchCriteria.SelectedIndex == -1)
            {
                MessageBox.Show(this, "Please Select a Search Criteria", "No Search Type Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string searchCriteria = cmbSearchCriteria.SelectedItem.ToString();
            if (searchCriteria.Equals("ID"))
            {
                if (int.TryParse(txtSearchDoc1.Text, out int docId))
                {
                    populateDetails(docId);
                } else
                {
                    MessageBox.Show(this, "ID must be an integer, please enter a valid value", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (searchCriteria.Equals("Surname"))
            {
                string surname = txtSearchDoc1.Text;

                if (!surname.Equals(string.Empty) && !int.TryParse(surname, out int sur))
                {
                    SearchDoctorsSurname searchDoctors = new SearchDoctorsSurname(this, surname);
                    searchDoctors.Show();
                }
                else
                {
                    MessageBox.Show(this, "Invalid Data Entered for Surname, Please enter a Name with no numbers.", "Invalid Surname", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            btnUpdateDoctor.Enabled = true;
            btnUpdateDoctor.Visible = true;
            btnDocReport.Enabled = true;
            btnDocReport.Visible = true;

        }
        private void btnUpdateDoctor_Click(object sender, EventArgs e)
        {
            Doctor doc = verifyInput();
            if (doc.ID == 0)
            {
                MessageBox.Show(this, "Not All Fields Filled Out Correctly, Please Fill in the Areas with Red Lables", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dao.UpdateDoctor(doc))
            {
                MessageBox.Show(this, "Doctor Details Updated Succesfully", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Doctor verifyInput() {
            int id;            
            string firstName = txtDocFirstName.Text;
            string lastName = txtDocLastName.Text;
            string address = txtDocAddress.Text;
            bool gender = false;
            string phoneNumber = txtDocPhoneNo.Text;
            string qualification = txtDocQualification.Text;
            int deptId = 0;
            

            bool valid = true;

            if (int.TryParse(lblDocID.Text, out id))
            {
                if (firstName == string.Empty)
                {
                    lblDocFirstName2.ForeColor = Color.Red;
                    valid = false;
                }
                else {
                    lblDocFirstName2.ForeColor = Color.Black;
                }
                if (lastName == string.Empty)
                {
                    lblDocLastName2.ForeColor = Color.Red;
                    valid = false;
                }
                else {
                    lblDocLastName2.ForeColor = Color.Black;
                }
                if (address == string.Empty)
                {
                    lblDocAddress2.ForeColor = Color.Red;
                    valid = false;
                } else
                {
                    lblDocAddress2.ForeColor = Color.Black;
                }
                if (cmbDocGender.SelectedIndex == -1)
                {
                    lblDocGender2.ForeColor = Color.Red;
                    valid = false;
                } else
                {
                    if ((cmbDocGender.SelectedItem.ToString()).Equals("Female"))
                    {
                        gender = true;
                    }
                    lblDocGender2.ForeColor = Color.Black;
                }
                if (!int.TryParse(phoneNumber, out int phNo))
                {
                    lblDocPhoneNumber2.ForeColor = Color.Red;
                    valid = false;
                } else
                {
                    lblDocPhoneNumber2.ForeColor = Color.Black;
                }
                if (qualification == string.Empty)
                {
                    lblDocQualification2.ForeColor = Color.Red;
                    valid = false;
                } else
                {
                    lblDocQualification2.ForeColor = Color.Black;
                }
                if (cmbDocDeptID.SelectedIndex == -1)
                {
                    lblDocDepartmentID2.ForeColor = Color.Red;
                    valid = false;
                } else
                {
                    if (int.TryParse(cmbDocDeptID.SelectedItem.ToString(), out deptId))
                    {
                        lblDocDepartmentID2.ForeColor = Color.Black;
                    } else
                    {
                        lblDocDepartmentID2.ForeColor = Color.Red;
                        valid = false;
                    }                                     
                }                
            }
            if (valid)
            {
                Doctor doc = new Doctor(id, firstName, lastName, gender, address, phoneNumber, qualification, deptId);
                return doc;
            } else
            {
                Doctor doc = new Doctor();
                return doc;
            }

        }

        private void DoctorsDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDocReport_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lblDocID.Text, out int id))
            {
                PrintReport();
            }
            else {
                MessageBox.Show(this, "No Doctor Selected For Report, please select a doctor first", "No Doctor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PrintReport()
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font regFont = new Font("Arial", 12);
            float width = printDocument1.DefaultPageSettings.PrintableArea.Width;
            float h = 150;
            string gender = "Male";
            int.TryParse(lblDocID.Text, out int id);
            Doctor doc = dao.GetDoctor(id);
            e.Graphics.DrawString("Forename:", regFont, Brushes.Black, (width * 0.075f), 75);
            e.Graphics.DrawString("Surname:", regFont, Brushes.Black, (width * 0.075f), 100);
            e.Graphics.DrawString("Gender:", regFont, Brushes.Black, (width * 0.075f), 125);            
            e.Graphics.DrawString("Phone Number:", regFont, Brushes.Black, (width * 0.075f), 150);
            e.Graphics.DrawString("Qualification:", regFont, Brushes.Black, (width * 0.075f), 175);
            e.Graphics.DrawString("Department ID:", regFont, Brushes.Black, (width * 0.075f), 200);
            e.Graphics.DrawString("Address:", regFont, Brushes.Black, (width * 0.075f), 225);
            e.Graphics.DrawString(doc.FirstName, regFont, Brushes.Black, (width * 0.3f), 75);
            e.Graphics.DrawString(doc.LastName, regFont, Brushes.Black, (width * 0.3f), 100);
            if (doc.Gender == true)
            {
                gender = "Female";
            }
            e.Graphics.DrawString(gender, regFont, Brushes.Black, (width * 0.3f), 125);            
            e.Graphics.DrawString(doc.PhoneNumber, regFont, Brushes.Black, (width * 0.3f), 150);
            e.Graphics.DrawString(doc.Qualification, regFont, Brushes.Black, (width * 0.3f), 175);
            e.Graphics.DrawString(doc.DepartID.ToString(), regFont, Brushes.Black, (width * 0.3f), 200);
            e.Graphics.DrawString(doc.Address, regFont, Brushes.Black, (width * 0.3f), 225);
        }

        private void cmbSearchCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchCriteria.SelectedIndex == -1)
            {
                lblDocSearchType.Text = "Not Selected";
            } else
            {
                if (cmbSearchCriteria.SelectedItem.ToString().Equals("ID"))
                {
                    lblDocSearchType.Text = "Enter ID";
                } else
                {
                    lblDocSearchType.Text = "Enter Surname";
                }
            }
        }
    }
}
