namespace POGOY_H2___CPE262_Final_Project
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            panelSidebar = new Panel();
            label2 = new Label();
            btnViewApplications = new Button();
            lblWelcome = new Label();
            label1 = new Label();
            btnLogout = new Button();
            btnAnalytics = new Button();
            btnManageJobs = new Button();
            btnManageUsers = new Button();
            panelMain = new Panel();
            btnChats = new Button();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.Transparent;
            panelSidebar.BackgroundImage = Properties.Resources.Black_Translucent_50;
            panelSidebar.Controls.Add(btnChats);
            panelSidebar.Controls.Add(label2);
            panelSidebar.Controls.Add(btnViewApplications);
            panelSidebar.Controls.Add(lblWelcome);
            panelSidebar.Controls.Add(label1);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Controls.Add(btnAnalytics);
            panelSidebar.Controls.Add(btnManageJobs);
            panelSidebar.Controls.Add(btnManageUsers);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelSidebar.ForeColor = Color.White;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(350, 853);
            panelSidebar.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 9.5F);
            label2.Location = new Point(123, 150);
            label2.Name = "label2";
            label2.Size = new Size(105, 19);
            label2.TabIndex = 8;
            label2.Text = "Administrator";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnViewApplications
            // 
            btnViewApplications.FlatAppearance.BorderSize = 0;
            btnViewApplications.FlatAppearance.MouseDownBackColor = Color.White;
            btnViewApplications.FlatAppearance.MouseOverBackColor = Color.Black;
            btnViewApplications.FlatStyle = FlatStyle.Flat;
            btnViewApplications.ForeColor = Color.White;
            btnViewApplications.Location = new Point(0, 380);
            btnViewApplications.Name = "btnViewApplications";
            btnViewApplications.Size = new Size(350, 100);
            btnViewApplications.TabIndex = 7;
            btnViewApplications.Text = "View Applications";
            btnViewApplications.UseVisualStyleBackColor = true;
            btnViewApplications.Click += btnViewApplications_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top;
            lblWelcome.Font = new Font("Gadugi", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(0, 94);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(350, 42);
            lblWelcome.TabIndex = 6;
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 59);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 5;
            label1.Text = "Welcome,";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            btnLogout.BackgroundImageLayout = ImageLayout.None;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.White;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.Black;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 720);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(350, 100);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAnalytics
            // 
            btnAnalytics.FlatAppearance.BorderSize = 0;
            btnAnalytics.FlatAppearance.MouseDownBackColor = Color.White;
            btnAnalytics.FlatAppearance.MouseOverBackColor = Color.Black;
            btnAnalytics.FlatStyle = FlatStyle.Flat;
            btnAnalytics.ForeColor = Color.White;
            btnAnalytics.Location = new Point(0, 480);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.Size = new Size(350, 100);
            btnAnalytics.TabIndex = 3;
            btnAnalytics.Text = "Analytics";
            btnAnalytics.UseVisualStyleBackColor = true;
            btnAnalytics.Click += btnAnalytics_Click;
            // 
            // btnManageJobs
            // 
            btnManageJobs.FlatAppearance.BorderSize = 0;
            btnManageJobs.FlatAppearance.MouseDownBackColor = Color.White;
            btnManageJobs.FlatAppearance.MouseOverBackColor = Color.Black;
            btnManageJobs.FlatStyle = FlatStyle.Flat;
            btnManageJobs.ForeColor = Color.White;
            btnManageJobs.Location = new Point(0, 280);
            btnManageJobs.Name = "btnManageJobs";
            btnManageJobs.Size = new Size(350, 100);
            btnManageJobs.TabIndex = 1;
            btnManageJobs.Text = "Manage Jobs";
            btnManageJobs.UseVisualStyleBackColor = true;
            btnManageJobs.Click += btnManageJobs_Click;
            // 
            // btnManageUsers
            // 
            btnManageUsers.FlatAppearance.BorderSize = 0;
            btnManageUsers.FlatAppearance.MouseDownBackColor = Color.White;
            btnManageUsers.FlatAppearance.MouseOverBackColor = Color.Black;
            btnManageUsers.FlatStyle = FlatStyle.Flat;
            btnManageUsers.ForeColor = Color.White;
            btnManageUsers.Location = new Point(0, 180);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(350, 100);
            btnManageUsers.TabIndex = 0;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = true;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.Transparent;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(350, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1072, 853);
            panelMain.TabIndex = 7;
            // 
            // btnChats
            // 
            btnChats.FlatAppearance.BorderSize = 0;
            btnChats.FlatAppearance.MouseDownBackColor = Color.White;
            btnChats.FlatAppearance.MouseOverBackColor = Color.Black;
            btnChats.FlatStyle = FlatStyle.Flat;
            btnChats.ForeColor = Color.White;
            btnChats.Location = new Point(0, 580);
            btnChats.Name = "btnChats";
            btnChats.Size = new Size(350, 100);
            btnChats.TabIndex = 9;
            btnChats.Text = "Messages";
            btnChats.UseVisualStyleBackColor = true;
            btnChats.Click += btnChats_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1422, 853);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Button btnViewApplications;
        private Label lblWelcome;
        private Label label1;
        private Button btnLogout;
        private Button btnAnalytics;
        private Button btnManageJobs;
        private Button btnManageUsers;
        private Panel panelMain;
        private Label label2;
        private Button btnChats;
    }
}