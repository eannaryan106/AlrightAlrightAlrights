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
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDatabaseDataSet.BillingDetails' table. You can move, or remove it, as needed.
            this.billingDetailsTableAdapter.Fill(this.hospitalDatabaseDataSet.BillingDetails);

            cboField.Items.Add("Id");
            cboField.Items.Add("PatiendId");


            cboOperator.Items.Add("=");
            cboOperator.Items.Add("<");
            cboOperator.Items.Add(">");
            cboOperator.Items.Add("<=");
            cboOperator.Items.Add(">=");

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
                DAO 
            }
        }
    }
}
