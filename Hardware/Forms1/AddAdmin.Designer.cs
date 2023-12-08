namespace Forms1
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
            ((System.ComponentModel.ISupportInitialize)(this.AuthoritySelect)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(50, 90);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(55, 20);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NRIC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Authority:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "RFID:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(130, 87);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(153, 26);
            this.tbname.TabIndex = 6;
            // 
            // tbNRIC
            // 
            this.tbNRIC.Location = new System.Drawing.Point(130, 137);
            this.tbNRIC.Name = "tbNRIC";
            this.tbNRIC.Size = new System.Drawing.Size(153, 26);
            this.tbNRIC.TabIndex = 7;
            // 
            // tbcontact
            // 
            this.tbcontact.Location = new System.Drawing.Point(130, 182);
            this.tbcontact.Name = "tbcontact";
            this.tbcontact.Size = new System.Drawing.Size(153, 26);
            this.tbcontact.TabIndex = 8;
            // 
            // tbadd
            // 
            this.tbadd.Location = new System.Drawing.Point(132, 222);
            this.tbadd.Name = "tbadd";
            this.tbadd.Size = new System.Drawing.Size(277, 26);
            this.tbadd.TabIndex = 9;
            // 
            // tbRFID
            // 
            this.tbRFID.Location = new System.Drawing.Point(132, 311);
            this.tbRFID.Name = "tbRFID";
            this.tbRFID.Size = new System.Drawing.Size(208, 26);
            this.tbRFID.TabIndex = 11;
            // 
            // AuthoritySelect
            // 
            this.AuthoritySelect.Location = new System.Drawing.Point(132, 264);
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
            this.btnAddAdmin.Location = new System.Drawing.Point(169, 373);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(240, 41);
            this.btnAddAdmin.TabIndex = 13;
            this.btnAddAdmin.Text = "Add Admin";
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            this.btnAddAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(44, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 41);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Add New Admin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(468, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddAdmin);
            this.Controls.Add(this.AuthoritySelect);
            this.Controls.Add(this.tbRFID);
            this.Controls.Add(this.tbadd);
            this.Controls.Add(this.tbcontact);
            this.Controls.Add(this.tbNRIC);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblname);
            this.Name = "AddAdmin";
            this.Text = "AddAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.AuthoritySelect)).EndInit();
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
    }
}