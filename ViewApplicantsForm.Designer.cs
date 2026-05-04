namespace POGOY_H2___CPE262_Final_Project
{
    partial class ViewApplicantsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewApplicantsForm));
            dgvApplicants = new DataGridView();
            btnBack = new Button();
            btnRemoveApplicant = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            btnSendMail = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvApplicants).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvApplicants
            // 
            dgvApplicants.AllowUserToAddRows = false;
            dgvApplicants.AllowUserToResizeColumns = false;
            dgvApplicants.AllowUserToResizeRows = false;
            dgvApplicants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvApplicants.BackgroundColor = Color.White;
            dgvApplicants.BorderStyle = BorderStyle.None;
            dgvApplicants.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvApplicants.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvApplicants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvApplicants.ColumnHeadersHeight = 40;
            dgvApplicants.Cursor = Cursors.Hand;
            dgvApplicants.Dock = DockStyle.Bottom;
            dgvApplicants.EnableHeadersVisualStyles = false;
            dgvApplicants.GridColor = Color.Black;
            dgvApplicants.Location = new Point(0, 103);
            dgvApplicants.Name = "dgvApplicants";
            dgvApplicants.RowHeadersVisible = false;
            dgvApplicants.RowHeadersWidth = 51;
            dgvApplicants.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ButtonShadow;
            dgvApplicants.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
            dgvApplicants.RowTemplate.Height = 40;
            dgvApplicants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplicants.Size = new Size(1422, 750);
            dgvApplicants.TabIndex = 0;
            dgvApplicants.CellClick += dgvApplicants_CellClick;
            dgvApplicants.CellValueChanged += dgvApplicants_CellValueChanged;
            dgvApplicants.CurrentCellDirtyStateChanged += dgvApplicants_CurrentCellDirtyStateChanged;
            dgvApplicants.DataError += dgvApplicants_DataError;
            dgvApplicants.RowPrePaint += dgvApplicants_RowPrePaint;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseDownBackColor = Color.White;
            btnBack.FlatAppearance.MouseOverBackColor = Color.Black;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Gadugi", 35F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(0, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(106, 89);
            btnBack.TabIndex = 5;
            btnBack.Text = "←";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnRemoveApplicant
            // 
            btnRemoveApplicant.BackColor = Color.Transparent;
            btnRemoveApplicant.FlatAppearance.BorderColor = Color.Gray;
            btnRemoveApplicant.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            btnRemoveApplicant.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            btnRemoveApplicant.FlatStyle = FlatStyle.Flat;
            btnRemoveApplicant.Font = new Font("Gadugi", 10F);
            btnRemoveApplicant.ForeColor = Color.White;
            btnRemoveApplicant.Location = new Point(174, -2);
            btnRemoveApplicant.Name = "btnRemoveApplicant";
            btnRemoveApplicant.Size = new Size(177, 107);
            btnRemoveApplicant.TabIndex = 4;
            btnRemoveApplicant.Text = "Remove Applicant";
            btnRemoveApplicant.UseVisualStyleBackColor = false;
            btnRemoveApplicant.Click += btnRemoveApplicant_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(102, 28);
            label1.Name = "label1";
            label1.Size = new Size(224, 45);
            label1.TabIndex = 4;
            label1.Text = "Applicants";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(290, 38);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(740, 27);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSendMail
            // 
            btnSendMail.BackColor = Color.Transparent;
            btnSendMail.FlatAppearance.BorderColor = Color.Gray;
            btnSendMail.FlatAppearance.MouseDownBackColor = Color.OliveDrab;
            btnSendMail.FlatAppearance.MouseOverBackColor = Color.OliveDrab;
            btnSendMail.FlatStyle = FlatStyle.Flat;
            btnSendMail.Font = new Font("Gadugi", 10F);
            btnSendMail.ForeColor = Color.White;
            btnSendMail.Location = new Point(-1, -2);
            btnSendMail.Name = "btnSendMail";
            btnSendMail.Size = new Size(177, 107);
            btnSendMail.TabIndex = 7;
            btnSendMail.Text = "Send Mail";
            btnSendMail.UseVisualStyleBackColor = false;
            btnSendMail.Click += btnSendMail_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnRemoveApplicant);
            panel1.Controls.Add(btnSendMail);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1072, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 103);
            panel1.TabIndex = 8;
            // 
            // ViewApplicantsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1422, 853);
            Controls.Add(panel1);
            Controls.Add(txtSearch);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(dgvApplicants);
            Name = "ViewApplicantsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewApplicantsForm";
            Load += ViewApplicantsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvApplicants).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvApplicants;
        private Label label1;
        private Button btnRemoveApplicant;
        private Button btnBack;
        private TextBox txtSearch;
        private Button btnSendMail;
        private Panel panel1;
    }
}