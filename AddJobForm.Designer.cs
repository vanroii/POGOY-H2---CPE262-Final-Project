namespace POGOY_H2___CPE262_Final_Project
{
    partial class AddJobForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddJobForm));
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            txtLocation = new TextBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            numAgeMax = new NumericUpDown();
            numAgeMin = new NumericUpDown();
            numExperience = new NumericUpDown();
            txtSkills = new TextBox();
            cmbCategory = new ComboBox();
            label4 = new Label();
            btnCancel = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAgeMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAgeMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numExperience).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.White;
            txtTitle.ForeColor = Color.Black;
            txtTitle.Location = new Point(230, 105);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(335, 27);
            txtTitle.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.ForeColor = Color.Black;
            txtDescription.Location = new Point(230, 150);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(670, 135);
            txtDescription.TabIndex = 1;
            // 
            // txtLocation
            // 
            txtLocation.BackColor = Color.White;
            txtLocation.ForeColor = Color.Black;
            txtLocation.Location = new Point(230, 438);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(434, 27);
            txtLocation.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Gadugi", 9F);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(800, 438);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 27);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gadugi", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(159, 105);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 5;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gadugi", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(100, 150);
            label2.Name = "label2";
            label2.Size = new Size(112, 21);
            label2.TabIndex = 6;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Gadugi", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(124, 438);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 7;
            label3.Text = "Location:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.Black_Translucent_50;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(numAgeMax);
            panel1.Controls.Add(numAgeMin);
            panel1.Controls.Add(numExperience);
            panel1.Controls.Add(txtSkills);
            panel1.Controls.Add(cmbCategory);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtLocation);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTitle);
            panel1.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(131, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 540);
            panel1.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Gadugi", 10.8F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(595, 393);
            label9.Name = "label9";
            label9.Size = new Size(139, 21);
            label9.TabIndex = 19;
            label9.Text = "Maximum Age:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Gadugi", 10.8F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(599, 348);
            label8.Name = "label8";
            label8.Size = new Size(135, 21);
            label8.TabIndex = 18;
            label8.Text = "Minimum Age:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Gadugi", 10.8F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(583, 303);
            label7.Name = "label7";
            label7.Size = new Size(151, 21);
            label7.TabIndex = 17;
            label7.Text = "Year Experience:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Gadugi", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(72, 303);
            label6.Name = "label6";
            label6.Size = new Size(140, 21);
            label6.TabIndex = 16;
            label6.Text = "Skills Required:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Gadugi", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(583, 105);
            label5.Name = "label5";
            label5.Size = new Size(92, 21);
            label5.TabIndex = 15;
            label5.Text = "Category:";
            // 
            // numAgeMax
            // 
            numAgeMax.Location = new Point(752, 393);
            numAgeMax.Name = "numAgeMax";
            numAgeMax.Size = new Size(147, 27);
            numAgeMax.TabIndex = 14;
            // 
            // numAgeMin
            // 
            numAgeMin.Location = new Point(752, 348);
            numAgeMin.Name = "numAgeMin";
            numAgeMin.Size = new Size(148, 27);
            numAgeMin.TabIndex = 13;
            // 
            // numExperience
            // 
            numExperience.Location = new Point(752, 303);
            numExperience.Name = "numExperience";
            numExperience.Size = new Size(147, 27);
            numExperience.TabIndex = 12;
            // 
            // txtSkills
            // 
            txtSkills.Location = new Point(230, 303);
            txtSkills.Multiline = true;
            txtSkills.Name = "txtSkills";
            txtSkills.Size = new Size(335, 117);
            txtSkills.TabIndex = 11;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "IT", "Sales", "Service", "Construction", "Creative", "Office", "Healthcare", "Education", "Engineering", "Logistics" });
            cmbCategory.Location = new Point(693, 105);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(206, 27);
            cmbCategory.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(112, 54);
            label4.Name = "label4";
            label4.Size = new Size(100, 27);
            label4.TabIndex = 9;
            label4.Text = "Add Job";
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Gadugi", 9F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(682, 438);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 27);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Sleek_Black_Gradient_Border_Style_PNG;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1265, 675);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // AddJobForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "AddJobForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddJobForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAgeMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAgeMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numExperience).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtDescription;
        private TextBox txtLocation;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Button btnCancel;
        private Label label4;
        private PictureBox pictureBox1;
        private ComboBox cmbCategory;
        private TextBox txtSkills;
        private NumericUpDown numExperience;
        private NumericUpDown numAgeMax;
        private NumericUpDown numAgeMin;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}