namespace POGOY_H2___CPE262_Final_Project
{
    partial class MailSentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailSentForm));
            flpSent = new FlowLayoutPanel();
            pnlDetails = new Panel();
            panel2 = new Panel();
            lblBody = new Label();
            btnDelete = new Button();
            lblSubject = new Label();
            lblReceiver = new Label();
            lblSender = new Label();
            lblDate = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnBack = new Button();
            pnlDetails.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flpSent
            // 
            flpSent.AutoScroll = true;
            flpSent.BackColor = Color.Transparent;
            flpSent.Dock = DockStyle.Bottom;
            flpSent.FlowDirection = FlowDirection.TopDown;
            flpSent.Location = new Point(0, 63);
            flpSent.Name = "flpSent";
            flpSent.Size = new Size(320, 790);
            flpSent.TabIndex = 0;
            flpSent.WrapContents = false;
            // 
            // pnlDetails
            // 
            pnlDetails.BackColor = Color.Transparent;
            pnlDetails.Controls.Add(panel2);
            pnlDetails.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlDetails.ForeColor = Color.White;
            pnlDetails.Location = new Point(320, 0);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(1100, 853);
            pnlDetails.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Black_Translucent_50;
            panel2.Controls.Add(lblBody);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(lblSubject);
            panel2.Controls.Add(lblReceiver);
            panel2.Controls.Add(lblSender);
            panel2.Controls.Add(lblDate);
            panel2.Location = new Point(100, 100);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 653);
            panel2.TabIndex = 9;
            // 
            // lblBody
            // 
            lblBody.BorderStyle = BorderStyle.FixedSingle;
            lblBody.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBody.Location = new Point(50, 253);
            lblBody.Margin = new Padding(3);
            lblBody.Name = "lblBody";
            lblBody.Padding = new Padding(5, 10, 5, 10);
            lblBody.Size = new Size(800, 350);
            lblBody.TabIndex = 7;
            lblBody.Text = "Body";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(750, 60);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblSubject
            // 
            lblSubject.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubject.ForeColor = Color.White;
            lblSubject.Location = new Point(50, 50);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(595, 45);
            lblSubject.TabIndex = 1;
            lblSubject.Text = "Subject";
            lblSubject.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblReceiver
            // 
            lblReceiver.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReceiver.ForeColor = Color.White;
            lblReceiver.Location = new Point(50, 190);
            lblReceiver.Name = "lblReceiver";
            lblReceiver.Size = new Size(300, 25);
            lblReceiver.TabIndex = 4;
            lblReceiver.Text = "Receiver";
            lblReceiver.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSender
            // 
            lblSender.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSender.Location = new Point(50, 130);
            lblSender.Name = "lblSender";
            lblSender.Size = new Size(300, 25);
            lblSender.TabIndex = 0;
            lblSender.Text = "Sender";
            lblSender.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Gadugi", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(600, 130);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(250, 25);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date";
            lblDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(79, 2);
            label1.Name = "label1";
            label1.Size = new Size(155, 50);
            label1.TabIndex = 4;
            label1.Text = "Mail Sent";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.Black_Translucent_70;
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(flpSent);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 853);
            panel1.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBack.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Gadugi", 31.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(0, -4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(79, 70);
            btnBack.TabIndex = 5;
            btnBack.Text = "←";
            btnBack.TextAlign = ContentAlignment.TopCenter;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // MailSentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1422, 853);
            Controls.Add(panel1);
            Controls.Add(pnlDetails);
            Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MailSentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MailSentForm";
            Load += MailSentForm_Load;
            pnlDetails.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpSent;
        private Panel pnlDetails;
        private Label label1;
        private Button btnDelete;
        private Panel panel1;
        private Button btnBack;
        private Panel panel2;
        private Label lblBody;
        private Label lblSubject;
        private Label lblReceiver;
        private Label lblSender;
        private Label lblDate;
    }
}