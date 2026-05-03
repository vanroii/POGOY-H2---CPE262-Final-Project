namespace POGOY_H2___CPE262_Final_Project
{
    partial class MailInboxForm
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
            flpInbox = new FlowLayoutPanel();
            pnlDetails = new Panel();
            lblReceiver = new Label();
            txtBody = new TextBox();
            lblDate = new Label();
            lblSubject = new Label();
            lblSender = new Label();
            label1 = new Label();
            pnlDetails.SuspendLayout();
            SuspendLayout();
            // 
            // flpInbox
            // 
            flpInbox.AutoScroll = true;
            flpInbox.BackColor = Color.Transparent;
            flpInbox.FlowDirection = FlowDirection.TopDown;
            flpInbox.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flpInbox.Location = new Point(0, 53);
            flpInbox.Name = "flpInbox";
            flpInbox.Size = new Size(320, 800);
            flpInbox.TabIndex = 0;
            flpInbox.WrapContents = false;
            // 
            // pnlDetails
            // 
            pnlDetails.BackColor = SystemColors.ControlLight;
            pnlDetails.Controls.Add(lblReceiver);
            pnlDetails.Controls.Add(txtBody);
            pnlDetails.Controls.Add(lblDate);
            pnlDetails.Controls.Add(lblSubject);
            pnlDetails.Controls.Add(lblSender);
            pnlDetails.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlDetails.Location = new Point(320, 0);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(1100, 853);
            pnlDetails.TabIndex = 1;
            // 
            // lblReceiver
            // 
            lblReceiver.Location = new Point(454, 33);
            lblReceiver.Name = "lblReceiver";
            lblReceiver.Size = new Size(247, 25);
            lblReceiver.TabIndex = 4;
            lblReceiver.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBody
            // 
            txtBody.BorderStyle = BorderStyle.None;
            txtBody.Location = new Point(62, 118);
            txtBody.Multiline = true;
            txtBody.Name = "txtBody";
            txtBody.ReadOnly = true;
            txtBody.Size = new Size(996, 258);
            txtBody.TabIndex = 3;
            // 
            // lblDate
            // 
            lblDate.Location = new Point(811, 33);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(247, 25);
            lblDate.TabIndex = 2;
            lblDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSubject
            // 
            lblSubject.Location = new Point(62, 75);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(247, 25);
            lblSubject.TabIndex = 1;
            lblSubject.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSender
            // 
            lblSender.Location = new Point(62, 33);
            lblSender.Name = "lblSender";
            lblSender.Size = new Size(247, 25);
            lblSender.TabIndex = 0;
            lblSender.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gadugi", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(320, 50);
            label1.TabIndex = 0;
            label1.Text = "     Mail Inbox";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MailInboxForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 853);
            Controls.Add(label1);
            Controls.Add(pnlDetails);
            Controls.Add(flpInbox);
            Name = "MailInboxForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MailInboxForm";
            Load += MailInboxForm_Load;
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpInbox;
        private Panel pnlDetails;
        private TextBox txtBody;
        private Label lblDate;
        private Label lblSubject;
        private Label lblSender;
        private Label label1;
        private Label lblReceiver;
    }
}