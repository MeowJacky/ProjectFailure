namespace Forms1
{
    partial class User
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
            this.userusername = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectWSYSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userusername
            // 
            this.userusername.AutoSize = true;
            this.userusername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userusername.Location = new System.Drawing.Point(631, 9);
            this.userusername.Name = "userusername";
            this.userusername.Size = new System.Drawing.Size(51, 20);
            this.userusername.TabIndex = 0;
            this.userusername.Text = "label1";
            this.userusername.Click += new System.EventHandler(this.userusername_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.projectWSYSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(12, 29);
            this.profileToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // projectWSYSToolStripMenuItem
            // 
            this.projectWSYSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.projectWSYSToolStripMenuItem.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.projectWSYSToolStripMenuItem.Name = "projectWSYSToolStripMenuItem";
            this.projectWSYSToolStripMenuItem.Size = new System.Drawing.Size(178, 36);
            this.projectWSYSToolStripMenuItem.Text = "Project W-SYS";
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.logout.Location = new System.Drawing.Point(704, 9);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(71, 20);
            this.logout.TabIndex = 2;
            this.logout.Text = "Sign Out";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(784, 545);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.userusername);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userusername;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectWSYSToolStripMenuItem;
        private System.Windows.Forms.Label logout;
    }
}