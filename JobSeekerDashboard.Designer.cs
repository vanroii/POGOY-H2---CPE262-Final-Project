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
            btnChats = new Button();
            btnMailInbox = new Button();
            lblUserID = new Label();
            btnProfile = new Button();
            label1 = new Label();
            btnLogout = new Button();
            btnViewApplications = new Button();
            lblWelcome = new Label();
            btnViewJob = new Button();
            txtSearch = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).BeginInit();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // dgvJobs
            // 
            dgvJobs.AllowUserToAddRows = false;
            dgvJobs.AllowUserToResizeColumns = false;
            dgvJobs.AllowUserToResizeRows = false;
            dgvJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJobs.BackgroundColor = Color.White;
            dgvJobs.BorderStyle = BorderStyle.None;
            dgvJobs.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvJobs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvJobs.ColumnHeadersHeight = 40;
            dgvJobs.Cursor = Cursors.Hand;
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
            dgvJobs.RowTemplate.Height = 40;
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
            panelSidebar.Controls.Add(lblWelcome);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelSidebar.ForeColor = Color.White;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(350, 853);
            panelSidebar.TabIndex = 1;
            // 
            // btnChats
            // 
            btnChats.FlatAppearance.BorderColor = Color.Gray;
            btnChats.FlatAppearance.BorderSize = 0;
            btnChats.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnChats.FlatAppearance.MouseOverBackColor = Color.Black;
            btnChats.FlatStyle = FlatStyle.Flat;
            btnChats.Location = new Point(-2, 550);
            btnChats.Name = "btnChats";
            btnChats.Size = new Size(355, 100);
            btnChats.TabIndex = 11;
            btnChats.Text = "Messages";
            btnChats.UseVisualStyleBackColor = true;
            btnChats.Click += btnChats_Click;
            // 
            // btnMailInbox
            // 
            btnMailInbox.FlatAppearance.BorderColor = Color.Gray;
            btnMailInbox.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnMailInbox.FlatAppearance.MouseOverBackColor = Color.Black;
            btnMailInbox.FlatStyle = FlatStyle.Flat;
            btnMailInbox.Location = new Point(-2, 450);
            btnMailInbox.Name = "btnMailInbox";
            btnMailInbox.Size = new Size(355, 100);
            btnMailInbox.TabIndex = 10;
            btnMailInbox.Text = "Mail Inbox";
            btnMailInbox.UseVisualStyleBackColor = true;
            btnMailInbox.Click += btnMailInbox_Click;
            // 
            // lblUserID
            // 
            lblUserID.Font = new Font("Gadugi", 9F);
            lblUserID.Location = new Point(0, 131);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(350, 21);
            lblUserID.TabIndex = 9;
            lblUserID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnProfile
            // 
            btnProfile.FlatAppearance.BorderColor = Color.Gray;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnProfile.FlatAppearance.MouseOverBackColor = Color.Black;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Location = new Point(-2, 250);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(355, 100);
            btnProfile.TabIndex = 5;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 40);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 4;
            label1.Text = "Welcome,";
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.Black;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(0, 750);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(350, 100);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnViewApplications
            // 
            btnViewApplications.FlatAppearance.BorderColor = Color.Gray;
            btnViewApplications.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnViewApplications.FlatAppearance.MouseOverBackColor = Color.Black;
            btnViewApplications.FlatStyle = FlatStyle.Flat;
            btnViewApplications.Location = new Point(-2, 350);
            btnViewApplications.Name = "btnViewApplications";
            btnViewApplications.Size = new Size(355, 100);
            btnViewApplications.TabIndex = 2;
            btnViewApplications.Text = "View Applications";
            btnViewApplications.UseVisualStyleBackColor = true;
            btnViewApplications.Click += btnViewApplications_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top;
            lblWelcome.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(0, 75);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(350, 42);
            lblWelcome.TabIndex = 0;
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnViewJob
            // 
            btnViewJob.BackColor = Color.OliveDrab;
            btnViewJob.Cursor = Cursors.Hand;
            btnViewJob.FlatAppearance.BorderSize = 0;
            btnViewJob.FlatAppearance.MouseDownBackColor = Color.DarkOliveGreen;
            btnViewJob.FlatAppearance.MouseOverBackColor = Color.DarkOliveGreen;
            btnViewJob.FlatStyle = FlatStyle.Flat;
            btnViewJob.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewJob.ForeColor = Color.White;
            btnViewJob.Location = new Point(1226, 80);
            btnViewJob.Name = "btnViewJob";
            btnViewJob.Size = new Size(164, 27);
            btnViewJob.TabIndex = 1;
            btnViewJob.Text = "View Job";
            btnViewJob.UseVisualStyleBackColor = false;
            btnViewJob.Click += btnViewJob_Click;
            // 
            // txtSearch
            // 
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(390, 80);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(822, 27);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
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
            // JobSeekerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1422, 853);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(dgvJobs);
            Controls.Add(panelSidebar);
            Controls.Add(btnViewJob);
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