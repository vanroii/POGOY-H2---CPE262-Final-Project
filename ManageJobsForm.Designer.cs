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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageJobsForm));
            dgvJobs = new DataGridView();
            btnDeleteJob = new Button();
            txtJobID = new TextBox();
            txtTitle = new TextBox();
            txtLocation = new TextBox();
            cmbCategory = new ComboBox();
            btnUpdate = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
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
            dgvJobs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
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
            dgvJobs.Dock = DockStyle.Fill;
            dgvJobs.EnableHeadersVisualStyles = false;
            dgvJobs.GridColor = Color.Black;
            dgvJobs.Location = new Point(0, 0);
            dgvJobs.Name = "dgvJobs";
            dgvJobs.ReadOnly = true;
            dgvJobs.RowHeadersVisible = false;
            dgvJobs.RowHeadersWidth = 51;
            dgvJobs.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ButtonShadow;
            dgvJobs.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
            dgvJobs.RowTemplate.Height = 40;
            dgvJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJobs.Size = new Size(1072, 559);
            dgvJobs.TabIndex = 0;
            dgvJobs.CellClick += dgvJobs_CellClick;
            // 
            // btnDeleteJob
            // 
            btnDeleteJob.FlatAppearance.BorderColor = Color.Gray;
            btnDeleteJob.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            btnDeleteJob.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            btnDeleteJob.FlatStyle = FlatStyle.Flat;
            btnDeleteJob.Font = new Font("Gadugi", 10.8F);
            btnDeleteJob.ForeColor = Color.White;
            btnDeleteJob.Location = new Point(174, -2);
            btnDeleteJob.Name = "btnDeleteJob";
            btnDeleteJob.Size = new Size(177, 205);
            btnDeleteJob.TabIndex = 1;
            btnDeleteJob.Text = "Delete";
            btnDeleteJob.UseVisualStyleBackColor = true;
            btnDeleteJob.Click += btnDeleteJob_Click;
            // 
            // txtJobID
            // 
            txtJobID.BackColor = Color.White;
            txtJobID.Location = new Point(50, 60);
            txtJobID.Name = "txtJobID";
            txtJobID.ReadOnly = true;
            txtJobID.Size = new Size(200, 27);
            txtJobID.TabIndex = 2;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(350, 60);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(300, 27);
            txtTitle.TabIndex = 3;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(350, 140);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(300, 27);
            txtLocation.TabIndex = 4;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "IT", "Sales", "Service", "Construction", "Creative", "Office", "Healthcare", "Education", "Engineering", "Logistics" });
            cmbCategory.Location = new Point(50, 140);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(200, 27);
            cmbCategory.TabIndex = 5;
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
            btnUpdate.Size = new Size(177, 205);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(txtJobID);
            panel1.Controls.Add(cmbCategory);
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(txtLocation);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1072, 200);
            panel1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(350, 107);
            label4.Name = "label4";
            label4.Size = new Size(69, 19);
            label4.TabIndex = 12;
            label4.Text = "Location:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(350, 27);
            label3.Name = "label3";
            label3.Size = new Size(41, 19);
            label3.TabIndex = 11;
            label3.Text = "Title:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 107);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 10;
            label2.Text = "Category:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 27);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 9;
            label1.Text = "Job ID:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(btnDeleteJob);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(722, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 200);
            panel3.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(dgvJobs);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(1072, 559);
            panel2.TabIndex = 8;
            // 
            // ManageJobsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1072, 759);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ManageJobsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageJobsForm";
            Load += ManageJobsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJobs).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvJobs;
        private Button btnDeleteJob;
        private TextBox txtJobID;
        private TextBox txtTitle;
        private TextBox txtLocation;
        private ComboBox cmbCategory;
        private Button btnUpdate;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}