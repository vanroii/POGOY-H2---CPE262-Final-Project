namespace POGOY_H2___CPE262_Final_Project
{
    partial class ChatItem
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
            lblName = new Label();
            lblRole = new Label();
            lblUserID = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(15, 13);
            lblName.Name = "lblName";
            lblName.Size = new Size(270, 25);
            lblName.TabIndex = 0;
            lblName.Text = "label1";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRole
            // 
            lblRole.Location = new Point(15, 38);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(159, 25);
            lblRole.TabIndex = 1;
            lblRole.Text = "label1";
            lblRole.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUserID
            // 
            lblUserID.Location = new Point(180, 38);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(105, 25);
            lblUserID.TabIndex = 2;
            lblUserID.Text = "label1";
            lblUserID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ChatItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblUserID);
            Controls.Add(lblRole);
            Controls.Add(lblName);
            Name = "ChatItem";
            Size = new Size(298, 76);
            ResumeLayout(false);
        }

        #endregion

        private Label lblName;
        private Label lblRole;
        private Label lblUserID;
    }
}
