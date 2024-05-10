namespace DVLD
{
    partial class frmReplacementLicense
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
            this.gbReplcementFor = new System.Windows.Forms.GroupBox();
            this.rbLostLicense = new System.Windows.Forms.RadioButton();
            this.rbDamagedLicense = new System.Windows.Forms.RadioButton();
            this.llblShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.llblShowPersonLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.gbApplicationInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblOldLicenceID = new System.Windows.Forms.Label();
            this.lblReplecedLicenceID = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblLRApplication = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIssue = new DVLD.ctrlButton();
            this.ctrlLicenseInfoWithFilter1 = new DVLD.ctrlLicenseInfoWithFilter();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gbReplcementFor.SuspendLayout();
            this.gbApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbReplcementFor
            // 
            this.gbReplcementFor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbReplcementFor.Controls.Add(this.rbLostLicense);
            this.gbReplcementFor.Controls.Add(this.rbDamagedLicense);
            this.gbReplcementFor.Location = new System.Drawing.Point(1098, 92);
            this.gbReplcementFor.Name = "gbReplcementFor";
            this.gbReplcementFor.Size = new System.Drawing.Size(140, 73);
            this.gbReplcementFor.TabIndex = 2;
            this.gbReplcementFor.TabStop = false;
            this.gbReplcementFor.Text = "Replcement for";
            // 
            // rbLostLicense
            // 
            this.rbLostLicense.AutoSize = true;
            this.rbLostLicense.Location = new System.Drawing.Point(6, 51);
            this.rbLostLicense.Name = "rbLostLicense";
            this.rbLostLicense.Size = new System.Drawing.Size(85, 17);
            this.rbLostLicense.TabIndex = 1;
            this.rbLostLicense.Text = "Lost License";
            this.rbLostLicense.UseVisualStyleBackColor = true;
            this.rbLostLicense.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbDamagedLicense
            // 
            this.rbDamagedLicense.AutoSize = true;
            this.rbDamagedLicense.Checked = true;
            this.rbDamagedLicense.Location = new System.Drawing.Point(6, 28);
            this.rbDamagedLicense.Name = "rbDamagedLicense";
            this.rbDamagedLicense.Size = new System.Drawing.Size(111, 17);
            this.rbDamagedLicense.TabIndex = 0;
            this.rbDamagedLicense.TabStop = true;
            this.rbDamagedLicense.Text = "Damaged License";
            this.rbDamagedLicense.UseVisualStyleBackColor = true;
            this.rbDamagedLicense.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // llblShowNewLicenseInfo
            // 
            this.llblShowNewLicenseInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.llblShowNewLicenseInfo.AutoSize = true;
            this.llblShowNewLicenseInfo.Enabled = false;
            this.llblShowNewLicenseInfo.Location = new System.Drawing.Point(995, 527);
            this.llblShowNewLicenseInfo.Name = "llblShowNewLicenseInfo";
            this.llblShowNewLicenseInfo.Size = new System.Drawing.Size(113, 13);
            this.llblShowNewLicenseInfo.TabIndex = 4;
            this.llblShowNewLicenseInfo.TabStop = true;
            this.llblShowNewLicenseInfo.Text = "Show new license info";
            this.llblShowNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowNewLicenseInfo_LinkClicked);
            // 
            // llblShowPersonLicenseHistory
            // 
            this.llblShowPersonLicenseHistory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.llblShowPersonLicenseHistory.AutoSize = true;
            this.llblShowPersonLicenseHistory.Enabled = false;
            this.llblShowPersonLicenseHistory.Location = new System.Drawing.Point(1154, 527);
            this.llblShowPersonLicenseHistory.Name = "llblShowPersonLicenseHistory";
            this.llblShowPersonLicenseHistory.Size = new System.Drawing.Size(138, 13);
            this.llblShowPersonLicenseHistory.TabIndex = 5;
            this.llblShowPersonLicenseHistory.TabStop = true;
            this.llblShowPersonLicenseHistory.Text = "Show person license history";
            this.llblShowPersonLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowPersonLicenseHistory_LinkClicked);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(325, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(505, 51);
            this.label7.TabIndex = 6;
            this.label7.Text = "Replacement License";
            // 
            // gbApplicationInfo
            // 
            this.gbApplicationInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbApplicationInfo.Controls.Add(this.label2);
            this.gbApplicationInfo.Controls.Add(this.lblCreatedBy);
            this.gbApplicationInfo.Controls.Add(this.lblOldLicenceID);
            this.gbApplicationInfo.Controls.Add(this.lblReplecedLicenceID);
            this.gbApplicationInfo.Controls.Add(this.lblApplicationFees);
            this.gbApplicationInfo.Controls.Add(this.lblApplicationDate);
            this.gbApplicationInfo.Controls.Add(this.lblLRApplication);
            this.gbApplicationInfo.Controls.Add(this.label6);
            this.gbApplicationInfo.Controls.Add(this.label5);
            this.gbApplicationInfo.Controls.Add(this.label4);
            this.gbApplicationInfo.Controls.Add(this.label3);
            this.gbApplicationInfo.Controls.Add(this.label1);
            this.gbApplicationInfo.Location = new System.Drawing.Point(110, 502);
            this.gbApplicationInfo.Margin = new System.Windows.Forms.Padding(0);
            this.gbApplicationInfo.Name = "gbApplicationInfo";
            this.gbApplicationInfo.Padding = new System.Windows.Forms.Padding(0);
            this.gbApplicationInfo.Size = new System.Drawing.Size(885, 120);
            this.gbApplicationInfo.TabIndex = 1;
            this.gbApplicationInfo.TabStop = false;
            this.gbApplicationInfo.Text = "Replecment application info";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Application date:";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(615, 93);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(36, 13);
            this.lblCreatedBy.TabIndex = 23;
            this.lblCreatedBy.Text = "[???]";
            // 
            // lblOldLicenceID
            // 
            this.lblOldLicenceID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblOldLicenceID.AutoSize = true;
            this.lblOldLicenceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenceID.Location = new System.Drawing.Point(615, 59);
            this.lblOldLicenceID.Name = "lblOldLicenceID";
            this.lblOldLicenceID.Size = new System.Drawing.Size(36, 13);
            this.lblOldLicenceID.TabIndex = 22;
            this.lblOldLicenceID.Text = "[???]";
            // 
            // lblReplecedLicenceID
            // 
            this.lblReplecedLicenceID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReplecedLicenceID.AutoSize = true;
            this.lblReplecedLicenceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplecedLicenceID.Location = new System.Drawing.Point(615, 29);
            this.lblReplecedLicenceID.Name = "lblReplecedLicenceID";
            this.lblReplecedLicenceID.Size = new System.Drawing.Size(36, 13);
            this.lblReplecedLicenceID.TabIndex = 21;
            this.lblReplecedLicenceID.Text = "[???]";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.Location = new System.Drawing.Point(141, 93);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(36, 13);
            this.lblApplicationFees.TabIndex = 20;
            this.lblApplicationFees.Text = "[???]";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.Location = new System.Drawing.Point(141, 59);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(36, 13);
            this.lblApplicationDate.TabIndex = 19;
            this.lblApplicationDate.Text = "[???]";
            // 
            // lblLRApplication
            // 
            this.lblLRApplication.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLRApplication.AutoSize = true;
            this.lblLRApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLRApplication.Location = new System.Drawing.Point(141, 29);
            this.lblLRApplication.Name = "lblLRApplication";
            this.lblLRApplication.Size = new System.Drawing.Size(36, 13);
            this.lblLRApplication.TabIndex = 18;
            this.lblLRApplication.Text = "[???]";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(478, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Created By:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(478, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Old License ID:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Repleced Licence ID:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Application fees:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "L.R.ApplicationID:";
            // 
            // btnIssue
            // 
            this.btnIssue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIssue.btnTxt = "????";
            this.btnIssue.Enabled = false;
            this.btnIssue.Location = new System.Drawing.Point(998, 574);
            this.btnIssue.MinimumSize = new System.Drawing.Size(124, 30);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(124, 30);
            this.btnIssue.TabIndex = 3;
            this.btnIssue.OnButtonClick += new System.Action<System.Windows.Forms.Button>(this.btnIssue_OnButtonClick);
            // 
            // ctrlLicenseInfoWithFilter1
            // 
            this.ctrlLicenseInfoWithFilter1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ctrlLicenseInfoWithFilter1.Location = new System.Drawing.Point(110, 92);
            this.ctrlLicenseInfoWithFilter1.Name = "ctrlLicenseInfoWithFilter1";
            this.ctrlLicenseInfoWithFilter1.Size = new System.Drawing.Size(885, 407);
            this.ctrlLicenseInfoWithFilter1.TabIndex = 0;
            this.ctrlLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 5;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.Gray;
            this.btnBack.FillColor2 = System.Drawing.Color.Silver;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 34);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmReplacementLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 692);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.llblShowPersonLicenseHistory);
            this.Controls.Add(this.llblShowNewLicenseInfo);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.gbReplcementFor);
            this.Controls.Add(this.gbApplicationInfo);
            this.Controls.Add(this.ctrlLicenseInfoWithFilter1);
            this.Name = "frmReplacementLicense";
            this.Text = "Replacement License";
            this.Load += new System.EventHandler(this.frmReplacementLicense_Load);
            this.gbReplcementFor.ResumeLayout(false);
            this.gbReplcementFor.PerformLayout();
            this.gbApplicationInfo.ResumeLayout(false);
            this.gbApplicationInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlLicenseInfoWithFilter ctrlLicenseInfoWithFilter1;
        private System.Windows.Forms.GroupBox gbReplcementFor;
        private System.Windows.Forms.RadioButton rbLostLicense;
        private System.Windows.Forms.RadioButton rbDamagedLicense;
        private ctrlButton btnIssue;
        private System.Windows.Forms.LinkLabel llblShowNewLicenseInfo;
        private System.Windows.Forms.LinkLabel llblShowPersonLicenseHistory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbApplicationInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblOldLicenceID;
        private System.Windows.Forms.Label lblReplecedLicenceID;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblLRApplication;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
    }
}