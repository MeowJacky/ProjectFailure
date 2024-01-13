namespace Forms1
{
    partial class ManageAdmin
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
            this.components = new System.ComponentModel.Container();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRFID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNRIC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAuthority = new System.Windows.Forms.TextBox();
            this.btnGetUser = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ShiftStart = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tbUserID
            // 
            this.tbUserID.Location = new System.Drawing.Point(117, 48);
            this.tbUserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(126, 22);
            this.tbUserID.TabIndex = 0;
            this.tbUserID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(117, 97);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(197, 22);
            this.tbName.TabIndex = 1;
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(117, 187);
            this.tbContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(197, 22);
            this.tbContact.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(392, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "RFID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbRFID
            // 
            this.tbRFID.Location = new System.Drawing.Point(490, 137);
            this.tbRFID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRFID.Name = "tbRFID";
            this.tbRFID.Size = new System.Drawing.Size(129, 22);
            this.tbRFID.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "NRIC";
            // 
            // tbNRIC
            // 
            this.tbNRIC.Location = new System.Drawing.Point(117, 142);
            this.tbNRIC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNRIC.Name = "tbNRIC";
            this.tbNRIC.Size = new System.Drawing.Size(197, 22);
            this.tbNRIC.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Address";
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(117, 234);
            this.tbAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(339, 22);
            this.tbAdd.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(392, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Authority";
            // 
            // tbAuthority
            // 
            this.tbAuthority.Location = new System.Drawing.Point(490, 97);
            this.tbAuthority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAuthority.Name = "tbAuthority";
            this.tbAuthority.Size = new System.Drawing.Size(129, 22);
            this.tbAuthority.TabIndex = 12;
            // 
            // btnGetUser
            // 
            this.btnGetUser.Location = new System.Drawing.Point(396, 35);
            this.btnGetUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetUser.Name = "btnGetUser";
            this.btnGetUser.Size = new System.Drawing.Size(223, 42);
            this.btnGetUser.TabIndex = 14;
            this.btnGetUser.Text = "Search Admin";
            this.btnGetUser.UseVisualStyleBackColor = true;
            this.btnGetUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(205, 320);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(133, 48);
            this.btnModify.TabIndex = 15;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(383, 320);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 48);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete Admin";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(555, 320);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 48);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 320);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 48);
            this.button1.TabIndex = 18;
            this.button1.Text = "Clear Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(393, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Shift Start";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ShiftStart
            // 
            this.ShiftStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ShiftStart.Location = new System.Drawing.Point(490, 176);
            this.ShiftStart.Name = "ShiftStart";
            this.ShiftStart.ShowUpDown = true;
            this.ShiftStart.Size = new System.Drawing.Size(129, 22);
            this.ShiftStart.TabIndex = 23;
            this.ShiftStart.Value = new System.DateTime(2024, 1, 10, 16, 48, 34, 0);
            this.ShiftStart.ValueChanged += new System.EventHandler(this.ShiftStart_ValueChanged);
            // 
            // ManageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(708, 389);
            this.Controls.Add(this.ShiftStart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnGetUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAuthority);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNRIC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbRFID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbUserID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageAdmin";
            this.Text = "ManageAdmin";
            this.Load += new System.EventHandler(this.ManageAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRFID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNRIC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAuthority;
        private System.Windows.Forms.Button btnGetUser;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker ShiftStart;
        private System.Windows.Forms.Timer timer1;
    }
}