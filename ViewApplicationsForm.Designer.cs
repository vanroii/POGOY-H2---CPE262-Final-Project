namespace POGOY_H2___CPE262_Final_Project
{
    partial class ViewApplicationsForm
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
            dgvApplications = new DataGridView();
            btnRemoveApplication = new Button();
            txtAppID = new TextBox();
            btnUpdate = new Button();
            cmbStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvApplications).BeginInit();
            SuspendLayout();
            // 
            // dgvApplications
            // 
            dgvApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplications.Dock = DockStyle.Right;
            dgvApplications.Location = new Point(386, 0);
            dgvApplications.Name = "dgvApplications";
            dgvApplications.RowHeadersWidth = 51;
            dgvApplications.Size = new Size(876, 673);
            dgvApplications.TabIndex = 0;
            dgvApplications.CellClick += dgvApplications_CellClick;
            // 
            // btnRemoveApplication
            // 
            btnRemoveApplication.Location = new Point(213, 329);
            btnRemoveApplication.Name = "btnRemoveApplication";
            btnRemoveApplication.Size = new Size(94, 29);
            btnRemoveApplication.TabIndex = 1;
            btnRemoveApplication.Text = "Remove";
            btnRemoveApplication.UseVisualStyleBackColor = true;
            btnRemoveApplication.Click += btnRemoveApplication_Click;
            // 
            // txtAppID
            // 
            txtAppID.Location = new Point(122, 53);
            txtAppID.Name = "txtAppID";
            txtAppID.ReadOnly = true;
            txtAppID.Size = new Size(125, 27);
            txtAppID.TabIndex = 2;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(166, 250);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(129, 135);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 28);
            cmbStatus.TabIndex = 5;
            // 
            // ViewApplicationsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(cmbStatus);
            Controls.Add(btnUpdate);
            Controls.Add(txtAppID);
            Controls.Add(btnRemoveApplication);
            Controls.Add(dgvApplications);
            Name = "ViewApplicationsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewApplicationsForm";
            Load += ViewApplicationsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvApplications).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvApplications;
        private Button btnRemoveApplication;
        private TextBox txtAppID;
        private Button btnUpdate;
        private ComboBox cmbStatus;
    }
}