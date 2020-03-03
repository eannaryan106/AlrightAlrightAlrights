namespace Hospital_Source_Code
{
    partial class frmSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.billingDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billingDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.VisitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.cboOperator = new System.Windows.Forms.ComboBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomChargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorsFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miscellaneousFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospitalDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDatabaseDataSet = new Hospital_Source_Code.HospitalDatabaseDataSet();
            this.billingDetailsTableAdapter = new Hospital_Source_Code.HospitalDatabaseDataSetTableAdapters.BillingDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.billingDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(740, 85);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(98, 37);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(740, 361);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 37);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // billingDetailsBindingSource
            // 
            this.billingDetailsBindingSource.DataMember = "BillingDetails";
            this.billingDetailsBindingSource.DataSource = this.hospitalDatabaseDataSetBindingSource;
            // 
            // billingDetailsBindingSource1
            // 
            this.billingDetailsBindingSource1.DataMember = "BillingDetails";
            this.billingDetailsBindingSource1.DataSource = this.hospitalDatabaseDataSetBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.VisitID,
            this.dateDataGridViewTextBoxColumn,
            this.patientIdDataGridViewTextBoxColumn,
            this.roomChargeDataGridViewTextBoxColumn,
            this.doctorsFeeDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.miscellaneousFeeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.billingDetailsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(842, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // VisitID
            // 
            this.VisitID.DataPropertyName = "VisitID";
            this.VisitID.HeaderText = "VisitID";
            this.VisitID.Name = "VisitID";
            this.VisitID.ReadOnly = true;
            // 
            // cboField
            // 
            this.cboField.FormattingEnabled = true;
            this.cboField.Location = new System.Drawing.Point(57, 85);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(121, 21);
            this.cboField.TabIndex = 3;
            // 
            // cboOperator
            // 
            this.cboOperator.FormattingEnabled = true;
            this.cboOperator.Location = new System.Drawing.Point(268, 85);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.Size = new System.Drawing.Size(121, 21);
            this.cboOperator.TabIndex = 4;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(482, 85);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(130, 20);
            this.txtValue.TabIndex = 5;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(740, 141);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(98, 35);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientIdDataGridViewTextBoxColumn
            // 
            this.patientIdDataGridViewTextBoxColumn.DataPropertyName = "PatientId";
            this.patientIdDataGridViewTextBoxColumn.HeaderText = "PatientId";
            this.patientIdDataGridViewTextBoxColumn.Name = "patientIdDataGridViewTextBoxColumn";
            this.patientIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomChargeDataGridViewTextBoxColumn
            // 
            this.roomChargeDataGridViewTextBoxColumn.DataPropertyName = "RoomCharge";
            this.roomChargeDataGridViewTextBoxColumn.HeaderText = "RoomCharge";
            this.roomChargeDataGridViewTextBoxColumn.Name = "roomChargeDataGridViewTextBoxColumn";
            this.roomChargeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorsFeeDataGridViewTextBoxColumn
            // 
            this.doctorsFeeDataGridViewTextBoxColumn.DataPropertyName = "DoctorsFee";
            this.doctorsFeeDataGridViewTextBoxColumn.HeaderText = "DoctorsFee";
            this.doctorsFeeDataGridViewTextBoxColumn.Name = "doctorsFeeDataGridViewTextBoxColumn";
            this.doctorsFeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // miscellaneousFeeDataGridViewTextBoxColumn
            // 
            this.miscellaneousFeeDataGridViewTextBoxColumn.DataPropertyName = "MiscellaneousFee";
            this.miscellaneousFeeDataGridViewTextBoxColumn.HeaderText = "MiscellaneousFee";
            this.miscellaneousFeeDataGridViewTextBoxColumn.Name = "miscellaneousFeeDataGridViewTextBoxColumn";
            this.miscellaneousFeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hospitalDatabaseDataSetBindingSource
            // 
            this.hospitalDatabaseDataSetBindingSource.DataSource = this.hospitalDatabaseDataSet;
            this.hospitalDatabaseDataSetBindingSource.Position = 0;
            // 
            // hospitalDatabaseDataSet
            // 
            this.hospitalDatabaseDataSet.DataSetName = "HospitalDatabaseDataSet";
            this.hospitalDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billingDetailsTableAdapter
            // 
            this.billingDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 410);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.cboOperator);
            this.Controls.Add(this.cboField);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Name = "frmSearch";
            this.Text = "frmSearch";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billingDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClose;
        private HospitalDatabaseDataSet hospitalDatabaseDataSet;
        private System.Windows.Forms.BindingSource hospitalDatabaseDataSetBindingSource;
        private System.Windows.Forms.BindingSource billingDetailsBindingSource;
        private HospitalDatabaseDataSetTableAdapters.BillingDetailsTableAdapter billingDetailsTableAdapter;
        private System.Windows.Forms.BindingSource billingDetailsBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.ComboBox cboOperator;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomChargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorsFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miscellaneousFeeDataGridViewTextBoxColumn;
    }
}