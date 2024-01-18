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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxIntrusions
            // 
            this.listBoxIntrusions.FormattingEnabled = true;
            this.listBoxIntrusions.ItemHeight = 16;
            this.listBoxIntrusions.Location = new System.Drawing.Point(126, 48);
            this.listBoxIntrusions.Name = "listBoxIntrusions";
            this.listBoxIntrusions.Size = new System.Drawing.Size(763, 260);
            this.listBoxIntrusions.TabIndex = 0;
            this.listBoxIntrusions.SelectedIndexChanged += new System.EventHandler(this.listBoxIntrusions_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowIntrusions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxIntrusions);
            this.Name = "ShowIntrusions";
            this.Text = "ShowIntrusions";
            this.Load += new System.EventHandler(this.ShowIntrusions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxIntrusions;
        private System.Windows.Forms.Button button1;
    }
}