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
    public partial class SearchDoctorsSurname : Form
    {
        DAO dao = new DAO();
        HomeDashboard homeDash;

        public SearchDoctorsSurname(HomeDashboard dash, string surname)
        {
            InitializeComponent();
            populateList(surname);
            homeDash = dash;
        }

        private void populateList(string surname)
        {
            dGDDoctors.AllowUserToAddRows = false;
            DataSet dataSet = dao.GetDoctors(surname);
            
            dGDDoctors.DataSource = dataSet;
            dGDDoctors.DataMember = "DoctorsTable";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var row = dGDDoctors.CurrentCell.RowIndex;
            var id = dGDDoctors[2, row].Value;
            if (id is int)
            {
                homeDash.populateDetails((int)id);
            }
        }
    }
}
