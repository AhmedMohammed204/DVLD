namespace DVLD
{
    partial class frmAddEditUser
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctrlFindPerson2 = new DVLD.ctrlFindPerson();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlButtonClose = new DVLD.ctrlButton();
            this.ctrlButtonSave = new DVLD.ctrlButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbUserInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(10, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1281, 83);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add User";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Arial", 9.7F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(113, 138);
            this.txtConfirmPassword.MaxLength = 50;
            this.txtConfirmPassword.Multiline = true;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(133, 23);
            this.txtConfirmPassword.TabIndex = 46;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 9.7F);
            this.txtPassword.Location = new System.Drawing.Point(113, 106);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(133, 23);
            this.txtPassword.TabIndex = 45;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 9.7F);
            this.txtUsername.Location = new System.Drawing.Point(114, 74);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(132, 23);
            this.txtUsername.TabIndex = 44;
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Location = new System.Drawing.Point(24, 211);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(73, 20);
            this.cbIsActive.TabIndex = 47;
            this.cbIsActive.Text = "is active";
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 36);
            this.label2.TabIndex = 53;
            this.label2.Text = "Confirm\r\nPassword:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 18);
            this.label7.TabIndex = 52;
            this.label7.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 51;
            this.label6.Text = "Username:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.IndianRed;
            this.lblName.Location = new System.Drawing.Point(155, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 15);
            this.lblName.TabIndex = 50;
            this.lblName.Text = "??????";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.NameIcon;
            this.pictureBox1.Location = new System.Drawing.Point(114, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 48;
            this.label1.Text = "UserID:";
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Controls.Add(this.pictureBox1);
            this.gbUserInfo.Controls.Add(this.cbIsActive);
            this.gbUserInfo.Controls.Add(this.txtConfirmPassword);
            this.gbUserInfo.Controls.Add(this.label2);
            this.gbUserInfo.Controls.Add(this.label1);
            this.gbUserInfo.Controls.Add(this.label7);
            this.gbUserInfo.Controls.Add(this.txtPassword);
            this.gbUserInfo.Controls.Add(this.lblName);
            this.gbUserInfo.Controls.Add(this.txtUsername);
            this.gbUserInfo.Controls.Add(this.label6);
            this.gbUserInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbUserInfo.Enabled = false;
            this.gbUserInfo.Location = new System.Drawing.Point(982, 0);
            this.gbUserInfo.MinimumSize = new System.Drawing.Size(297, 387);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Size = new System.Drawing.Size(297, 387);
            this.gbUserInfo.TabIndex = 56;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "User info";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ctrlFindPerson2);
            this.panel1.Controls.Add(this.gbUserInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1281, 389);
            this.panel1.TabIndex = 57;
            // 
            // ctrlFindPerson2
            // 
            this.ctrlFindPerson2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ctrlFindPerson2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ctrlFindPerson2.Location = new System.Drawing.Point(0, 0);
            this.ctrlFindPerson2.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlFindPerson2.MinimumSize = new System.Drawing.Size(975, 370);
            this.ctrlFindPerson2.Name = "ctrlFindPerson2";
            this.ctrlFindPerson2.Size = new System.Drawing.Size(975, 387);
            this.ctrlFindPerson2.TabIndex = 55;
            this.ctrlFindPerson2.OnPersonFound += new System.Action<int>(this.ctrlFindPerson2_OnPersonFound);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlButtonClose
            // 
            this.ctrlButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlButtonClose.btnTxt = "????";
            this.ctrlButtonClose.Location = new System.Drawing.Point(952, 497);
            this.ctrlButtonClose.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlButtonClose.MinimumSize = new System.Drawing.Size(145, 37);
            this.ctrlButtonClose.Name = "ctrlButtonClose";
            this.ctrlButtonClose.Size = new System.Drawing.Size(145, 37);
            this.ctrlButtonClose.TabIndex = 3;
            this.ctrlButtonClose.OnButtonClick += new System.Action<System.Windows.Forms.Button>(this.ctrlButtonClose_OnButtonClick);
            // 
            // ctrlButtonSave
            // 
            this.ctrlButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlButtonSave.btnTxt = "????";
            this.ctrlButtonSave.Location = new System.Drawing.Point(1128, 497);
            this.ctrlButtonSave.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlButtonSave.MinimumSize = new System.Drawing.Size(145, 37);
            this.ctrlButtonSave.Name = "ctrlButtonSave";
            this.ctrlButtonSave.Size = new System.Drawing.Size(145, 37);
            this.ctrlButtonSave.TabIndex = 2;
            this.ctrlButtonSave.OnButtonClick += new System.Action<System.Windows.Forms.Button>(this.ctrlButtonSave_OnButtonClick);
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ctrlButtonClose);
            this.Controls.Add(this.ctrlButtonSave);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddEditUser";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 15);
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.frmAddEditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbUserInfo.ResumeLayout(false);
            this.gbUserInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private ctrlButton ctrlButtonSave;
        private ctrlButton ctrlButtonClose;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private ctrlFindPerson ctrlFindPerson2;
        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}