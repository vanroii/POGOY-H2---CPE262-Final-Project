namespace POGOY_H2___CPE262_Final_Project
{
    partial class SendMailForm
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
            txtSubject = new TextBox();
            txtBody = new TextBox();
            panel1 = new Panel();
            btnSend = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(99, 62);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(409, 27);
            txtSubject.TabIndex = 0;
            // 
            // txtBody
            // 
            txtBody.Location = new Point(99, 116);
            txtBody.Multiline = true;
            txtBody.Name = "txtBody";
            txtBody.Size = new Size(653, 337);
            txtBody.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnSend);
            panel1.Controls.Add(txtBody);
            panel1.Controls.Add(txtSubject);
            panel1.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(199, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(936, 581);
            panel1.TabIndex = 2;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(658, 477);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // SendMailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel1);
            Name = "SendMailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SendMailForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtSubject;
        private TextBox txtBody;
        private Panel panel1;
        private Button btnSend;
    }
}