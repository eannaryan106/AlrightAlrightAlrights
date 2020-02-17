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
        UserRole role;
        public HomeDashboard(UserRole role)
        {
            InitializeComponent();
            this.role = role;
            if (role == UserRole.Admin)
            {
                tabControl1.SelectTab("tabPatient");
                tabControl1.TabPages.Remove(tabDoctor);
                tabControl1.TabPages.Remove(tabBilling);
                Console.WriteLine((int)role);
            }
            else if(role == UserRole.HR)
            {
                tabControl1.SelectTab("tabDoctor");
                tabControl1.TabPages.Remove(tabPatient);
                tabControl1.TabPages.Remove(tabBilling);
                tabControl1.TabPages.Remove(tabBeds);
            }
            else if(role == UserRole.Accounts)
            {
                tabControl1.SelectTab("tabBilling");
                tabControl1.TabPages.Remove(tabBeds);
                tabControl1.TabPages.Remove(tabPatient);
                tabControl1.TabPages.Remove(tabDoctor);
            }
            else if(role == UserRole.Doctor)
            {
                tabControl1.SelectTab("tabBeds");
                tabControl1.TabPages.Remove(tabDoctor);
                tabControl1.TabPages.Remove(tabBilling);
            }

        }

        private void HomeDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
