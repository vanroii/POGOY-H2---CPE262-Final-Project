namespace POGOY_H2___CPE262_Final_Project
{
    partial class ManageUsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsersForm));
            dgvUsers = new DataGridView();
            txtUserID = new TextBox();
            txtName = new TextBox();
            cmbRole = new ComboBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtEmail = new TextBox();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToResizeColumns = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.ColumnHeadersHeight = 40;
            dgvUsers.Cursor = Cursors.Hand;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.GridColor = Color.Black;
            dgvUsers.Location = new Point(0, 0);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ButtonShadow;
            dgvUsers.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
            dgvUsers.RowTemplate.Height = 40;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(1072, 559);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // txtUserID
            // 
            txtUserID.BackColor = Color.White;
            txtUserID.ForeColor = Color.Black;
            txtUserID.Location = new Point(50, 60);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(200, 27);
            txtUserID.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(350, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 27);
            txtName.TabIndex = 2;
            // 
            // cmbRole
            // 
            cmbRole.ForeColor = Color.Black;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Employer", "Job Seeker" });
            cmbRole.Location = new Point(50, 140);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(200, 27);
            cmbRole.TabIndex = 3;
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
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatAppearance.BorderColor = Color.Gray;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Gadugi", 10.8F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(174, -2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(177, 205);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtEmail
            // 
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(350, 140);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 27);
            txtEmail.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(txtUserID);
            panel3.Controls.Add(cmbRole);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(txtEmail);
            panel3.Dock = DockStyle.Top;
            panel3.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1072, 200);
            panel3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(350, 107);
            label4.Name = "label4";
            label4.Size = new Size(49, 19);
            label4.TabIndex = 11;
            label4.Text = "Email:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(350, 27);
            label3.Name = "label3";
            label3.Size = new Size(52, 19);
            label3.TabIndex = 10;
            label3.Text = "Name:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 107);
            label2.Name = "label2";
            label2.Size = new Size(42, 19);
            label2.TabIndex = 9;
            label2.Text = "Role:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 27);
            label1.Name = "label1";
            label1.Size = new Size(60, 19);
            label1.TabIndex = 8;
            label1.Text = "User ID:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(722, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 200);
            panel1.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvUsers);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 200);
            panel4.Name = "panel4";
            panel4.Size = new Size(1072, 559);
            panel4.TabIndex = 10;
            // 
            // ManageUsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1072, 759);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Name = "ManageUsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageUsersForm";
            Load += ManageUsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsers;
        private TextBox txtUserID;
        private TextBox txtName;
        private ComboBox cmbRole;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtEmail;
        private Panel panel3;
        private Panel panel4;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}