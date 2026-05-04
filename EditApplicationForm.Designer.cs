namespace POGOY_H2___CPE262_Final_Project
{
    partial class EditApplicationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditApplicationForm));
            panel1 = new Panel();
            lblReferralLetterPath = new Label();
            label3 = new Label();
            btnBrowseReferralLetter = new Button();
            lblFilePath2 = new Label();
            label5 = new Label();
            lblResumePath = new Label();
            label1 = new Label();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnUpload = new Button();
            lblFilePath = new Label();
            lblCurrentResume = new Label();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.Black_Translucent_70;
            panel1.Controls.Add(lblReferralLetterPath);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnBrowseReferralLetter);
            panel1.Controls.Add(lblFilePath2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblResumePath);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnUpload);
            panel1.Controls.Add(lblFilePath);
            panel1.Controls.Add(lblCurrentResume);
            panel1.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(196, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(872, 521);
            panel1.TabIndex = 0;
            // 
            // lblReferralLetterPath
            // 
            lblReferralLetterPath.Cursor = Cursors.Hand;
            lblReferralLetterPath.Location = new Point(180, 392);
            lblReferralLetterPath.Name = "lblReferralLetterPath";
            lblReferralLetterPath.Size = new Size(390, 30);
            lblReferralLetterPath.TabIndex = 11;
            lblReferralLetterPath.Text = "No file uploaded.";
            lblReferralLetterPath.TextAlign = ContentAlignment.MiddleLeft;
            lblReferralLetterPath.Click += lblReferralLetterPath_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 353);
            label3.Name = "label3";
            label3.Size = new Size(226, 21);
            label3.TabIndex = 10;
            label3.Text = "Upload New Referral Letter:";
            // 
            // btnBrowseReferralLetter
            // 
            btnBrowseReferralLetter.BackColor = Color.White;
            btnBrowseReferralLetter.Cursor = Cursors.Hand;
            btnBrowseReferralLetter.FlatStyle = FlatStyle.Flat;
            btnBrowseReferralLetter.Font = new Font("Gadugi", 10F);
            btnBrowseReferralLetter.ForeColor = Color.Black;
            btnBrowseReferralLetter.Location = new Point(70, 392);
            btnBrowseReferralLetter.Name = "btnBrowseReferralLetter";
            btnBrowseReferralLetter.Size = new Size(100, 30);
            btnBrowseReferralLetter.TabIndex = 9;
            btnBrowseReferralLetter.Text = "Browse";
            btnBrowseReferralLetter.UseVisualStyleBackColor = false;
            btnBrowseReferralLetter.Click += btnBrowseReferralLetter_Click;
            // 
            // lblFilePath2
            // 
            lblFilePath2.Cursor = Cursors.Hand;
            lblFilePath2.Location = new Point(70, 293);
            lblFilePath2.Name = "lblFilePath2";
            lblFilePath2.Size = new Size(500, 30);
            lblFilePath2.TabIndex = 8;
            lblFilePath2.TextAlign = ContentAlignment.MiddleLeft;
            lblFilePath2.Click += lblFilePath2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 258);
            label5.Name = "label5";
            label5.Size = new Size(186, 21);
            label5.TabIndex = 7;
            label5.Text = "Current Referral Letter:";
            // 
            // lblResumePath
            // 
            lblResumePath.Cursor = Cursors.Hand;
            lblResumePath.Location = new Point(180, 189);
            lblResumePath.Name = "lblResumePath";
            lblResumePath.Size = new Size(390, 30);
            lblResumePath.TabIndex = 6;
            lblResumePath.Text = "No file uploaded.";
            lblResumePath.TextAlign = ContentAlignment.MiddleLeft;
            lblResumePath.Click += lblResumePath_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 150);
            label1.Name = "label1";
            label1.Size = new Size(180, 21);
            label1.TabIndex = 5;
            label1.Text = "Upload New Resume:";
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Gadugi", 9.5F);
            btnCancel.Location = new Point(276, 444);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Gadugi", 9.5F);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(416, 444);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(180, 35);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update Application";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.White;
            btnUpload.Cursor = Cursors.Hand;
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Font = new Font("Gadugi", 10F);
            btnUpload.ForeColor = Color.Black;
            btnUpload.Location = new Point(70, 189);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(100, 30);
            btnUpload.TabIndex = 2;
            btnUpload.Text = "Browse";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // lblFilePath
            // 
            lblFilePath.Cursor = Cursors.Hand;
            lblFilePath.Location = new Point(70, 90);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(500, 30);
            lblFilePath.TabIndex = 1;
            lblFilePath.TextAlign = ContentAlignment.MiddleLeft;
            lblFilePath.Click += lblFilePath_Click;
            // 
            // lblCurrentResume
            // 
            lblCurrentResume.AutoSize = true;
            lblCurrentResume.Location = new Point(70, 55);
            lblCurrentResume.Name = "lblCurrentResume";
            lblCurrentResume.Size = new Size(140, 21);
            lblCurrentResume.TabIndex = 0;
            lblCurrentResume.Text = "Current Resume:";
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
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(-1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1265, 675);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1265, 675);
            panel3.TabIndex = 1;
            // 
            // EditApplicationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel2);
            Name = "EditApplicationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditApplicationForm";
            Load += EditApplicationForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnUpload;
        private Label lblFilePath;
        private Label lblCurrentResume;
        private Button btnCancel;
        private Button btnUpdate;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Label lblResumePath;
        private Label lblReferralLetterPath;
        private Label label3;
        private Button btnBrowseReferralLetter;
        private Label lblFilePath2;
        private Label label5;
        private OpenFileDialog openFileDialog2;
        private Panel panel2;
        private Panel panel3;
    }
}