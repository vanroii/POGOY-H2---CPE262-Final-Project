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
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvMyApplications).BeginInit();
            panel1.SuspendLayout();
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
            dgvMyApplications.Dock = DockStyle.Bottom;
            dgvMyApplications.EnableHeadersVisualStyles = false;
            dgvMyApplications.GridColor = Color.Black;
            dgvMyApplications.Location = new Point(0, 100);
            dgvMyApplications.Name = "dgvMyApplications";
            dgvMyApplications.ReadOnly = true;
            dgvMyApplications.RowHeadersVisible = false;
            dgvMyApplications.RowHeadersWidth = 51;
            dgvMyApplications.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ButtonShadow;
            dgvMyApplications.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
            dgvMyApplications.RowTemplate.Height = 40;
            dgvMyApplications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMyApplications.Size = new Size(1262, 573);
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
            btnBack.Font = new Font("Gadugi", 38F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(0, -13);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 113);
            btnBack.TabIndex = 1;
            btnBack.Text = "←";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Transparent;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.Gray;
            btnEdit.FlatAppearance.MouseDownBackColor = Color.OliveDrab;
            btnEdit.FlatAppearance.MouseOverBackColor = Color.OliveDrab;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Gadugi", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(-1, -1);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(178, 103);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDeleteApplication
            // 
            btnDeleteApplication.BackColor = Color.Transparent;
            btnDeleteApplication.FlatAppearance.BorderColor = Color.Gray;
            btnDeleteApplication.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            btnDeleteApplication.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            btnDeleteApplication.FlatStyle = FlatStyle.Flat;
            btnDeleteApplication.Font = new Font("Gadugi", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteApplication.ForeColor = Color.White;
            btnDeleteApplication.Location = new Point(174, -1);
            btnDeleteApplication.Name = "btnDeleteApplication";
            btnDeleteApplication.Size = new Size(178, 103);
            btnDeleteApplication.TabIndex = 3;
            btnDeleteApplication.Text = "Delete Application";
            btnDeleteApplication.UseVisualStyleBackColor = false;
            btnDeleteApplication.Click += btnDeleteApplication_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnDeleteApplication);
            panel1.Controls.Add(btnEdit);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(912, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 100);
            panel1.TabIndex = 4;
            // 
            // ViewMyApplicationsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(dgvMyApplications);
            Name = "ViewMyApplicationsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewMyApplicationsForm";
            Load += ViewMyApplicationsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMyApplications).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMyApplications;
        private Button btnBack;
        private Button btnEdit;
        private Button btnDeleteApplication;
        private Panel panel1;
    }
}