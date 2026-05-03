namespace POGOY_H2___CPE262_Final_Project
{
    partial class ManageJobsForm
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
            dgvJobs = new DataGridView();
            btnDeleteJob = new Button();
            txtJobID = new TextBox();
            txtTitle = new TextBox();
            txtLocation = new TextBox();
            cmbCategory = new ComboBox();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).BeginInit();
            SuspendLayout();
            // 
            // dgvJobs
            // 
            dgvJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobs.Dock = DockStyle.Right;
            dgvJobs.Location = new Point(359, 0);
            dgvJobs.Name = "dgvJobs";
            dgvJobs.RowHeadersWidth = 51;
            dgvJobs.Size = new Size(903, 673);
            dgvJobs.TabIndex = 0;
            dgvJobs.CellClick += dgvJobs_CellClick;
            // 
            // btnDeleteJob
            // 
            btnDeleteJob.Location = new Point(111, 418);
            btnDeleteJob.Name = "btnDeleteJob";
            btnDeleteJob.Size = new Size(94, 29);
            btnDeleteJob.TabIndex = 1;
            btnDeleteJob.Text = "Delete";
            btnDeleteJob.UseVisualStyleBackColor = true;
            btnDeleteJob.Click += btnDeleteJob_Click;
            // 
            // txtJobID
            // 
            txtJobID.Location = new Point(124, 56);
            txtJobID.Name = "txtJobID";
            txtJobID.ReadOnly = true;
            txtJobID.Size = new Size(125, 27);
            txtJobID.TabIndex = 2;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(113, 129);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 3;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(111, 186);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(125, 27);
            txtLocation.TabIndex = 4;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(113, 235);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 28);
            cmbCategory.TabIndex = 5;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(143, 354);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // ManageJobsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnUpdate);
            Controls.Add(cmbCategory);
            Controls.Add(txtLocation);
            Controls.Add(txtTitle);
            Controls.Add(txtJobID);
            Controls.Add(btnDeleteJob);
            Controls.Add(dgvJobs);
            Name = "ManageJobsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageJobsForm";
            Load += ManageJobsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJobs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvJobs;
        private Button btnDeleteJob;
        private TextBox txtJobID;
        private TextBox txtTitle;
        private TextBox txtLocation;
        private ComboBox cmbCategory;
        private Button btnUpdate;
    }
}