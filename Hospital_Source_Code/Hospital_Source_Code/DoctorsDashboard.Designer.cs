namespace Hospital_Source_Code
{
    partial class DoctorsDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorsDashboard));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDoctors = new System.Windows.Forms.TabPage();
            this.lblDocIdlabel = new System.Windows.Forms.Label();
            this.lblDocID = new System.Windows.Forms.Label();
            this.lblDocDepartmentID2 = new System.Windows.Forms.Label();
            this.lblDocQualification2 = new System.Windows.Forms.Label();
            this.lblDocPhoneNumber2 = new System.Windows.Forms.Label();
            this.lblDocAddress2 = new System.Windows.Forms.Label();
            this.lblDocGender2 = new System.Windows.Forms.Label();
            this.lblDocLastName2 = new System.Windows.Forms.Label();
            this.lblDocFirstName2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDocQualification = new System.Windows.Forms.TextBox();
            this.txtDocPhoneNo = new System.Windows.Forms.TextBox();
            this.txtDocAddress = new System.Windows.Forms.TextBox();
            this.btnUpdateDoctor = new System.Windows.Forms.Button();
            this.cmbDocGender = new System.Windows.Forms.ComboBox();
            this.cmbDocDeptID = new System.Windows.Forms.ComboBox();
            this.txtDocLastName = new System.Windows.Forms.TextBox();
            this.txtDocFirstName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSearchDocCriteria = new System.Windows.Forms.Label();
            this.cmbSearchCriteria = new System.Windows.Forms.ComboBox();
            this.lblSearchDoc1 = new System.Windows.Forms.Label();
            this.txtSearchDoc1 = new System.Windows.Forms.TextBox();
            this.btnSearchDoc = new System.Windows.Forms.Button();
            this.btnDocReport = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tabControl1.SuspendLayout();
            this.tabDoctors.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDoctors);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1073, 685);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDoctors
            // 
            this.tabDoctors.Controls.Add(this.btnDocReport);
            this.tabDoctors.Controls.Add(this.lblDocIdlabel);
            this.tabDoctors.Controls.Add(this.lblDocID);
            this.tabDoctors.Controls.Add(this.lblDocDepartmentID2);
            this.tabDoctors.Controls.Add(this.lblDocQualification2);
            this.tabDoctors.Controls.Add(this.lblDocPhoneNumber2);
            this.tabDoctors.Controls.Add(this.lblDocAddress2);
            this.tabDoctors.Controls.Add(this.lblDocGender2);
            this.tabDoctors.Controls.Add(this.lblDocLastName2);
            this.tabDoctors.Controls.Add(this.lblDocFirstName2);
            this.tabDoctors.Controls.Add(this.label19);
            this.tabDoctors.Controls.Add(this.txtDocQualification);
            this.tabDoctors.Controls.Add(this.txtDocPhoneNo);
            this.tabDoctors.Controls.Add(this.txtDocAddress);
            this.tabDoctors.Controls.Add(this.btnUpdateDoctor);
            this.tabDoctors.Controls.Add(this.cmbDocGender);
            this.tabDoctors.Controls.Add(this.cmbDocDeptID);
            this.tabDoctors.Controls.Add(this.txtDocLastName);
            this.tabDoctors.Controls.Add(this.txtDocFirstName);
            this.tabDoctors.Controls.Add(this.panel2);
            this.tabDoctors.Location = new System.Drawing.Point(4, 44);
            this.tabDoctors.Name = "tabDoctors";
            this.tabDoctors.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoctors.Size = new System.Drawing.Size(1065, 637);
            this.tabDoctors.TabIndex = 0;
            this.tabDoctors.Text = "   DOCTORS   ";
            this.tabDoctors.UseVisualStyleBackColor = true;
            // 
            // lblDocIdlabel
            // 
            this.lblDocIdlabel.AutoSize = true;
            this.lblDocIdlabel.BackColor = System.Drawing.Color.Transparent;
            this.lblDocIdlabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDocIdlabel.Location = new System.Drawing.Point(688, 28);
            this.lblDocIdlabel.Name = "lblDocIdlabel";
            this.lblDocIdlabel.Size = new System.Drawing.Size(33, 24);
            this.lblDocIdlabel.TabIndex = 61;
            this.lblDocIdlabel.Text = "ID:";
            // 
            // lblDocID
            // 
            this.lblDocID.AutoSize = true;
            this.lblDocID.BackColor = System.Drawing.Color.Transparent;
            this.lblDocID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDocID.Location = new System.Drawing.Point(727, 28);
            this.lblDocID.Name = "lblDocID";
            this.lblDocID.Size = new System.Drawing.Size(60, 24);
            this.lblDocID.TabIndex = 60;
            this.lblDocID.Text = "None";
            // 
            // lblDocDepartmentID2
            // 
            this.lblDocDepartmentID2.AutoSize = true;
            this.lblDocDepartmentID2.BackColor = System.Drawing.Color.Transparent;
            this.lblDocDepartmentID2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocDepartmentID2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDocDepartmentID2.Location = new System.Drawing.Point(324, 529);
            this.lblDocDepartmentID2.Name = "lblDocDepartmentID2";
            this.lblDocDepartmentID2.Size = new System.Drawing.Size(104, 18);
            this.lblDocDepartmentID2.TabIndex = 59;
            this.lblDocDepartmentID2.Text = "DepartmentID";
            // 
            // lblDocQualification2
            // 
            this.lblDocQualification2.AutoSize = true;
            this.lblDocQualification2.BackColor = System.Drawing.Color.Transparent;
            this.lblDocQualification2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocQualification2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDocQualification2.Location = new System.Drawing.Point(324, 456);
            this.lblDocQualification2.Name = "lblDocQualification2";
            this.lblDocQualification2.Size = new System.Drawing.Size(95, 18);
            this.lblDocQualification2.TabIndex = 58;
            this.lblDocQualification2.Text = "Qualification";
            // 
            // lblDocPhoneNumber2
            // 
            this.lblDocPhoneNumber2.AutoSize = true;
            this.lblDocPhoneNumber2.BackColor = System.Drawing.Color.Transparent;
            this.lblDocPhoneNumber2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocPhoneNumber2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDocPhoneNumber2.Location = new System.Drawing.Point(323, 386);
            this.lblDocPhoneNumber2.Name = "lblDocPhoneNumber2";
            this.lblDocPhoneNumber2.Size = new System.Drawing.Size(110, 18);
            this.lblDocPhoneNumber2.TabIndex = 57;
            this.lblDocPhoneNumber2.Text = "Phone Number";
            // 
            // lblDocAddress2
            // 
            this.lblDocAddress2.AutoSize = true;
            this.lblDocAddress2.BackColor = System.Drawing.Color.Transparent;
            this.lblDocAddress2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocAddress2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDocAddress2.Location = new System.Drawing.Point(324, 268);
            this.lblDocAddress2.Name = "lblDocAddress2";
            this.lblDocAddress2.Size = new System.Drawing.Size(61, 18);
            this.lblDocAddress2.TabIndex = 56;
            this.lblDocAddress2.Text = "Address";
            // 
            // lblDocGender2
            // 
            this.lblDocGender2.AutoSize = true;
            this.lblDocGender2.BackColor = System.Drawing.Color.Transparent;
            this.lblDocGender2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocGender2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDocGender2.Location = new System.Drawing.Point(323, 202);
            this.lblDocGender2.Name = "lblDocGender2";
            this.lblDocGender2.Size = new System.Drawing.Size(57, 18);
            this.lblDocGender2.TabIndex = 55;
            this.lblDocGender2.Text = "Gender";
            // 
            // lblDocLastName2
            // 
            this.lblDocLastName2.AutoSize = true;
            this.lblDocLastName2.BackColor = System.Drawing.Color.Transparent;
            this.lblDocLastName2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocLastName2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDocLastName2.Location = new System.Drawing.Point(323, 136);
            this.lblDocLastName2.Name = "lblDocLastName2";
            this.lblDocLastName2.Size = new System.Drawing.Size(78, 18);
            this.lblDocLastName2.TabIndex = 54;
            this.lblDocLastName2.Text = "Last Name";
            // 
            // lblDocFirstName2
            // 
            this.lblDocFirstName2.AutoSize = true;
            this.lblDocFirstName2.BackColor = System.Drawing.Color.Transparent;
            this.lblDocFirstName2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocFirstName2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDocFirstName2.Location = new System.Drawing.Point(323, 70);
            this.lblDocFirstName2.Name = "lblDocFirstName2";
            this.lblDocFirstName2.Size = new System.Drawing.Size(79, 18);
            this.lblDocFirstName2.TabIndex = 53;
            this.lblDocFirstName2.Text = "First Name";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label19.Location = new System.Drawing.Point(322, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(137, 24);
            this.label19.TabIndex = 52;
            this.label19.Text = "Doctor Details";
            // 
            // txtDocQualification
            // 
            this.txtDocQualification.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtDocQualification.Location = new System.Drawing.Point(327, 477);
            this.txtDocQualification.Name = "txtDocQualification";
            this.txtDocQualification.Size = new System.Drawing.Size(460, 32);
            this.txtDocQualification.TabIndex = 51;
            // 
            // txtDocPhoneNo
            // 
            this.txtDocPhoneNo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtDocPhoneNo.Location = new System.Drawing.Point(327, 407);
            this.txtDocPhoneNo.Name = "txtDocPhoneNo";
            this.txtDocPhoneNo.Size = new System.Drawing.Size(460, 32);
            this.txtDocPhoneNo.TabIndex = 50;
            // 
            // txtDocAddress
            // 
            this.txtDocAddress.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtDocAddress.Location = new System.Drawing.Point(326, 289);
            this.txtDocAddress.Multiline = true;
            this.txtDocAddress.Name = "txtDocAddress";
            this.txtDocAddress.Size = new System.Drawing.Size(460, 83);
            this.txtDocAddress.TabIndex = 49;
            // 
            // btnUpdateDoctor
            // 
            this.btnUpdateDoctor.Enabled = false;
            this.btnUpdateDoctor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdateDoctor.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnUpdateDoctor.Location = new System.Drawing.Point(655, 550);
            this.btnUpdateDoctor.Name = "btnUpdateDoctor";
            this.btnUpdateDoctor.Size = new System.Drawing.Size(131, 46);
            this.btnUpdateDoctor.TabIndex = 44;
            this.btnUpdateDoctor.Text = "SUBMIT";
            this.btnUpdateDoctor.UseVisualStyleBackColor = true;
            this.btnUpdateDoctor.Visible = false;
            this.btnUpdateDoctor.Click += new System.EventHandler(this.btnUpdateDoctor_Click);
            // 
            // cmbDocGender
            // 
            this.cmbDocGender.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbDocGender.FormattingEnabled = true;
            this.cmbDocGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbDocGender.Location = new System.Drawing.Point(326, 223);
            this.cmbDocGender.Name = "cmbDocGender";
            this.cmbDocGender.Size = new System.Drawing.Size(214, 32);
            this.cmbDocGender.TabIndex = 48;
            this.cmbDocGender.Text = " Select...";
            // 
            // cmbDocDeptID
            // 
            this.cmbDocDeptID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbDocDeptID.FormattingEnabled = true;
            this.cmbDocDeptID.Location = new System.Drawing.Point(327, 550);
            this.cmbDocDeptID.Name = "cmbDocDeptID";
            this.cmbDocDeptID.Size = new System.Drawing.Size(214, 32);
            this.cmbDocDeptID.TabIndex = 45;
            this.cmbDocDeptID.Text = " Select...";
            // 
            // txtDocLastName
            // 
            this.txtDocLastName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtDocLastName.Location = new System.Drawing.Point(326, 157);
            this.txtDocLastName.Name = "txtDocLastName";
            this.txtDocLastName.Size = new System.Drawing.Size(460, 32);
            this.txtDocLastName.TabIndex = 47;
            // 
            // txtDocFirstName
            // 
            this.txtDocFirstName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtDocFirstName.Location = new System.Drawing.Point(326, 91);
            this.txtDocFirstName.Name = "txtDocFirstName";
            this.txtDocFirstName.Size = new System.Drawing.Size(460, 32);
            this.txtDocFirstName.TabIndex = 46;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(149)))), ((int)(((byte)(193)))));
            this.panel2.Controls.Add(this.lblSearchDocCriteria);
            this.panel2.Controls.Add(this.cmbSearchCriteria);
            this.panel2.Controls.Add(this.lblSearchDoc1);
            this.panel2.Controls.Add(this.txtSearchDoc1);
            this.panel2.Controls.Add(this.btnSearchDoc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 631);
            this.panel2.TabIndex = 1;
            // 
            // lblSearchDocCriteria
            // 
            this.lblSearchDocCriteria.AutoSize = true;
            this.lblSearchDocCriteria.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchDocCriteria.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchDocCriteria.ForeColor = System.Drawing.Color.White;
            this.lblSearchDocCriteria.Location = new System.Drawing.Point(20, 43);
            this.lblSearchDocCriteria.Name = "lblSearchDocCriteria";
            this.lblSearchDocCriteria.Size = new System.Drawing.Size(199, 24);
            this.lblSearchDocCriteria.TabIndex = 21;
            this.lblSearchDocCriteria.Text = "Select Search Criteria";
            // 
            // cmbSearchCriteria
            // 
            this.cmbSearchCriteria.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbSearchCriteria.FormattingEnabled = true;
            this.cmbSearchCriteria.Items.AddRange(new object[] {
            "ID",
            "Surname"});
            this.cmbSearchCriteria.Location = new System.Drawing.Point(45, 102);
            this.cmbSearchCriteria.Name = "cmbSearchCriteria";
            this.cmbSearchCriteria.Size = new System.Drawing.Size(166, 32);
            this.cmbSearchCriteria.TabIndex = 20;
            this.cmbSearchCriteria.Text = " Select...";
            // 
            // lblSearchDoc1
            // 
            this.lblSearchDoc1.AutoSize = true;
            this.lblSearchDoc1.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchDoc1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchDoc1.ForeColor = System.Drawing.Color.Black;
            this.lblSearchDoc1.Location = new System.Drawing.Point(23, 125);
            this.lblSearchDoc1.Name = "lblSearchDoc1";
            this.lblSearchDoc1.Size = new System.Drawing.Size(0, 18);
            this.lblSearchDoc1.TabIndex = 20;
            // 
            // txtSearchDoc1
            // 
            this.txtSearchDoc1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtSearchDoc1.Location = new System.Drawing.Point(45, 171);
            this.txtSearchDoc1.Name = "txtSearchDoc1";
            this.txtSearchDoc1.Size = new System.Drawing.Size(166, 32);
            this.txtSearchDoc1.TabIndex = 20;
            // 
            // btnSearchDoc
            // 
            this.btnSearchDoc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearchDoc.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSearchDoc.Location = new System.Drawing.Point(62, 238);
            this.btnSearchDoc.Name = "btnSearchDoc";
            this.btnSearchDoc.Size = new System.Drawing.Size(131, 46);
            this.btnSearchDoc.TabIndex = 20;
            this.btnSearchDoc.Text = "SEARCH";
            this.btnSearchDoc.UseVisualStyleBackColor = true;
            this.btnSearchDoc.Click += new System.EventHandler(this.btnSearchDoc_Click);
            // 
            // btnDocReport
            // 
            this.btnDocReport.Enabled = false;
            this.btnDocReport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDocReport.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnDocReport.Location = new System.Drawing.Point(902, 550);
            this.btnDocReport.Name = "btnDocReport";
            this.btnDocReport.Size = new System.Drawing.Size(131, 46);
            this.btnDocReport.TabIndex = 62;
            this.btnDocReport.Text = "REPORT";
            this.btnDocReport.UseVisualStyleBackColor = true;
            this.btnDocReport.Visible = false;
            this.btnDocReport.Click += new System.EventHandler(this.btnDocReport_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // DoctorsDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 685);
            this.Controls.Add(this.tabControl1);
            this.Name = "DoctorsDashboard";
            this.Text = "DoctorsDashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoctorsDashboard_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabDoctors.ResumeLayout(false);
            this.tabDoctors.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDoctors;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSearchDocCriteria;
        public System.Windows.Forms.ComboBox cmbSearchCriteria;
        private System.Windows.Forms.Label lblSearchDoc1;
        private System.Windows.Forms.TextBox txtSearchDoc1;
        private System.Windows.Forms.Button btnSearchDoc;
        private System.Windows.Forms.Label lblDocIdlabel;
        private System.Windows.Forms.Label lblDocID;
        private System.Windows.Forms.Label lblDocDepartmentID2;
        private System.Windows.Forms.Label lblDocQualification2;
        private System.Windows.Forms.Label lblDocPhoneNumber2;
        private System.Windows.Forms.Label lblDocAddress2;
        private System.Windows.Forms.Label lblDocGender2;
        private System.Windows.Forms.Label lblDocLastName2;
        private System.Windows.Forms.Label lblDocFirstName2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDocQualification;
        private System.Windows.Forms.TextBox txtDocPhoneNo;
        private System.Windows.Forms.TextBox txtDocAddress;
        private System.Windows.Forms.Button btnUpdateDoctor;
        public System.Windows.Forms.ComboBox cmbDocGender;
        public System.Windows.Forms.ComboBox cmbDocDeptID;
        private System.Windows.Forms.TextBox txtDocLastName;
        private System.Windows.Forms.TextBox txtDocFirstName;
        private System.Windows.Forms.Button btnDocReport;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}