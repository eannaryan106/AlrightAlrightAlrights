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

        public HomeDashboard(UserRole role, string username) {
            InitializeComponent();
            if (role == UserRole.SuperUser)
            {
                Console.WriteLine((int)role);
            }
            Console.WriteLine(role);
            Console.WriteLine(username);
        }

        private void HomeDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboSearchPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboSearchPatient.SelectedIndex == 0)
            {
                txtSearchLastName.Enabled = false;
                txtSearchLastName.Text = " Type...";
            } else
                txtSearchLastName.Enabled = true;
        }

        private void txtSearchLastName_Enter(object sender, EventArgs e)
        {
            if(txtSearchLastName.Text == " Type...")
            {
                txtSearchLastName.Text = "";
            }
        }

        private void txtSearchLastName_Leave(object sender, EventArgs e)
        {
            if (txtSearchLastName.Text == "")
            {
                txtSearchLastName.Text = " Type...";
            }
        }
    }
}
