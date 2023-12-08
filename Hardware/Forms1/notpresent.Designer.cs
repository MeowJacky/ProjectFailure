namespace Forms1
{
    partial class notpresent
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
            this.nothere = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nothere
            // 
            this.nothere.AutoSize = true;
            this.nothere.Location = new System.Drawing.Point(158, 55);
            this.nothere.Name = "nothere";
            this.nothere.Size = new System.Drawing.Size(34, 17);
            this.nothere.TabIndex = 0;
            this.nothere.Text = "fuck";
            // 
            // notpresent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 502);
            this.Controls.Add(this.nothere);
            this.Name = "notpresent";
            this.Text = "notpresent";
            this.Load += new System.EventHandler(this.notpresent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nothere;
    }
}