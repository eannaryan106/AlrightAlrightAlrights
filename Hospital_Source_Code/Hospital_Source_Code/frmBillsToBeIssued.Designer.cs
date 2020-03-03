namespace Hospital_Source_Code
{
    partial class frmBillsToBeIssued
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.unissuedBillsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDatabaseDataSet1 = new Hospital_Source_Code.HospitalDatabaseDataSet();
            this.visitDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDatabaseDataSet = new Hospital_Source_Code.HospitalDatabaseDataSet();
            this.visitDetailsTableAdapter = new Hospital_Source_Code.HospitalDatabaseDataSetTableAdapters.VisitDetailsTableAdapter();
            this.btnIssueBill = new System.Windows.Forms.Button();
            this.unissuedBillsTableTableAdapter = new Hospital_Source_Code.HospitalDatabaseDataSetTableAdapters.UnissuedBillsTableTableAdapter();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdmissionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DischargeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Appointment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unissuedBillsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn,
            this.vDIDDataGridViewTextBoxColumn,
            this.AdmissionDate,
            this.DischargeDate,
            this.Appointment,
            this.Cost,
            this.Forename,
            this.Surname,
            this.PatientNotes});
            this.dataGridView1.DataSource = this.unissuedBillsTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(103, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(942, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // unissuedBillsTableBindingSource
            // 
            this.unissuedBillsTableBindingSource.DataMember = "UnissuedBillsTable";
            this.unissuedBillsTableBindingSource.DataSource = this.hospitalDatabaseDataSet1;
            // 
            // hospitalDatabaseDataSet1
            // 
            this.hospitalDatabaseDataSet1.DataSetName = "HospitalDatabaseDataSet";
            this.hospitalDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitDetailsBindingSource
            // 
            this.visitDetailsBindingSource.DataMember = "VisitDetails";
            this.visitDetailsBindingSource.DataSource = this.hospitalDatabaseDataSet;
            // 
            // hospitalDatabaseDataSet
            // 
            this.hospitalDatabaseDataSet.DataSetName = "HospitalDatabaseDataSet";
            this.hospitalDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitDetailsTableAdapter
            // 
            this.visitDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // btnIssueBill
            // 
            this.btnIssueBill.Location = new System.Drawing.Point(914, 385);
            this.btnIssueBill.Name = "btnIssueBill";
            this.btnIssueBill.Size = new System.Drawing.Size(108, 27);
            this.btnIssueBill.TabIndex = 1;
            this.btnIssueBill.Text = "Generate Bill";
            this.btnIssueBill.UseVisualStyleBackColor = true;
            this.btnIssueBill.Click += new System.EventHandler(this.button1_Click);
            // 
            // unissuedBillsTableTableAdapter
            // 
            this.unissuedBillsTableTableAdapter.ClearBeforeFill = true;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vDIDDataGridViewTextBoxColumn
            // 
            this.vDIDDataGridViewTextBoxColumn.DataPropertyName = "VD_ID";
            this.vDIDDataGridViewTextBoxColumn.HeaderText = "VD_ID";
            this.vDIDDataGridViewTextBoxColumn.Name = "vDIDDataGridViewTextBoxColumn";
            this.vDIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AdmissionDate
            // 
            this.AdmissionDate.DataPropertyName = "AdmissionDate";
            this.AdmissionDate.HeaderText = "AdmissionDate";
            this.AdmissionDate.Name = "AdmissionDate";
            this.AdmissionDate.ReadOnly = true;
            // 
            // DischargeDate
            // 
            this.DischargeDate.DataPropertyName = "DischargeDate";
            this.DischargeDate.HeaderText = "DischargeDate";
            this.DischargeDate.Name = "DischargeDate";
            this.DischargeDate.ReadOnly = true;
            // 
            // Appointment
            // 
            this.Appointment.DataPropertyName = "Appointment";
            this.Appointment.HeaderText = "Appointment";
            this.Appointment.Name = "Appointment";
            this.Appointment.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // Forename
            // 
            this.Forename.DataPropertyName = "Forename";
            this.Forename.HeaderText = "Forename";
            this.Forename.Name = "Forename";
            this.Forename.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.DataPropertyName = "Surname";
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // PatientNotes
            // 
            this.PatientNotes.DataPropertyName = "PatientNotes";
            this.PatientNotes.HeaderText = "PatientNotes";
            this.PatientNotes.Name = "PatientNotes";
            this.PatientNotes.ReadOnly = true;
            // 
            // frmBillsToBeIssued
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 450);
            this.Controls.Add(this.btnIssueBill);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmBillsToBeIssued";
            this.Text = "frmBillsToBeIssued";
            this.Load += new System.EventHandler(this.frmBillsToBeIssued_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unissuedBillsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HospitalDatabaseDataSet hospitalDatabaseDataSet;
        private System.Windows.Forms.BindingSource visitDetailsBindingSource;
        private HospitalDatabaseDataSetTableAdapters.VisitDetailsTableAdapter visitDetailsTableAdapter;
        private System.Windows.Forms.Button btnIssueBill;
        private HospitalDatabaseDataSet hospitalDatabaseDataSet1;
        private System.Windows.Forms.BindingSource unissuedBillsTableBindingSource;
        private HospitalDatabaseDataSetTableAdapters.UnissuedBillsTableTableAdapter unissuedBillsTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdmissionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DischargeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Appointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientNotes;
    }
}