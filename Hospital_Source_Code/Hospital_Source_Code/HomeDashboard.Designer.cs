namespace Hospital_Source_Code
{
    partial class HomeDashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPatient = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInsertPatient = new System.Windows.Forms.Button();
            this.lblAddPatients = new System.Windows.Forms.Label();
            this.lblSearchpatients = new System.Windows.Forms.Label();
            this.comboSearchPatient = new System.Windows.Forms.ComboBox();
            this.textSearchLastName = new System.Windows.Forms.TextBox();
            this.tabDoctor = new System.Windows.Forms.TabPage();
            this.tabBilling = new System.Windows.Forms.TabPage();
            this.tabBeds = new System.Windows.Forms.TabPage();
            this.btnSearchAllBillsIssued = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labHospitalName = new System.Windows.Forms.Label();
            this.labPatientName = new System.Windows.Forms.Label();
            this.labBillId = new System.Windows.Forms.Label();
            this.labDateBilledIssues = new System.Windows.Forms.Label();
            this.labPatientId = new System.Windows.Forms.Label();
            this.labRoomCharge = new System.Windows.Forms.Label();
            this.labDoctorFee = new System.Windows.Forms.Label();
            this.labNote = new System.Windows.Forms.Label();
            this.labMiscellaneous = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPatient.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabBilling.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPatient);
            this.tabControl1.Controls.Add(this.tabDoctor);
            this.tabControl1.Controls.Add(this.tabBilling);
            this.tabControl1.Controls.Add(this.tabBeds);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Enabled = false;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 587);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPatient
            // 
            this.tabPatient.Controls.Add(this.panel1);
            this.tabPatient.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPatient.Location = new System.Drawing.Point(4, 44);
            this.tabPatient.Name = "tabPatient";
            this.tabPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatient.Size = new System.Drawing.Size(791, 539);
            this.tabPatient.TabIndex = 0;
            this.tabPatient.Text = "   PATIENTS   ";
            this.tabPatient.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(149)))), ((int)(((byte)(193)))));
            this.panel1.Controls.Add(this.btnInsertPatient);
            this.panel1.Controls.Add(this.lblAddPatients);
            this.panel1.Controls.Add(this.lblSearchpatients);
            this.panel1.Controls.Add(this.comboSearchPatient);
            this.panel1.Controls.Add(this.textSearchLastName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 533);
            this.panel1.TabIndex = 0;
            // 
            // btnInsertPatient
            // 
            this.btnInsertPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.btnInsertPatient.Location = new System.Drawing.Point(62, 292);
            this.btnInsertPatient.Name = "btnInsertPatient";
            this.btnInsertPatient.Size = new System.Drawing.Size(131, 46);
            this.btnInsertPatient.TabIndex = 4;
            this.btnInsertPatient.Text = "INSERT";
            this.btnInsertPatient.UseVisualStyleBackColor = true;
            // 
            // lblAddPatients
            // 
            this.lblAddPatients.AutoSize = true;
            this.lblAddPatients.ForeColor = System.Drawing.Color.White;
            this.lblAddPatients.Location = new System.Drawing.Point(45, 241);
            this.lblAddPatients.Name = "lblAddPatients";
            this.lblAddPatients.Size = new System.Drawing.Size(168, 24);
            this.lblAddPatients.TabIndex = 3;
            this.lblAddPatients.Text = "Add new patients";
            // 
            // lblSearchpatients
            // 
            this.lblSearchpatients.AutoSize = true;
            this.lblSearchpatients.ForeColor = System.Drawing.Color.White;
            this.lblSearchpatients.Location = new System.Drawing.Point(45, 45);
            this.lblSearchpatients.Name = "lblSearchpatients";
            this.lblSearchpatients.Size = new System.Drawing.Size(152, 24);
            this.lblSearchpatients.TabIndex = 2;
            this.lblSearchpatients.Text = "Search patients:";
            // 
            // comboSearchPatient
            // 
            this.comboSearchPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.comboSearchPatient.FormattingEnabled = true;
            this.comboSearchPatient.Items.AddRange(new object[] {
            "ID",
            "Last name"});
            this.comboSearchPatient.Location = new System.Drawing.Point(45, 102);
            this.comboSearchPatient.Name = "comboSearchPatient";
            this.comboSearchPatient.Size = new System.Drawing.Size(166, 32);
            this.comboSearchPatient.TabIndex = 1;
            this.comboSearchPatient.Text = " Select...";
            // 
            // textSearchLastName
            // 
            this.textSearchLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.textSearchLastName.Location = new System.Drawing.Point(45, 171);
            this.textSearchLastName.Name = "textSearchLastName";
            this.textSearchLastName.Size = new System.Drawing.Size(166, 32);
            this.textSearchLastName.TabIndex = 0;
            this.textSearchLastName.Text = " Type...";
            // 
            // tabDoctor
            // 
            this.tabDoctor.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDoctor.Location = new System.Drawing.Point(4, 44);
            this.tabDoctor.Name = "tabDoctor";
            this.tabDoctor.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoctor.Size = new System.Drawing.Size(791, 539);
            this.tabDoctor.TabIndex = 1;
            this.tabDoctor.Text = "   DOCTORS   ";
            this.tabDoctor.UseVisualStyleBackColor = true;
            // 
            // tabBilling
            // 
            this.tabBilling.Controls.Add(this.labMiscellaneous);
            this.tabBilling.Controls.Add(this.labNote);
            this.tabBilling.Controls.Add(this.labDoctorFee);
            this.tabBilling.Controls.Add(this.labRoomCharge);
            this.tabBilling.Controls.Add(this.labPatientId);
            this.tabBilling.Controls.Add(this.labDateBilledIssues);
            this.tabBilling.Controls.Add(this.labBillId);
            this.tabBilling.Controls.Add(this.labPatientName);
            this.tabBilling.Controls.Add(this.labHospitalName);
            this.tabBilling.Controls.Add(this.button3);
            this.tabBilling.Controls.Add(this.button2);
            this.tabBilling.Controls.Add(this.btnSearchAllBillsIssued);
            this.tabBilling.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBilling.Location = new System.Drawing.Point(4, 44);
            this.tabBilling.Name = "tabBilling";
            this.tabBilling.Size = new System.Drawing.Size(791, 539);
            this.tabBilling.TabIndex = 2;
            this.tabBilling.Text = "   BILLING    ";
            this.tabBilling.UseVisualStyleBackColor = true;
            // 
            // tabBeds
            // 
            this.tabBeds.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBeds.Location = new System.Drawing.Point(4, 44);
            this.tabBeds.Name = "tabBeds";
            this.tabBeds.Size = new System.Drawing.Size(791, 539);
            this.tabBeds.TabIndex = 3;
            this.tabBeds.Text = "       BEDS      ";
            this.tabBeds.UseVisualStyleBackColor = true;
            // 
            // btnSearchAllBillsIssued
            // 
            this.btnSearchAllBillsIssued.Location = new System.Drawing.Point(555, 373);
            this.btnSearchAllBillsIssued.Name = "btnSearchAllBillsIssued";
            this.btnSearchAllBillsIssued.Size = new System.Drawing.Size(190, 32);
            this.btnSearchAllBillsIssued.TabIndex = 0;
            this.btnSearchAllBillsIssued.Text = "Search All Bills";
            this.btnSearchAllBillsIssued.UseVisualStyleBackColor = true;
            this.btnSearchAllBillsIssued.Click += new System.EventHandler(this.btnSearchAllBillsIssued_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(645, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(645, 449);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // labHospitalName
            // 
            this.labHospitalName.AutoSize = true;
            this.labHospitalName.Location = new System.Drawing.Point(137, 50);
            this.labHospitalName.Name = "labHospitalName";
            this.labHospitalName.Size = new System.Drawing.Size(64, 24);
            this.labHospitalName.TabIndex = 3;
            this.labHospitalName.Text = "label1";
            // 
            // labPatientName
            // 
            this.labPatientName.AutoSize = true;
            this.labPatientName.Location = new System.Drawing.Point(137, 94);
            this.labPatientName.Name = "labPatientName";
            this.labPatientName.Size = new System.Drawing.Size(64, 24);
            this.labPatientName.TabIndex = 4;
            this.labPatientName.Text = "label2";
            // 
            // labBillId
            // 
            this.labBillId.AutoSize = true;
            this.labBillId.Location = new System.Drawing.Point(137, 140);
            this.labBillId.Name = "labBillId";
            this.labBillId.Size = new System.Drawing.Size(64, 24);
            this.labBillId.TabIndex = 5;
            this.labBillId.Text = "label3";
            // 
            // labDateBilledIssues
            // 
            this.labDateBilledIssues.AutoSize = true;
            this.labDateBilledIssues.Location = new System.Drawing.Point(137, 186);
            this.labDateBilledIssues.Name = "labDateBilledIssues";
            this.labDateBilledIssues.Size = new System.Drawing.Size(64, 24);
            this.labDateBilledIssues.TabIndex = 6;
            this.labDateBilledIssues.Text = "label4";
            // 
            // labPatientId
            // 
            this.labPatientId.AutoSize = true;
            this.labPatientId.Location = new System.Drawing.Point(137, 232);
            this.labPatientId.Name = "labPatientId";
            this.labPatientId.Size = new System.Drawing.Size(64, 24);
            this.labPatientId.TabIndex = 7;
            this.labPatientId.Text = "label5";
            // 
            // labRoomCharge
            // 
            this.labRoomCharge.AutoSize = true;
            this.labRoomCharge.Location = new System.Drawing.Point(137, 281);
            this.labRoomCharge.Name = "labRoomCharge";
            this.labRoomCharge.Size = new System.Drawing.Size(64, 24);
            this.labRoomCharge.TabIndex = 8;
            this.labRoomCharge.Text = "label5";
            // 
            // labDoctorFee
            // 
            this.labDoctorFee.AutoSize = true;
            this.labDoctorFee.Location = new System.Drawing.Point(137, 329);
            this.labDoctorFee.Name = "labDoctorFee";
            this.labDoctorFee.Size = new System.Drawing.Size(64, 24);
            this.labDoctorFee.TabIndex = 9;
            this.labDoctorFee.Text = "label5";
            // 
            // labNote
            // 
            this.labNote.AutoSize = true;
            this.labNote.Location = new System.Drawing.Point(137, 381);
            this.labNote.Name = "labNote";
            this.labNote.Size = new System.Drawing.Size(64, 24);
            this.labNote.TabIndex = 10;
            this.labNote.Text = "label5";
            // 
            // labMiscellaneous
            // 
            this.labMiscellaneous.AutoSize = true;
            this.labMiscellaneous.Location = new System.Drawing.Point(137, 437);
            this.labMiscellaneous.Name = "labMiscellaneous";
            this.labMiscellaneous.Size = new System.Drawing.Size(64, 24);
            this.labMiscellaneous.TabIndex = 11;
            this.labMiscellaneous.Text = "label5";
            // 
            // HomeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 587);
            this.Controls.Add(this.tabControl1);
            this.Name = "HomeDashboard";
            this.Text = "HomeDashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeDashboard_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPatient.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabBilling.ResumeLayout(false);
            this.tabBilling.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPatient;
        private System.Windows.Forms.TabPage tabDoctor;
        private System.Windows.Forms.TabPage tabBilling;
        private System.Windows.Forms.TabPage tabBeds;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textSearchLastName;
        public System.Windows.Forms.ComboBox comboSearchPatient;
        private System.Windows.Forms.Button btnInsertPatient;
        private System.Windows.Forms.Label lblAddPatients;
        private System.Windows.Forms.Label lblSearchpatients;
        private System.Windows.Forms.Label labMiscellaneous;
        private System.Windows.Forms.Label labNote;
        private System.Windows.Forms.Label labDoctorFee;
        private System.Windows.Forms.Label labRoomCharge;
        private System.Windows.Forms.Label labPatientId;
        private System.Windows.Forms.Label labDateBilledIssues;
        private System.Windows.Forms.Label labBillId;
        private System.Windows.Forms.Label labPatientName;
        private System.Windows.Forms.Label labHospitalName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSearchAllBillsIssued;
    }
}