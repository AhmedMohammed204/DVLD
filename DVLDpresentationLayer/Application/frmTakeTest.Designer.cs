namespace DVLD
{
    partial class frmTakeTest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.rbFaild = new System.Windows.Forms.RadioButton();
            this.rbPass = new System.Windows.Forms.RadioButton();
            this.ctrlTests1 = new DVLD.ctrlTests();
            this.btnSave = new DVLD.ctrlButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.rbFaild);
            this.groupBox1.Controls.Add(this.rbPass);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(479, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(303, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtNotes.Location = new System.Drawing.Point(5, 102);
            this.txtNotes.MaxLength = 500;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(293, 123);
            this.txtNotes.TabIndex = 2;
            // 
            // rbFaild
            // 
            this.rbFaild.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbFaild.AutoSize = true;
            this.rbFaild.Location = new System.Drawing.Point(229, 35);
            this.rbFaild.Name = "rbFaild";
            this.rbFaild.Size = new System.Drawing.Size(51, 19);
            this.rbFaild.TabIndex = 1;
            this.rbFaild.TabStop = true;
            this.rbFaild.Text = "Faild";
            this.rbFaild.UseVisualStyleBackColor = true;
            // 
            // rbPass
            // 
            this.rbPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbPass.AutoSize = true;
            this.rbPass.Location = new System.Drawing.Point(26, 35);
            this.rbPass.Name = "rbPass";
            this.rbPass.Size = new System.Drawing.Size(54, 19);
            this.rbPass.TabIndex = 0;
            this.rbPass.TabStop = true;
            this.rbPass.Text = "Pass";
            this.rbPass.UseVisualStyleBackColor = true;
            // 
            // ctrlTests1
            // 
            this.ctrlTests1.Font = new System.Drawing.Font("Arial", 9F);
            this.ctrlTests1.Location = new System.Drawing.Point(13, 12);
            this.ctrlTests1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlTests1.Name = "ctrlTests1";
            this.ctrlTests1.Padding = new System.Windows.Forms.Padding(10);
            this.ctrlTests1.Size = new System.Drawing.Size(459, 453);
            this.ctrlTests1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.btnTxt = "????";
            this.btnSave.Location = new System.Drawing.Point(490, 389);
            this.btnSave.MinimumSize = new System.Drawing.Size(124, 32);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(287, 59);
            this.btnSave.TabIndex = 2;
            this.btnSave.OnButtonClick += new System.Action<System.Windows.Forms.Button>(this.btnSave_OnButtonClick);
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 493);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlTests1);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTakeTest";
            this.Text = "Take Test";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTests ctrlTests1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFaild;
        private System.Windows.Forms.RadioButton rbPass;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label1;
        private ctrlButton btnSave;
    }
}