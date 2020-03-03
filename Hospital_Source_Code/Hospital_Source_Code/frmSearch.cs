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
    
    public partial class frmSearch : Form
    {
        HomeDashboard form1;
        Bill invoice = new Bill();
        public frmSearch(HomeDashboard form1)
        {
            InitializeComponent();
            this.form1 = form1;

        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDatabaseDataSet.BillingDetails' table. You can move, or remove it, as needed.
            billingDetailsTableAdapter.Fill(hospitalDatabaseDataSet.BillingDetails);

            cboField.Items.Add("Id");
            cboField.Items.Add("PatiendId");


            cboOperator.Items.Add("=");
            cboOperator.Items.Add("<");
            cboOperator.Items.Add(">");
            cboOperator.Items.Add("<=");
            cboOperator.Items.Add(">=");

            this.dataGridView1.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            if(cboField.Text == string.Empty ||
                cboOperator.Text == string.Empty ||
                txtValue.Text == string.Empty)
            {
                MessageBox.Show("Please enter a field, operator and value",
                    "Empty Field", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                DAO dao = new DAO();
                DataSet dataSet = dao.SearchBills(cboField.Text, cboOperator.Text, txtValue.Text);
                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "BillingTable";
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
                    dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);


            if (selectedRowCount > 0)
            {

                Console.WriteLine(dataGridView1.SelectedCells[1].Value.ToString());

               

               
                HospitalDatabaseDataSetTableAdapters.BillVisitTableAdaptor billingDetailsTableAdapter = new HospitalDatabaseDataSetTableAdapters.BillVisitTableAdaptor();
                HospitalDatabaseDataSet.BillVisitDetailsDataTable billDataTable = billingDetailsTableAdapter.getDataByVisit((int)(dataGridView1.SelectedCells[1].Value));
                Console.WriteLine("TEst 2: "+dataGridView1.SelectedCells[1].Value);
                form1.DisplayBill(billDataTable);
                Dispose();
            }
            else
            {
                MessageBox.Show("Please select an invoice");
            }
        }
    }
}
