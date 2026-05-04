namespace POGOY_H2___CPE262_Final_Project
{
    partial class EmployerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployerDashboard));
            dgvJobs = new DataGridView();
            panelSidebar = new Panel();
            btnChats = new Button();
            btnSentMails = new Button();
            lblUserID = new Label();
            lblWelcome = new Label();
            label1 = new Label();
            btnLogout = new Button();
            btnViewApplicants = new Button();
            btnEditJob = new Button();
            btnAddJob = new Button();
            btnDeleteJob = new Button();
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
            dgvJobs.TabIndex = 4;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.Transparent;
            panelSidebar.BackgroundImage = Properties.Resources.Black_Translucent_50;
            panelSidebar.Controls.Add(btnChats);
            panelSidebar.Controls.Add(btnSentMails);
            panelSidebar.Controls.Add(lblUserID);
            panelSidebar.Controls.Add(lblWelcome);
            panelSidebar.Controls.Add(label1);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Controls.Add(btnViewApplicants);
            panelSidebar.Controls.Add(btnEditJob);
            panelSidebar.Controls.Add(btnAddJob);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelSidebar.ForeColor = Color.White;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(350, 853);
            panelSidebar.TabIndex = 5;
            // 
            // btnChats
            // 
            btnChats.FlatAppearance.BorderColor = Color.Gray;
            btnChats.FlatAppearance.BorderSize = 0;
            btnChats.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnChats.FlatAppearance.MouseOverBackColor = Color.Black;
            btnChats.FlatStyle = FlatStyle.Flat;
            btnChats.ForeColor = Color.White;
            btnChats.Location = new Point(-2, 600);
            btnChats.Name = "btnChats";
            btnChats.Size = new Size(355, 100);
            btnChats.TabIndex = 10;
            btnChats.Text = "Messages";
            btnChats.UseVisualStyleBackColor = true;
            btnChats.Click += btnChats_Click;
            // 
            // btnSentMails
            // 
            btnSentMails.FlatAppearance.BorderColor = Color.Gray;
            btnSentMails.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnSentMails.FlatAppearance.MouseOverBackColor = Color.Black;
            btnSentMails.FlatStyle = FlatStyle.Flat;
            btnSentMails.ForeColor = Color.White;
            btnSentMails.Location = new Point(-2, 500);
            btnSentMails.Name = "btnSentMails";
            btnSentMails.Size = new Size(355, 100);
            btnSentMails.TabIndex = 9;
            btnSentMails.Text = "Mails Sent";
            btnSentMails.UseVisualStyleBackColor = true;
            btnSentMails.Click += btnSentMails_Click;
            // 
            // lblUserID
            // 
            lblUserID.Font = new Font("Gadugi", 9F);
            lblUserID.Location = new Point(0, 131);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(350, 21);
            lblUserID.TabIndex = 8;
            lblUserID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top;
            lblWelcome.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(0, 75);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(350, 42);
            lblWelcome.TabIndex = 6;
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 40);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 5;
            label1.Text = "Welcome,";
            // 
            // btnLogout
            // 
            btnLogout.BackgroundImageLayout = ImageLayout.None;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.Black;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 750);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(350, 100);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnViewApplicants
            // 
            btnViewApplicants.FlatAppearance.BorderColor = Color.Gray;
            btnViewApplicants.FlatAppearance.BorderSize = 2;
            btnViewApplicants.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnViewApplicants.FlatAppearance.MouseOverBackColor = Color.Black;
            btnViewApplicants.FlatStyle = FlatStyle.Flat;
            btnViewApplicants.ForeColor = Color.White;
            btnViewApplicants.Location = new Point(-2, 400);
            btnViewApplicants.Name = "btnViewApplicants";
            btnViewApplicants.Size = new Size(355, 100);
            btnViewApplicants.TabIndex = 2;
            btnViewApplicants.Text = "View Applicants";
            btnViewApplicants.UseVisualStyleBackColor = true;
            btnViewApplicants.Click += btnViewApplicants_Click;
            // 
            // btnEditJob
            // 
            btnEditJob.FlatAppearance.BorderColor = Color.Gray;
            btnEditJob.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnEditJob.FlatAppearance.MouseOverBackColor = Color.Black;
            btnEditJob.FlatStyle = FlatStyle.Flat;
            btnEditJob.ForeColor = Color.White;
            btnEditJob.Location = new Point(-2, 300);
            btnEditJob.Name = "btnEditJob";
            btnEditJob.Size = new Size(355, 100);
            btnEditJob.TabIndex = 1;
            btnEditJob.Text = "Edit / Update Job";
            btnEditJob.UseVisualStyleBackColor = true;
            btnEditJob.Click += btnEditJob_Click;
            // 
            // btnAddJob
            // 
            btnAddJob.FlatAppearance.BorderColor = Color.Gray;
            btnAddJob.FlatAppearance.BorderSize = 0;
            btnAddJob.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnAddJob.FlatAppearance.MouseOverBackColor = Color.Black;
            btnAddJob.FlatStyle = FlatStyle.Flat;
            btnAddJob.ForeColor = Color.White;
            btnAddJob.Location = new Point(-2, 200);
            btnAddJob.Name = "btnAddJob";
            btnAddJob.Size = new Size(355, 100);
            btnAddJob.TabIndex = 0;
            btnAddJob.Text = "Add Job";
            btnAddJob.UseVisualStyleBackColor = true;
            btnAddJob.Click += btnAddJob_Click;
            // 
            // btnDeleteJob
            // 
            btnDeleteJob.BackColor = Color.Firebrick;
            btnDeleteJob.Cursor = Cursors.Hand;
            btnDeleteJob.FlatAppearance.BorderSize = 0;
            btnDeleteJob.FlatAppearance.MouseDownBackColor = Color.White;
            btnDeleteJob.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnDeleteJob.FlatStyle = FlatStyle.Flat;
            btnDeleteJob.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteJob.ForeColor = Color.White;
            btnDeleteJob.Location = new Point(1226, 80);
            btnDeleteJob.Name = "btnDeleteJob";
            btnDeleteJob.Size = new Size(164, 27);
            btnDeleteJob.TabIndex = 7;
            btnDeleteJob.Text = "Delete Job";
            btnDeleteJob.UseVisualStyleBackColor = false;
            btnDeleteJob.Click += btnDeleteJob_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(390, 80);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(822, 27);
            txtSearch.TabIndex = 6;
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
            label2.TabIndex = 8;
            label2.Text = "Employer Dashboard";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EmployerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1422, 853);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(btnDeleteJob);
            Controls.Add(panelSidebar);
            Controls.Add(dgvJobs);
            Name = "EmployerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployerDashboard";
            Load += EmployerDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJobs).EndInit();
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtDescription;
        private TextBox txtLocation;
        private DataGridView dgvJobs;
        private Panel panelSidebar;
        private Button btnLogout;
        private Button btnViewApplicants;
        private Button btnEditJob;
        private Button btnAddJob;
        private TextBox txtSearch;
        private Label label1;
        private Label lblWelcome;
        private Label label2;
        private Button btnDeleteJob;
        private Label lblUserID;
        private Button btnSentMails;
        private Button btnChats;
    }
}