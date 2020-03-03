using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Source_Code.Classes;

namespace Hospital_Source_Code
{
    
    public partial class AddBill : Form
    {
        DAO dao = new DAO();
        Bill bill;
        public AddBill(Bill bill)
        {
            this.bill = bill;
            InitializeComponent();
            inputBill(bill);
        }

        public void inputBill(Bill bill)
        {
            labName.Text = "Patient Name: "+bill.fname + " " +bill.lname;
            labPatientId.Text = "Patient ID: " + bill.PatientId;
            labRoomCharge.Text = "Room Charges: €" + bill.RoomCharge;
            labNote.Text = "Patient Note: " + bill.Note;

        }

        private void bntAddBill_Click(object sender, EventArgs e)
        {
            decimal a;
            decimal b;
            if(decimal.TryParse(txtDoctorFee.Text, out a) && decimal.TryParse(txtMiscellFee.Text, out b)){

                bill.DoctorFee = a;
                bill.MicellFee = a;

                dao.InsertBill(bill);
                MessageBox.Show("Bill has been Send to patient", "Bill Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Please enter a amount for the doctor and miscellanous fees", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
    }
}
