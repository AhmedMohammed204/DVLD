namespace DVLD
{
    partial class frmTestAppointment
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
            this.ctrlTests1 = new DVLD.ctrlTests();
            this.SuspendLayout();
            // 
            // ctrlTests1
            // 
            this.ctrlTests1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlTests1.Font = new System.Drawing.Font("Arial", 9F);
            this.ctrlTests1.Location = new System.Drawing.Point(10, 10);
            this.ctrlTests1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlTests1.Name = "ctrlTests1";
            this.ctrlTests1.Padding = new System.Windows.Forms.Padding(10);
            this.ctrlTests1.Size = new System.Drawing.Size(441, 485);
            this.ctrlTests1.TabIndex = 0;
            // 
            // frmTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 505);
            this.Controls.Add(this.ctrlTests1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmTestAppointment";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "frmTestAppointment";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTests ctrlTests1;
    }
}