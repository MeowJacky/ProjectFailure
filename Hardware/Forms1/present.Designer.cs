namespace Forms1
{
    partial class present
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
            this.here = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // here
            // 
            this.here.AutoSize = true;
            this.here.Location = new System.Drawing.Point(78, 50);
            this.here.Name = "here";
            this.here.Size = new System.Drawing.Size(239, 17);
            this.here.TabIndex = 0;
            this.here.Text = "if you see this something went wrong";
            this.here.Click += new System.EventHandler(this.here_Click);
            // 
            // present
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 482);
            this.Controls.Add(this.here);
            this.Name = "present";
            this.Text = "present";
            this.Load += new System.EventHandler(this.present_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label here;
    }
}