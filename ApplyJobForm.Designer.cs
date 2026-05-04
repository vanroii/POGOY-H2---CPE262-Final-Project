namespace POGOY_H2___CPE262_Final_Project
{
    partial class ApplyJobForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyJobForm));
            panel1 = new Panel();
            label2 = new Label();
            lblReferralLetterPath = new Label();
            btnBrowseReferralLetter = new Button();
            label1 = new Label();
            btnCancel = new Button();
            lblFilePath = new Label();
            btnSubmit = new Button();
            btnUploadResume = new Button();
            lblJobTitle = new Label();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.Black_Translucent_70;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblReferralLetterPath);
            panel1.Controls.Add(btnBrowseReferralLetter);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(lblFilePath);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(btnUploadResume);
            panel1.Controls.Add(lblJobTitle);
            panel1.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(242, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 420);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 214);
            label2.Name = "label2";
            label2.Size = new Size(270, 21);
            label2.TabIndex = 8;
            label2.Text = "Upload Referral Letter (Optional):";
            // 
            // lblReferralLetterPath
            // 
            lblReferralLetterPath.Cursor = Cursors.Hand;
            lblReferralLetterPath.Location = new Point(180, 258);
            lblReferralLetterPath.Name = "lblReferralLetterPath";
            lblReferralLetterPath.Size = new Size(530, 30);
            lblReferralLetterPath.TabIndex = 7;
            lblReferralLetterPath.Text = "No file uploaded.";
            lblReferralLetterPath.TextAlign = ContentAlignment.MiddleLeft;
            lblReferralLetterPath.Click += lblReferralLetterPath_Click;
            // 
            // btnBrowseReferralLetter
            // 
            btnBrowseReferralLetter.BackColor = Color.White;
            btnBrowseReferralLetter.Cursor = Cursors.Hand;
            btnBrowseReferralLetter.FlatStyle = FlatStyle.Flat;
            btnBrowseReferralLetter.Font = new Font("Gadugi", 10F);
            btnBrowseReferralLetter.ForeColor = Color.Black;
            btnBrowseReferralLetter.Location = new Point(70, 258);
            btnBrowseReferralLetter.Name = "btnBrowseReferralLetter";
            btnBrowseReferralLetter.Size = new Size(100, 30);
            btnBrowseReferralLetter.TabIndex = 6;
            btnBrowseReferralLetter.Text = "Browse";
            btnBrowseReferralLetter.UseVisualStyleBackColor = false;
            btnBrowseReferralLetter.Click += btnBrowseReferralLetter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 113);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 5;
            label1.Text = "Upload Resume:";
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Gadugi", 9.5F);
            btnCancel.Location = new Point(270, 332);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblFilePath
            // 
            lblFilePath.Cursor = Cursors.Hand;
            lblFilePath.Location = new Point(180, 157);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(530, 30);
            lblFilePath.TabIndex = 3;
            lblFilePath.Text = "No file uploaded.";
            lblFilePath.TextAlign = ContentAlignment.MiddleLeft;
            lblFilePath.Click += lblFilePath_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.White;
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Gadugi", 9.5F);
            btnSubmit.ForeColor = Color.Black;
            btnSubmit.Location = new Point(410, 332);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(100, 35);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnUploadResume
            // 
            btnUploadResume.BackColor = Color.White;
            btnUploadResume.Cursor = Cursors.Hand;
            btnUploadResume.FlatStyle = FlatStyle.Flat;
            btnUploadResume.Font = new Font("Gadugi", 10F);
            btnUploadResume.ForeColor = Color.Black;
            btnUploadResume.Location = new Point(70, 157);
            btnUploadResume.Name = "btnUploadResume";
            btnUploadResume.Size = new Size(100, 30);
            btnUploadResume.TabIndex = 1;
            btnUploadResume.Text = "Browse";
            btnUploadResume.UseVisualStyleBackColor = false;
            btnUploadResume.Click += btnUploadResume_Click;
            // 
            // lblJobTitle
            // 
            lblJobTitle.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJobTitle.Location = new Point(70, 53);
            lblJobTitle.Name = "lblJobTitle";
            lblJobTitle.Size = new Size(640, 40);
            lblJobTitle.TabIndex = 0;
            lblJobTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.Black_Translucent_50;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1265, 675);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Sleek_Black_Gradient_Border_Style_PNG;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1265, 675);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // ApplyJobForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel2);
            Name = "ApplyJobForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ApplyJobForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblFilePath;
        private Button btnSubmit;
        private Button btnUploadResume;
        private Label lblJobTitle;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Button btnCancel;
        private Label label2;
        private Label lblReferralLetterPath;
        private Button btnBrowseReferralLetter;
        private OpenFileDialog openFileDialog2;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}