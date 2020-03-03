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

        

        public HomeDashboard(UserRole role, string userName)
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

        private void btnInsertDoctor_Click(object sender, EventArgs e)
        {

        }


        private void btnSearchAllBillsIssued_Click_1(object sender, EventArgs e)
        {
            frmSearch searchForm = new frmSearch(this);
            searchForm.Show();
        }

        private void btnIssueBills_Click(object sender, EventArgs e)
        {
            frmBillsToBeIssued issueForm = new frmBillsToBeIssued();
            
            issueForm.Show();
        }


        public void DisplayBill(HospitalDatabaseDataSet.BillVisitDetailsDataTable billDetail)
        {
            decimal total = 0;

            Console.WriteLine("Test: " + billDetail.Rows[0]["Id"]);
            labPatientName.Text = "Patient Name: "+ billDetail.Rows[0]["Forename"] + " " + billDetail.Rows[0]["Surname"];
            labBillId.Text = "Bill ID: "+billDetail.Rows[0]["Id"].ToString();
            labIssuedDate.Text = "Date Issued: "+((DateTime)billDetail.Rows[0]["Date"]).ToString("dd/MM/yyyy");
            labPatientId.Text = "Patient ID: "+billDetail.Rows[0]["PatientId"].ToString();
            if (!billDetail.Rows[0]["RoomCharge"].Equals(null))
            {
                total = (decimal)billDetail[0]["RoomCharge"];
                labRoomCharge.Text = "Room Charge: €"+billDetail[0]["RoomCharge"].ToString();
            }
            else
            {
                labRoomCharge.Text = "";
            }
            labDoctorFees.Text = "Doctor Fee: €"+billDetail.Rows[0]["DoctorsFee"].ToString();
            total = total + (decimal)billDetail.Rows[0]["DoctorsFee"];
            labNote.Text = "Notes: "+billDetail.Rows[0]["Note"].ToString();

            if (!billDetail.Rows[0]["MiscellaneousFee"].Equals(null))
            {
                labMiscellaneous.Text = "Miscellaneous: €" + billDetail.Rows[0]["MiscellaneousFee"].ToString();
                total = total + (decimal)billDetail.Rows[0]["MiscellaneousFee"];
            }
            else
            {
                labMiscellaneous.Text = "Miscellaneous: €00.00";
            }

            labTotal.Text = "Total: €"+total.ToString();


            
        }

    }
}
