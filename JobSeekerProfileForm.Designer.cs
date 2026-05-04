namespace POGOY_H2___CPE262_Final_Project
{
    partial class JobSeekerProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobSeekerProfileForm));
            panel1 = new Panel();
            label4 = new Label();
            btnBack = new Button();
            lblCategory = new Label();
            lblAge = new Label();
            lblExperience = new Label();
            lblSkills = new Label();
            lblName = new Label();
            txtName = new TextBox();
            btnSave = new Button();
            cmbCategory = new ComboBox();
            numAge = new NumericUpDown();
            numExperience = new NumericUpDown();
            txtSkills = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numExperience).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.Black_Translucent_50;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(lblCategory);
            panel1.Controls.Add(lblAge);
            panel1.Controls.Add(lblExperience);
            panel1.Controls.Add(lblSkills);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(cmbCategory);
            panel1.Controls.Add(numAge);
            panel1.Controls.Add(numExperience);
            panel1.Controls.Add(txtSkills);
            panel1.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(246, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 470);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(323, 59);
            label4.Name = "label4";
            label4.Size = new Size(84, 27);
            label4.TabIndex = 13;
            label4.Text = "Profile";
            // 
            // btnBack
            // 
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Location = new Point(245, 377);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 35);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Gadugi", 10.8F, FontStyle.Bold);
            lblCategory.Location = new Point(213, 332);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(92, 21);
            lblCategory.TabIndex = 11;
            lblCategory.Text = "Category:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Gadugi", 10.8F, FontStyle.Bold);
            lblAge.Location = new Point(256, 287);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(49, 21);
            lblAge.TabIndex = 10;
            lblAge.Text = "Age:";
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Font = new Font("Gadugi", 10.8F, FontStyle.Bold);
            lblExperience.Location = new Point(197, 242);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(108, 21);
            lblExperience.TabIndex = 9;
            lblExperience.Text = "Experience:";
            // 
            // lblSkills
            // 
            lblSkills.AutoSize = true;
            lblSkills.Font = new Font("Gadugi", 10.8F, FontStyle.Bold);
            lblSkills.Location = new Point(247, 154);
            lblSkills.Name = "lblSkills";
            lblSkills.Size = new Size(58, 21);
            lblSkills.TabIndex = 8;
            lblSkills.Text = "Skills:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Gadugi", 10.8F, FontStyle.Bold);
            lblName.Location = new Point(240, 109);
            lblName.Name = "lblName";
            lblName.Size = new Size(65, 21);
            lblName.TabIndex = 7;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(323, 109);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(385, 377);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(323, 332);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(150, 27);
            cmbCategory.TabIndex = 3;
            // 
            // numAge
            // 
            numAge.Location = new Point(323, 287);
            numAge.Name = "numAge";
            numAge.Size = new Size(150, 27);
            numAge.TabIndex = 2;
            // 
            // numExperience
            // 
            numExperience.Location = new Point(323, 242);
            numExperience.Name = "numExperience";
            numExperience.Size = new Size(150, 27);
            numExperience.TabIndex = 1;
            // 
            // txtSkills
            // 
            txtSkills.Location = new Point(323, 154);
            txtSkills.Multiline = true;
            txtSkills.Name = "txtSkills";
            txtSkills.ScrollBars = ScrollBars.Vertical;
            txtSkills.Size = new Size(250, 70);
            txtSkills.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Sleek_Black_Gradient_Border_Style_PNG;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1265, 675);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // JobSeekerProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "JobSeekerProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JobSeekerProfileForm";
            Load += JobSeekerProfileForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numExperience).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSave;
        private ComboBox cmbCategory;
        private NumericUpDown numAge;
        private NumericUpDown numExperience;
        private TextBox txtSkills;
        private TextBox txtName;
        private Button btnBack;
        private Label lblCategory;
        private Label lblAge;
        private Label lblExperience;
        private Label lblSkills;
        private Label lblName;
        private Label label4;
        private PictureBox pictureBox1;
    }
}