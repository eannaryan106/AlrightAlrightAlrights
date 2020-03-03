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
    public partial class frmBillsToBeIssued : Form
    {

        public frmBillsToBeIssued()
        {
            InitializeComponent();

        }

        private void frmBillsToBeIssued_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDatabaseDataSet1.UnissuedBillsTable' table. You can move, or remove it, as needed.
            this.unissuedBillsTableTableAdapter.Fill(this.hospitalDatabaseDataSet1.UnissuedBillsTable);

            this.dataGridView1.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Int32 selectedRowCount =
                   dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);


            if (selectedRowCount > 0)
            {

                Console.WriteLine(dataGridView1.SelectedCells[1].Value.ToString());


                Bill bill = new Bill();

                bill.PatientId = (int)(dataGridView1.SelectedCells[0].Value);
                bill.visitId = (int)(dataGridView1.SelectedCells[1].Value);
                bill.DateIssued = DateTime.Now;
                if (!dataGridView1.SelectedCells[2].Value.ToString().Equals("") && !dataGridView1.SelectedCells[3].Value.ToString().Equals(""))
                {
                     int days = ((DateTime)dataGridView1.SelectedCells[3].Value - (DateTime)dataGridView1.SelectedCells[2].Value).Days;
                    bill.RoomCharge = (decimal)(dataGridView1.SelectedCells[5].Value) * days; 
                }
                else
                {
                    bill.RoomCharge = 0;
                }
                bill.Note = dataGridView1.SelectedCells[8].Value.ToString();

                bill.fname = dataGridView1.SelectedCells[6].Value.ToString();
                bill.lname = dataGridView1.SelectedCells[7].Value.ToString();

                AddBill form1 = new AddBill(bill);
                form1.Show();
                Dispose();
            }
        }
    }
}

