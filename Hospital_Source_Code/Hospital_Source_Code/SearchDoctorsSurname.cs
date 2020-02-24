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

        public SearchDoctorsSurname(HomeDashboard dash, string surname)
        {
            Console.WriteLine("Got Here 4");
            InitializeComponent();
            populateList(surname);
        }

        private void populateList(string surname)
        {
            Console.WriteLine("Got Here 5");
            dGDDoctors.AllowUserToAddRows = false;
            DataSet dataSet = dao.GetDoctors(surname);
            
            dGDDoctors.DataSource = dataSet;
            dGDDoctors.DataMember = "DoctorsTable";

                //dGDDoctors[0, i].Value = listOfDocs[i].LastName;
                //dGDDoctors[1, i].Value = listOfDocs[i].FirstName;
                //dGDDoctors[2, i].Value = listOfDocs[i].ID;
                //dGDDoctors[3, i].Value = listOfDocs[i].DepartID;
                //dGDDoctors[4, i].Value = listOfDocs[i].Qualification;
        }
    }
}
