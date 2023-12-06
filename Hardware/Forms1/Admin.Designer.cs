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
            this.adminusername = new System.Windows.Forms.Label();
            this.ClockedIn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ClockedIn)).BeginInit();
            this.SuspendLayout();
            // 
            // adminusername
            // 
            this.adminusername.AutoSize = true;
            this.adminusername.ForeColor = System.Drawing.Color.White;
            this.adminusername.Location = new System.Drawing.Point(918, 35);
            this.adminusername.Name = "adminusername";
            this.adminusername.Size = new System.Drawing.Size(38, 17);
            this.adminusername.TabIndex = 1;
            this.adminusername.Text = " bnjv";
            this.adminusername.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClockedIn
            // 
            chartArea1.Name = "ChartArea1";
            this.ClockedIn.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ClockedIn.Legends.Add(legend1);
            this.ClockedIn.Location = new System.Drawing.Point(251, 12);
            this.ClockedIn.Name = "ClockedIn";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ClockedIn.Series.Add(series1);
            this.ClockedIn.Size = new System.Drawing.Size(300, 560);
            this.ClockedIn.TabIndex = 2;
            this.ClockedIn.Text = "chart1";
            this.ClockedIn.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1031, 643);
            this.Controls.Add(this.ClockedIn);
            this.Controls.Add(this.adminusername);
            this.Name = "Admin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClockedIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label adminusername;
        private System.Windows.Forms.DataVisualization.Charting.Chart ClockedIn;
    }
}