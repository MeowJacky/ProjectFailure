namespace Forms1
{
    partial class Admin
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
            this.adminusername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adminusername
            // 
            this.adminusername.AutoSize = true;
            this.adminusername.Location = new System.Drawing.Point(66, 66);
            this.adminusername.Name = "adminusername";
            this.adminusername.Size = new System.Drawing.Size(0, 17);
            this.adminusername.TabIndex = 1;
            this.adminusername.Click += new System.EventHandler(this.label1_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 488);
            this.Controls.Add(this.adminusername);
            this.Name = "Admin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label adminusername;
    }
}