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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.clockin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AUsername = new System.Windows.Forms.Label();
            this.editclockin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clockin)).BeginInit();
            this.SuspendLayout();
            // 
            // clockin
            // 
            chartArea1.Name = "ChartArea1";
            this.clockin.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.clockin.Legends.Add(legend1);
            this.clockin.Location = new System.Drawing.Point(219, 110);
            this.clockin.Name = "clockin";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.clockin.Series.Add(series1);
            this.clockin.Size = new System.Drawing.Size(732, 327);
            this.clockin.TabIndex = 0;
            this.clockin.Text = "clockin";
            // 
            // AUsername
            // 
            this.AUsername.AutoSize = true;
            this.AUsername.Location = new System.Drawing.Point(51, 74);
            this.AUsername.Name = "AUsername";
            this.AUsername.Size = new System.Drawing.Size(109, 17);
            this.AUsername.TabIndex = 1;
            this.AUsername.Text = "adminusername";
            // 
            // editclockin
            // 
            this.editclockin.Location = new System.Drawing.Point(822, 454);
            this.editclockin.Name = "editclockin";
            this.editclockin.Size = new System.Drawing.Size(129, 23);
            this.editclockin.TabIndex = 2;
            this.editclockin.Text = "Edit Clocked In";
            this.editclockin.UseVisualStyleBackColor = true;
            this.editclockin.Click += new System.EventHandler(this.editclockin_Click);
            // 
            // Admin
            // 
            this.ClientSize = new System.Drawing.Size(1141, 527);
            this.Controls.Add(this.editclockin);
            this.Controls.Add(this.AUsername);
            this.Controls.Add(this.clockin);
            this.Name = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.clockin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label adminusername;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart clockin;
        private System.Windows.Forms.Label AUsername;
        private System.Windows.Forms.Button editclockin;
    }
}