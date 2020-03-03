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
    public partial class SearchPatients : Form
    {
        DAO dao = new DAO();
        PatientsDashboard homeDash;

        public SearchPatients(PatientsDashboard dash, string surname)
        {
            InitializeComponent();
            populateList(surname);
            homeDash = dash;
        }

        private void populateList(string surname)
        {
            dGDPatients.AllowUserToAddRows = false;
            DataSet ds = dao.GetPatients(surname);

            dGDPatients.DataSource = ds;
            dGDPatients.DataMember = "PatientsTable";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var row = dGDPatients.CurrentCell.RowIndex;
            var id = dGDPatients[2, row].Value;
            if (id is int)
            {
                homeDash.PopulateFields((int)id);
                this.Close();
            }
        }
    }
}
