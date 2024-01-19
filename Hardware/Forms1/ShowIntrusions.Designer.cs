namespace Forms1
{
    partial class ShowIntrusions
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
            this.listBoxIntrusions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxIntrusions
            // 
            this.listBoxIntrusions.FormattingEnabled = true;
            this.listBoxIntrusions.ItemHeight = 16;
            this.listBoxIntrusions.Location = new System.Drawing.Point(-1, -1);
            this.listBoxIntrusions.Name = "listBoxIntrusions";
            this.listBoxIntrusions.Size = new System.Drawing.Size(347, 260);
            this.listBoxIntrusions.TabIndex = 0;
            this.listBoxIntrusions.SelectedIndexChanged += new System.EventHandler(this.listBoxIntrusions_SelectedIndexChanged);
            // 
            // ShowIntrusions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 260);
            this.Controls.Add(this.listBoxIntrusions);
            this.Name = "ShowIntrusions";
            this.Text = "ShowIntrusions";
            this.Load += new System.EventHandler(this.ShowIntrusions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxIntrusions;
    }
}