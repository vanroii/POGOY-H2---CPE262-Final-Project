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
            ((System.ComponentModel.ISupportInitialize)dgvApplicants).BeginInit();
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
            dgvApplicants.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvApplicants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvApplicants.ColumnHeadersHeight = 35;
            dgvApplicants.Dock = DockStyle.Bottom;
            dgvApplicants.EnableHeadersVisualStyles = false;
            dgvApplicants.GridColor = Color.Black;
            dgvApplicants.Location = new Point(0, 113);
            dgvApplicants.Name = "dgvApplicants";
            dgvApplicants.RowHeadersVisible = false;
            dgvApplicants.RowHeadersWidth = 51;
            dgvApplicants.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ButtonShadow;
            dgvApplicants.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
            dgvApplicants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplicants.Size = new Size(1422, 740);
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
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseDownBackColor = Color.White;
            btnBack.FlatAppearance.MouseOverBackColor = Color.Black;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(23, 29);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(83, 55);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnRemoveApplicant
            // 
            btnRemoveApplicant.BackColor = Color.Transparent;
            btnRemoveApplicant.FlatAppearance.BorderSize = 0;
            btnRemoveApplicant.FlatAppearance.MouseDownBackColor = Color.White;
            btnRemoveApplicant.FlatAppearance.MouseOverBackColor = Color.Black;
            btnRemoveApplicant.FlatStyle = FlatStyle.Flat;
            btnRemoveApplicant.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveApplicant.ForeColor = Color.White;
            btnRemoveApplicant.Location = new Point(1249, 29);
            btnRemoveApplicant.Name = "btnRemoveApplicant";
            btnRemoveApplicant.Size = new Size(139, 60);
            btnRemoveApplicant.TabIndex = 4;
            btnRemoveApplicant.Text = "Remove Applicant";
            btnRemoveApplicant.UseVisualStyleBackColor = false;
            btnRemoveApplicant.Click += btnRemoveApplicant_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gadugi", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(112, 34);
            label1.Name = "label1";
            label1.Size = new Size(224, 45);
            label1.TabIndex = 4;
            label1.Text = "Applicants";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(342, 44);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(761, 27);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSendMail
            // 
            btnSendMail.BackColor = Color.Transparent;
            btnSendMail.FlatAppearance.BorderSize = 0;
            btnSendMail.FlatAppearance.MouseDownBackColor = Color.White;
            btnSendMail.FlatAppearance.MouseOverBackColor = Color.Black;
            btnSendMail.FlatStyle = FlatStyle.Flat;
            btnSendMail.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSendMail.ForeColor = Color.White;
            btnSendMail.Location = new Point(1117, 29);
            btnSendMail.Name = "btnSendMail";
            btnSendMail.Size = new Size(126, 55);
            btnSendMail.TabIndex = 7;
            btnSendMail.Text = "Send Mail";
            btnSendMail.UseVisualStyleBackColor = false;
            btnSendMail.Click += btnSendMail_Click;
            // 
            // ViewApplicantsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1422, 853);
            Controls.Add(btnSendMail);
            Controls.Add(txtSearch);
            Controls.Add(btnRemoveApplicant);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(dgvApplicants);
            Name = "ViewApplicantsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewApplicantsForm";
            Load += ViewApplicantsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvApplicants).EndInit();
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
    }
}