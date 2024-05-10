namespace DVLD
{
    partial class frmLogin
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
            this.panelClose = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelLoginButtonAndRememberMe = new System.Windows.Forms.Panel();
            this.cbRememberMe = new System.Windows.Forms.CheckBox();
            this.ctrlBtnLogin = new DVLD.ctrlButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelGap = new System.Windows.Forms.Panel();
            this.panelUsernameBox = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelClose.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panelLoginButtonAndRememberMe.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelUsernameBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelClose
            // 
            this.panelClose.Controls.Add(this.btnClose);
            this.panelClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClose.Location = new System.Drawing.Point(0, 0);
            this.panelClose.Margin = new System.Windows.Forms.Padding(4);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(837, 40);
            this.panelClose.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(770, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelLoginButtonAndRememberMe);
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Controls.Add(this.panelGap);
            this.panelContainer.Controls.Add(this.panelUsernameBox);
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.panelPicture);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 40);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(837, 460);
            this.panelContainer.TabIndex = 1;
            // 
            // panelLoginButtonAndRememberMe
            // 
            this.panelLoginButtonAndRememberMe.Controls.Add(this.cbRememberMe);
            this.panelLoginButtonAndRememberMe.Controls.Add(this.ctrlBtnLogin);
            this.panelLoginButtonAndRememberMe.Controls.Add(this.panel2);
            this.panelLoginButtonAndRememberMe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLoginButtonAndRememberMe.Location = new System.Drawing.Point(432, 158);
            this.panelLoginButtonAndRememberMe.Name = "panelLoginButtonAndRememberMe";
            this.panelLoginButtonAndRememberMe.Padding = new System.Windows.Forms.Padding(30, 0, 20, 0);
            this.panelLoginButtonAndRememberMe.Size = new System.Drawing.Size(405, 94);
            this.panelLoginButtonAndRememberMe.TabIndex = 6;
            // 
            // cbRememberMe
            // 
            this.cbRememberMe.AutoSize = true;
            this.cbRememberMe.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbRememberMe.Location = new System.Drawing.Point(30, 47);
            this.cbRememberMe.Name = "cbRememberMe";
            this.cbRememberMe.Size = new System.Drawing.Size(111, 47);
            this.cbRememberMe.TabIndex = 3;
            this.cbRememberMe.Text = "Remember me";
            this.cbRememberMe.UseVisualStyleBackColor = true;
            // 
            // ctrlBtnLogin
            // 
            this.ctrlBtnLogin.btnTxt = "????";
            this.ctrlBtnLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.ctrlBtnLogin.Location = new System.Drawing.Point(208, 47);
            this.ctrlBtnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlBtnLogin.MinimumSize = new System.Drawing.Size(145, 37);
            this.ctrlBtnLogin.Name = "ctrlBtnLogin";
            this.ctrlBtnLogin.Size = new System.Drawing.Size(177, 47);
            this.ctrlBtnLogin.TabIndex = 2;
            this.ctrlBtnLogin.OnButtonClick += new System.Action<System.Windows.Forms.Button>(this.ctrlBtnLogin_OnButtonClick);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(30, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 47);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(432, 140);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.panel1.Size = new System.Drawing.Size(405, 18);
            this.panel1.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Location = new System.Drawing.Point(183, 0);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(207, 15);
            this.txtPassword.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::DVLD.Properties.Resources.password;
            this.pictureBox2.Location = new System.Drawing.Point(118, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelGap
            // 
            this.panelGap.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGap.Location = new System.Drawing.Point(432, 118);
            this.panelGap.Name = "panelGap";
            this.panelGap.Size = new System.Drawing.Size(405, 22);
            this.panelGap.TabIndex = 3;
            // 
            // panelUsernameBox
            // 
            this.panelUsernameBox.Controls.Add(this.txtUsername);
            this.panelUsernameBox.Controls.Add(this.pictureBox1);
            this.panelUsernameBox.Controls.Add(this.label2);
            this.panelUsernameBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsernameBox.Location = new System.Drawing.Point(432, 100);
            this.panelUsernameBox.Name = "panelUsernameBox";
            this.panelUsernameBox.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.panelUsernameBox.Size = new System.Drawing.Size(405, 18);
            this.panelUsernameBox.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Location = new System.Drawing.Point(183, 0);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(207, 15);
            this.txtUsername.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Person;
            this.pictureBox1.Location = new System.Drawing.Point(118, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login to your account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPicture
            // 
            this.panelPicture.Controls.Add(this.pbLogo);
            this.panelPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPicture.Location = new System.Drawing.Point(0, 0);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(432, 460);
            this.panelPicture.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::DVLD.Properties.Resources.DVLD_Logo;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(432, 460);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 500);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelClose);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panelClose.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panelLoginButtonAndRememberMe.ResumeLayout(false);
            this.panelLoginButtonAndRememberMe.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelUsernameBox.ResumeLayout(false);
            this.panelUsernameBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panelUsernameBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelGap;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelLoginButtonAndRememberMe;
        private System.Windows.Forms.TextBox txtPassword;
        private ctrlButton ctrlBtnLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbRememberMe;
    }
}