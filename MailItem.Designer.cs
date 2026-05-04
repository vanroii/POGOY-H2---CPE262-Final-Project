namespace POGOY_H2___CPE262_Final_Project
{
    partial class MailItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSubject = new Label();
            lblSender = new Label();
            lblDate = new Label();
            lblPreview = new Label();
            SuspendLayout();
            // 
            // lblSubject
            // 
            lblSubject.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubject.Location = new Point(15, 11);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(195, 24);
            lblSubject.TabIndex = 0;
            lblSubject.Text = "Subject";
            lblSubject.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSender
            // 
            lblSender.Location = new Point(15, 35);
            lblSender.Name = "lblSender";
            lblSender.Size = new Size(269, 24);
            lblSender.TabIndex = 2;
            lblSender.Text = "Sender";
            lblSender.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            lblDate.Location = new Point(210, 11);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(74, 24);
            lblDate.TabIndex = 3;
            lblDate.Text = "Date";
            lblDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPreview
            // 
            lblPreview.Font = new Font("Gadugi", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPreview.Location = new Point(14, 59);
            lblPreview.Margin = new Padding(0);
            lblPreview.Name = "lblPreview";
            lblPreview.Size = new Size(270, 24);
            lblPreview.TabIndex = 4;
            lblPreview.Text = "Subject";
            lblPreview.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MailItem
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.black_70pct_transparent;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblPreview);
            Controls.Add(lblDate);
            Controls.Add(lblSender);
            Controls.Add(lblSubject);
            Cursor = Cursors.Hand;
            Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Name = "MailItem";
            Size = new Size(310, 90);
            ResumeLayout(false);
        }

        #endregion

        private Label lblSubject;
        private Label lblSender;
        private Label lblDate;
        private Label lblPreview;
    }
}
