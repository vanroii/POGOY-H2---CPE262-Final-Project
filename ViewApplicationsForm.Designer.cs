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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewApplicationsForm));
            dgvApplications = new DataGridView();
            btnRemoveApplication = new Button();
            txtAppID = new TextBox();
            btnUpdate = new Button();
            cmbStatus = new ComboBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvApplications).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvApplications
            // 
            dgvApplications.AllowUserToAddRows = false;
            dgvApplications.AllowUserToResizeColumns = false;
            dgvApplications.AllowUserToResizeRows = false;
            dgvApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvApplications.BackgroundColor = Color.White;
            dgvApplications.BorderStyle = BorderStyle.None;
            dgvApplications.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvApplications.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvApplications.ColumnHeadersHeight = 40;
            dgvApplications.Cursor = Cursors.Hand;
            dgvApplications.Dock = DockStyle.Fill;
            dgvApplications.EnableHeadersVisualStyles = false;
            dgvApplications.GridColor = Color.Black;
            dgvApplications.Location = new Point(0, 0);
            dgvApplications.Name = "dgvApplications";
            dgvApplications.ReadOnly = true;
            dgvApplications.RowHeadersVisible = false;
            dgvApplications.RowHeadersWidth = 51;
            dgvApplications.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ButtonShadow;
            dgvApplications.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
            dgvApplications.RowTemplate.Height = 40;
            dgvApplications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplications.Size = new Size(1072, 639);
            dgvApplications.TabIndex = 0;
            dgvApplications.CellClick += dgvApplications_CellClick;
            // 
            // btnRemoveApplication
            // 
            btnRemoveApplication.FlatAppearance.BorderColor = Color.Gray;
            btnRemoveApplication.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            btnRemoveApplication.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            btnRemoveApplication.FlatStyle = FlatStyle.Flat;
            btnRemoveApplication.Font = new Font("Gadugi", 10.8F);
            btnRemoveApplication.ForeColor = Color.White;
            btnRemoveApplication.Location = new Point(174, -2);
            btnRemoveApplication.Name = "btnRemoveApplication";
            btnRemoveApplication.Size = new Size(177, 125);
            btnRemoveApplication.TabIndex = 1;
            btnRemoveApplication.Text = "Remove";
            btnRemoveApplication.UseVisualStyleBackColor = true;
            btnRemoveApplication.Click += btnRemoveApplication_Click;
            // 
            // txtAppID
            // 
            txtAppID.BackColor = Color.White;
            txtAppID.Location = new Point(50, 60);
            txtAppID.Name = "txtAppID";
            txtAppID.ReadOnly = true;
            txtAppID.Size = new Size(200, 27);
            txtAppID.TabIndex = 2;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatAppearance.BorderColor = Color.Gray;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.OliveDrab;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.OliveDrab;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Gadugi", 10.8F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(-1, -2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(177, 125);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(350, 60);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(200, 27);
            cmbStatus.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(cmbStatus);
            panel1.Controls.Add(txtAppID);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1072, 120);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(350, 27);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 11;
            label2.Text = "Status:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 27);
            label1.Name = "label1";
            label1.Size = new Size(108, 19);
            label1.TabIndex = 10;
            label1.Text = "Application ID:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnRemoveApplication);
            panel3.Controls.Add(btnUpdate);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(722, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 120);
            panel3.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(dgvApplications);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(1072, 639);
            panel2.TabIndex = 7;
            // 
            // ViewApplicationsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1072, 759);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ViewApplicationsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewApplicationsForm";
            Load += ViewApplicationsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvApplications).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvApplications;
        private Button btnRemoveApplication;
        private TextBox txtAppID;
        private Button btnUpdate;
        private ComboBox cmbStatus;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label2;
    }
}