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
    public partial class BedDashboard : Form
    {
        DAO dao = new DAO();
        Regex numbersOnly = new Regex(@"^[0-9]+$");
        Regex alphabetOnly = new Regex(@"^[a-zA-Z]+$");

        public BedDashboard(UserRole role, string userName)
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
            //cmbDocDeptID.Items.Clear();
            foreach (var item in listOfIds)
            {
                //cmbDocDeptID.Items.Add(item);
            }
        }
        public BedDashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Here we look at returning the results from the dao for the vacant beds
        private void btnSearchDoc_Click(object sender, EventArgs e)
        {
            string searchCriteria = cmbSearchCriteria.SelectedItem.ToString();
            if (searchCriteria.Equals("ID"))
            {
                if (int.TryParse(txtSearchDoc1.Text, out int docId))
                {
                    //populateDetails(docId);
                }
                else
                {
                    MessageBox.Show(this, "ID must be an integer, please enter a valid value", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                string surname = txtSearchDoc1.Text;

                if (!surname.Equals(string.Empty))
                {
                    //SearchDoctorsSurname searchDoctors = new SearchDoctorsSurname(this, surname);
                   // searchDoctors.Show();
                }
            }
        }
    }
}
