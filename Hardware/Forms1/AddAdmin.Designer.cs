﻿namespace Forms1
{
    partial class AddAdmin
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
            System.Windows.Forms.TabControl tabControl1;
            this.lblname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbNRIC = new System.Windows.Forms.TextBox();
            this.tbcontact = new System.Windows.Forms.TextBox();
            this.tbadd = new System.Windows.Forms.TextBox();
            this.tbRFID = new System.Windows.Forms.TextBox();
            this.AuthoritySelect = new System.Windows.Forms.NumericUpDown();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbPassword1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.tbRFID1 = new System.Windows.Forms.TextBox();
            this.tbAdd1 = new System.Windows.Forms.TextBox();
            this.tbContact1 = new System.Windows.Forms.TextBox();
            this.tbNRIC1 = new System.Windows.Forms.TextBox();
            this.tbName1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.AuthoritySelect)).BeginInit();
            tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(34, 30);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(55, 20);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NRIC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Authority:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "RFID:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(125, 27);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(153, 26);
            this.tbname.TabIndex = 6;
            // 
            // tbNRIC
            // 
            this.tbNRIC.Location = new System.Drawing.Point(125, 77);
            this.tbNRIC.Name = "tbNRIC";
            this.tbNRIC.Size = new System.Drawing.Size(153, 26);
            this.tbNRIC.TabIndex = 7;
            // 
            // tbcontact
            // 
            this.tbcontact.Location = new System.Drawing.Point(125, 122);
            this.tbcontact.Name = "tbcontact";
            this.tbcontact.Size = new System.Drawing.Size(153, 26);
            this.tbcontact.TabIndex = 8;
            // 
            // tbadd
            // 
            this.tbadd.Location = new System.Drawing.Point(125, 171);
            this.tbadd.Name = "tbadd";
            this.tbadd.Size = new System.Drawing.Size(277, 26);
            this.tbadd.TabIndex = 9;
            // 
            // tbRFID
            // 
            this.tbRFID.Location = new System.Drawing.Point(438, 71);
            this.tbRFID.Name = "tbRFID";
            this.tbRFID.Size = new System.Drawing.Size(208, 26);
            this.tbRFID.TabIndex = 11;
            // 
            // AuthoritySelect
            // 
            this.AuthoritySelect.Location = new System.Drawing.Point(438, 24);
            this.AuthoritySelect.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.AuthoritySelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AuthoritySelect.Name = "AuthoritySelect";
            this.AuthoritySelect.Size = new System.Drawing.Size(120, 26);
            this.AuthoritySelect.TabIndex = 12;
            this.AuthoritySelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.Location = new System.Drawing.Point(349, 235);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(240, 41);
            this.btnAddAdmin.TabIndex = 13;
            this.btnAddAdmin.Text = "Add User";
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            this.btnAddAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(38, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(240, 41);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Add New User";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(438, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 26);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbpassword
            // 
            this.tbpassword.AutoSize = true;
            this.tbpassword.Location = new System.Drawing.Point(345, 119);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(82, 20);
            this.tbpassword.TabIndex = 16;
            this.tbpassword.Text = "Password:";
            this.tbpassword.Click += new System.EventHandler(this.label7_Click);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(this.tabPage1);
            tabControl1.Controls.Add(this.tabPage2);
            tabControl1.Location = new System.Drawing.Point(12, 68);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(683, 343);
            tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbname);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.lblname);
            this.tabPage1.Controls.Add(this.tbpassword);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnAddAdmin);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.AuthoritySelect);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tbRFID);
            this.tabPage1.Controls.Add(this.tbNRIC);
            this.tabPage1.Controls.Add(this.tbadd);
            this.tabPage1.Controls.Add(this.tbcontact);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(675, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Admin";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbPassword1);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.btnAdd1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tbRFID1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tbAdd1);
            this.tabPage2.Controls.Add(this.tbName1);
            this.tabPage2.Controls.Add(this.tbContact1);
            this.tabPage2.Controls.Add(this.tbNRIC1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(675, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Workers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbPassword1
            // 
            this.tbPassword1.Location = new System.Drawing.Point(429, 83);
            this.tbPassword1.Name = "tbPassword1";
            this.tbPassword1.Size = new System.Drawing.Size(208, 26);
            this.tbPassword1.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Password:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 41);
            this.button1.TabIndex = 32;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAdd1
            // 
            this.btnAdd1.Location = new System.Drawing.Point(342, 240);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(240, 41);
            this.btnAdd1.TabIndex = 31;
            this.btnAdd1.Text = "Add User";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // tbRFID1
            // 
            this.tbRFID1.Location = new System.Drawing.Point(429, 35);
            this.tbRFID1.Name = "tbRFID1";
            this.tbRFID1.Size = new System.Drawing.Size(208, 26);
            this.tbRFID1.TabIndex = 29;
            // 
            // tbAdd1
            // 
            this.tbAdd1.Location = new System.Drawing.Point(118, 176);
            this.tbAdd1.Name = "tbAdd1";
            this.tbAdd1.Size = new System.Drawing.Size(277, 26);
            this.tbAdd1.TabIndex = 28;
            // 
            // tbContact1
            // 
            this.tbContact1.Location = new System.Drawing.Point(118, 127);
            this.tbContact1.Name = "tbContact1";
            this.tbContact1.Size = new System.Drawing.Size(153, 26);
            this.tbContact1.TabIndex = 27;
            // 
            // tbNRIC1
            // 
            this.tbNRIC1.Location = new System.Drawing.Point(118, 82);
            this.tbNRIC1.Name = "tbNRIC1";
            this.tbNRIC1.Size = new System.Drawing.Size(153, 26);
            this.tbNRIC1.TabIndex = 26;
            // 
            // tbName1
            // 
            this.tbName1.Location = new System.Drawing.Point(118, 32);
            this.tbName1.Name = "tbName1";
            this.tbName1.Size = new System.Drawing.Size(153, 26);
            this.tbName1.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "RFID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Address:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Contact:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "NRIC:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Name:";
            // 
            // AddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(712, 423);
            this.Controls.Add(tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "AddAdmin";
            this.Text = "AddAdmin";
            this.Load += new System.EventHandler(this.AddAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AuthoritySelect)).EndInit();
            tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbNRIC;
        private System.Windows.Forms.TextBox tbcontact;
        private System.Windows.Forms.TextBox tbadd;
        private System.Windows.Forms.TextBox tbRFID;
        private System.Windows.Forms.NumericUpDown AuthoritySelect;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tbpassword;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbPassword1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbRFID1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbAdd1;
        private System.Windows.Forms.TextBox tbName1;
        private System.Windows.Forms.TextBox tbContact1;
        private System.Windows.Forms.TextBox tbNRIC1;
    }
}