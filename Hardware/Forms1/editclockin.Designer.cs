namespace Forms1
{
    partial class editclockin
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Retrieve = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PhonePlaceholder = new System.Windows.Forms.Label();
            this.DepartmentPlaceholder = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Clockedin = new System.Windows.Forms.CheckBox();
            this.update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 22);
            this.textBox1.TabIndex = 1;
            // 
            // Retrieve
            // 
            this.Retrieve.Location = new System.Drawing.Point(338, 51);
            this.Retrieve.Name = "Retrieve";
            this.Retrieve.Size = new System.Drawing.Size(107, 23);
            this.Retrieve.TabIndex = 2;
            this.Retrieve.Text = "Retrieve Data";
            this.Retrieve.UseVisualStyleBackColor = true;
            this.Retrieve.Click += new System.EventHandler(this.Retrieve_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PhonePlaceholder
            // 
            this.PhonePlaceholder.AutoSize = true;
            this.PhonePlaceholder.Location = new System.Drawing.Point(142, 97);
            this.PhonePlaceholder.Name = "PhonePlaceholder";
            this.PhonePlaceholder.Size = new System.Drawing.Size(0, 17);
            this.PhonePlaceholder.TabIndex = 4;
            this.PhonePlaceholder.Click += new System.EventHandler(this.label3_Click);
            // 
            // DepartmentPlaceholder
            // 
            this.DepartmentPlaceholder.AutoEllipsis = true;
            this.DepartmentPlaceholder.AutoSize = true;
            this.DepartmentPlaceholder.Location = new System.Drawing.Point(142, 130);
            this.DepartmentPlaceholder.Name = "DepartmentPlaceholder";
            this.DepartmentPlaceholder.Size = new System.Drawing.Size(0, 17);
            this.DepartmentPlaceholder.TabIndex = 6;
            this.DepartmentPlaceholder.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Department";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Clocked In Status";
            // 
            // Clockedin
            // 
            this.Clockedin.AutoSize = true;
            this.Clockedin.Location = new System.Drawing.Point(145, 211);
            this.Clockedin.Name = "Clockedin";
            this.Clockedin.Size = new System.Drawing.Size(82, 21);
            this.Clockedin.TabIndex = 8;
            this.Clockedin.Text = "No Data";
            this.Clockedin.UseVisualStyleBackColor = true;
            this.Clockedin.CheckedChanged += new System.EventHandler(this.Clockedin_CheckedChanged);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(338, 206);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(107, 32);
            this.update.TabIndex = 9;
            this.update.Text = "Update Data";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // editclockin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 280);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Clockedin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DepartmentPlaceholder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PhonePlaceholder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Retrieve);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "editclockin";
            this.Text = "editclockin";
            this.Load += new System.EventHandler(this.editclockin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Retrieve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PhonePlaceholder;
        private System.Windows.Forms.Label DepartmentPlaceholder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Clockedin;
        private System.Windows.Forms.Button update;
    }
}