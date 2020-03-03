namespace Hospital_Source_Code
{
    partial class AddBill
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
            this.labName = new System.Windows.Forms.Label();
            this.labPatientId = new System.Windows.Forms.Label();
            this.labRoomCharge = new System.Windows.Forms.Label();
            this.labNote = new System.Windows.Forms.Label();
            this.txtDoctorFee = new System.Windows.Forms.TextBox();
            this.labDoctorFee = new System.Windows.Forms.Label();
            this.txtMiscellFee = new System.Windows.Forms.TextBox();
            this.LabMiscelFee = new System.Windows.Forms.Label();
            this.bntAddBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(93, 170);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(35, 13);
            this.labName.TabIndex = 0;
            this.labName.Text = "label1";
            // 
            // labPatientId
            // 
            this.labPatientId.AutoSize = true;
            this.labPatientId.Location = new System.Drawing.Point(93, 212);
            this.labPatientId.Name = "labPatientId";
            this.labPatientId.Size = new System.Drawing.Size(35, 13);
            this.labPatientId.TabIndex = 1;
            this.labPatientId.Text = "label2";
            // 
            // labRoomCharge
            // 
            this.labRoomCharge.AutoSize = true;
            this.labRoomCharge.Location = new System.Drawing.Point(93, 252);
            this.labRoomCharge.Name = "labRoomCharge";
            this.labRoomCharge.Size = new System.Drawing.Size(35, 13);
            this.labRoomCharge.TabIndex = 2;
            this.labRoomCharge.Text = "label2";
            // 
            // labNote
            // 
            this.labNote.AutoSize = true;
            this.labNote.Location = new System.Drawing.Point(93, 392);
            this.labNote.Name = "labNote";
            this.labNote.Size = new System.Drawing.Size(35, 13);
            this.labNote.TabIndex = 3;
            this.labNote.Text = "label2";
            // 
            // txtDoctorFee
            // 
            this.txtDoctorFee.Location = new System.Drawing.Point(224, 291);
            this.txtDoctorFee.Name = "txtDoctorFee";
            this.txtDoctorFee.Size = new System.Drawing.Size(100, 20);
            this.txtDoctorFee.TabIndex = 4;
            this.txtDoctorFee.Text = "0.00";
            // 
            // labDoctorFee
            // 
            this.labDoctorFee.AutoSize = true;
            this.labDoctorFee.Location = new System.Drawing.Point(93, 294);
            this.labDoctorFee.Name = "labDoctorFee";
            this.labDoctorFee.Size = new System.Drawing.Size(68, 13);
            this.labDoctorFee.TabIndex = 5;
            this.labDoctorFee.Text = "Doctor Fees:";
            // 
            // txtMiscellFee
            // 
            this.txtMiscellFee.Location = new System.Drawing.Point(224, 332);
            this.txtMiscellFee.Name = "txtMiscellFee";
            this.txtMiscellFee.Size = new System.Drawing.Size(100, 20);
            this.txtMiscellFee.TabIndex = 6;
            this.txtMiscellFee.Text = "0.00";
            // 
            // LabMiscelFee
            // 
            this.LabMiscelFee.AutoSize = true;
            this.LabMiscelFee.Location = new System.Drawing.Point(93, 335);
            this.LabMiscelFee.Name = "LabMiscelFee";
            this.LabMiscelFee.Size = new System.Drawing.Size(103, 13);
            this.LabMiscelFee.TabIndex = 7;
            this.LabMiscelFee.Text = "Miscellaneous Fees:";
            // 
            // bntAddBill
            // 
            this.bntAddBill.Location = new System.Drawing.Point(571, 490);
            this.bntAddBill.Name = "bntAddBill";
            this.bntAddBill.Size = new System.Drawing.Size(92, 31);
            this.bntAddBill.TabIndex = 8;
            this.bntAddBill.Text = "Generate Bill";
            this.bntAddBill.UseVisualStyleBackColor = true;
            this.bntAddBill.Click += new System.EventHandler(this.bntAddBill_Click);
            // 
            // AddBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 562);
            this.Controls.Add(this.bntAddBill);
            this.Controls.Add(this.LabMiscelFee);
            this.Controls.Add(this.txtMiscellFee);
            this.Controls.Add(this.labDoctorFee);
            this.Controls.Add(this.txtDoctorFee);
            this.Controls.Add(this.labNote);
            this.Controls.Add(this.labRoomCharge);
            this.Controls.Add(this.labPatientId);
            this.Controls.Add(this.labName);
            this.Name = "AddBill";
            this.Text = "AddBill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labPatientId;
        private System.Windows.Forms.Label labRoomCharge;
        private System.Windows.Forms.Label labNote;
        private System.Windows.Forms.TextBox txtDoctorFee;
        private System.Windows.Forms.Label labDoctorFee;
        private System.Windows.Forms.TextBox txtMiscellFee;
        private System.Windows.Forms.Label LabMiscelFee;
        private System.Windows.Forms.Button bntAddBill;
    }
}