namespace POGOY_H2___CPE262_Final_Project
{
    partial class ViewMyApplicationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMyApplicationsForm));
            dgvMyApplications = new DataGridView();
            btnBack = new Button();
            btnEdit = new Button();
            btnDeleteApplication = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMyApplications).BeginInit();
            SuspendLayout();
            // 
            // dgvMyApplications
            // 
            dgvMyApplications.AllowUserToAddRows = false;
            dgvMyApplications.AllowUserToResizeColumns = false;
            dgvMyApplications.AllowUserToResizeRows = false;
            dgvMyApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMyApplications.BackgroundColor = Color.White;
            dgvMyApplications.BorderStyle = BorderStyle.None;
            dgvMyApplications.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvMyApplications.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMyApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMyApplications.ColumnHeadersHeight = 40;
            dgvMyApplications.Cursor = Cursors.Hand;
            dgvMyApplications.EnableHeadersVisualStyles = false;
            dgvMyApplications.GridColor = Color.Black;
            dgvMyApplications.Location = new Point(12, 58);
            dgvMyApplications.MaximumSize = new Size(1238, 600);
            dgvMyApplications.MinimumSize = new Size(1238, 90);
            dgvMyApplications.Name = "dgvMyApplications";
            dgvMyApplications.ReadOnly = true;
            dgvMyApplications.RowHeadersVisible = false;
            dgvMyApplications.RowHeadersWidth = 51;
            dgvMyApplications.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ButtonShadow;
            dgvMyApplications.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
            dgvMyApplications.RowTemplate.Height = 40;
            dgvMyApplications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMyApplications.Size = new Size(1238, 600);
            dgvMyApplications.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBack.FlatAppearance.MouseOverBackColor = Color.Black;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Gadugi", 33F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(0, -13);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 65);
            btnBack.TabIndex = 1;
            btnBack.Text = "←";
            btnBack.TextAlign = ContentAlignment.TopCenter;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.OliveDrab;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatAppearance.MouseDownBackColor = Color.DarkOliveGreen;
            btnEdit.FlatAppearance.MouseOverBackColor = Color.DarkOliveGreen;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(928, 11);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(158, 35);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDeleteApplication
            // 
            btnDeleteApplication.BackColor = Color.Firebrick;
            btnDeleteApplication.FlatAppearance.BorderSize = 0;
            btnDeleteApplication.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnDeleteApplication.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnDeleteApplication.FlatStyle = FlatStyle.Flat;
            btnDeleteApplication.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteApplication.ForeColor = Color.White;
            btnDeleteApplication.Location = new Point(1092, 12);
            btnDeleteApplication.Name = "btnDeleteApplication";
            btnDeleteApplication.Size = new Size(158, 35);
            btnDeleteApplication.TabIndex = 3;
            btnDeleteApplication.Text = "Delete Application";
            btnDeleteApplication.UseVisualStyleBackColor = false;
            btnDeleteApplication.Click += btnDeleteApplication_Click;
            // 
            // ViewMyApplicationsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnDeleteApplication);
            Controls.Add(btnEdit);
            Controls.Add(btnBack);
            Controls.Add(dgvMyApplications);
            Name = "ViewMyApplicationsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewMyApplicationsForm";
            Load += ViewMyApplicationsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMyApplications).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMyApplications;
        private Button btnBack;
        private Button btnEdit;
        private Button btnDeleteApplication;
    }
}