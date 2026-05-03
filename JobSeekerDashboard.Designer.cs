namespace POGOY_H2___CPE262_Final_Project
{
    partial class JobSeekerDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobSeekerDashboard));
            dgvJobs = new DataGridView();
            panelSidebar = new Panel();
            btnMailInbox = new Button();
            lblUserID = new Label();
            btnProfile = new Button();
            label1 = new Label();
            btnLogout = new Button();
            btnViewApplications = new Button();
            btnViewJob = new Button();
            lblWelcome = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            label2 = new Label();
            btnChats = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).BeginInit();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // dgvJobs
            // 
            dgvJobs.AllowUserToAddRows = false;
            dgvJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJobs.BackgroundColor = Color.White;
            dgvJobs.BorderStyle = BorderStyle.None;
            dgvJobs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvJobs.ColumnHeadersHeight = 35;
            dgvJobs.EnableHeadersVisualStyles = false;
            dgvJobs.GridColor = Color.Black;
            dgvJobs.Location = new Point(390, 125);
            dgvJobs.MaximumSize = new Size(1000, 700);
            dgvJobs.MinimumSize = new Size(1000, 90);
            dgvJobs.Name = "dgvJobs";
            dgvJobs.ReadOnly = true;
            dgvJobs.RowHeadersVisible = false;
            dgvJobs.RowHeadersWidth = 51;
            dgvJobs.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ButtonShadow;
            dgvJobs.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
            dgvJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJobs.Size = new Size(1000, 700);
            dgvJobs.TabIndex = 0;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.Transparent;
            panelSidebar.BackgroundImage = Properties.Resources.Black_Translucent_50;
            panelSidebar.Controls.Add(btnChats);
            panelSidebar.Controls.Add(btnMailInbox);
            panelSidebar.Controls.Add(lblUserID);
            panelSidebar.Controls.Add(btnProfile);
            panelSidebar.Controls.Add(label1);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Controls.Add(btnViewApplications);
            panelSidebar.Controls.Add(btnViewJob);
            panelSidebar.Controls.Add(lblWelcome);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelSidebar.ForeColor = Color.White;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(350, 853);
            panelSidebar.TabIndex = 1;
            // 
            // btnMailInbox
            // 
            btnMailInbox.FlatAppearance.BorderSize = 0;
            btnMailInbox.FlatAppearance.MouseDownBackColor = Color.White;
            btnMailInbox.FlatAppearance.MouseOverBackColor = Color.Black;
            btnMailInbox.FlatStyle = FlatStyle.Flat;
            btnMailInbox.Location = new Point(0, 480);
            btnMailInbox.Name = "btnMailInbox";
            btnMailInbox.Size = new Size(350, 100);
            btnMailInbox.TabIndex = 10;
            btnMailInbox.Text = "Mail Inbox";
            btnMailInbox.UseVisualStyleBackColor = true;
            btnMailInbox.Click += btnMailInbox_Click;
            // 
            // lblUserID
            // 
            lblUserID.Font = new Font("Gadugi", 9.5F);
            lblUserID.Location = new Point(0, 150);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(350, 21);
            lblUserID.TabIndex = 9;
            lblUserID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnProfile
            // 
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatAppearance.MouseDownBackColor = Color.White;
            btnProfile.FlatAppearance.MouseOverBackColor = Color.Black;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Location = new Point(0, 180);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(350, 100);
            btnProfile.TabIndex = 5;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 59);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 4;
            label1.Text = "Welcome,";
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.White;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.Black;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(0, 720);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(350, 100);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnViewApplications
            // 
            btnViewApplications.FlatAppearance.BorderSize = 0;
            btnViewApplications.FlatAppearance.MouseDownBackColor = Color.White;
            btnViewApplications.FlatAppearance.MouseOverBackColor = Color.Black;
            btnViewApplications.FlatStyle = FlatStyle.Flat;
            btnViewApplications.Location = new Point(0, 380);
            btnViewApplications.Name = "btnViewApplications";
            btnViewApplications.Size = new Size(350, 100);
            btnViewApplications.TabIndex = 2;
            btnViewApplications.Text = "View Applications";
            btnViewApplications.UseVisualStyleBackColor = true;
            btnViewApplications.Click += btnViewApplications_Click;
            // 
            // btnViewJob
            // 
            btnViewJob.FlatAppearance.BorderSize = 0;
            btnViewJob.FlatAppearance.MouseDownBackColor = Color.White;
            btnViewJob.FlatAppearance.MouseOverBackColor = Color.Black;
            btnViewJob.FlatStyle = FlatStyle.Flat;
            btnViewJob.Location = new Point(0, 280);
            btnViewJob.Name = "btnViewJob";
            btnViewJob.Size = new Size(350, 100);
            btnViewJob.TabIndex = 1;
            btnViewJob.Text = "View Job";
            btnViewJob.UseVisualStyleBackColor = true;
            btnViewJob.Click += btnViewJob_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top;
            lblWelcome.Font = new Font("Gadugi", 16.2F, FontStyle.Bold);
            lblWelcome.Location = new Point(0, 94);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(350, 42);
            lblWelcome.TabIndex = 0;
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(390, 80);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(822, 27);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.OliveDrab;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1230, 80);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(160, 27);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gadugi", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(384, 25);
            label2.Name = "label2";
            label2.Size = new Size(1000, 45);
            label2.TabIndex = 4;
            label2.Text = "Job Seeker Dashboard";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnChats
            // 
            btnChats.FlatAppearance.BorderSize = 0;
            btnChats.FlatAppearance.MouseDownBackColor = Color.White;
            btnChats.FlatAppearance.MouseOverBackColor = Color.Black;
            btnChats.FlatStyle = FlatStyle.Flat;
            btnChats.Location = new Point(0, 580);
            btnChats.Name = "btnChats";
            btnChats.Size = new Size(350, 100);
            btnChats.TabIndex = 11;
            btnChats.Text = "Messages";
            btnChats.UseVisualStyleBackColor = true;
            btnChats.Click += btnChats_Click;
            // 
            // JobSeekerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1422, 853);
            Controls.Add(label2);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvJobs);
            Controls.Add(panelSidebar);
            Name = "JobSeekerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JobSeekerDashboard";
            Load += JobSeekerDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJobs).EndInit();
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvJobs;
        private Panel panelSidebar;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblWelcome;
        private Button btnLogout;
        private Button btnViewApplications;
        private Button btnViewJob;
        private Label label1;
        private Label label2;
        private Button btnProfile;
        private Label lblUserID;
        private Button btnMailInbox;
        private Button btnChats;
    }
}