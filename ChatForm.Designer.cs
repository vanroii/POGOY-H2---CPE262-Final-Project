namespace POGOY_H2___CPE262_Final_Project
{
    partial class ChatForm
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
            panel1 = new Panel();
            txtSearch = new TextBox();
            flpUsers = new FlowLayoutPanel();
            panel2 = new Panel();
            btnSend = new Button();
            txtMessage = new TextBox();
            flpMessages = new FlowLayoutPanel();
            panel3 = new Panel();
            lblChatName = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(flpUsers);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 853);
            panel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(54, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(247, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // flpUsers
            // 
            flpUsers.AutoScroll = true;
            flpUsers.FlowDirection = FlowDirection.TopDown;
            flpUsers.Location = new Point(0, 75);
            flpUsers.Name = "flpUsers";
            flpUsers.Size = new Size(320, 778);
            flpUsers.TabIndex = 0;
            flpUsers.WrapContents = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(btnSend);
            panel2.Controls.Add(txtMessage);
            panel2.Controls.Add(flpMessages);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(320, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1102, 853);
            panel2.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(979, 795);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 3;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(32, 797);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(907, 27);
            txtMessage.TabIndex = 2;
            // 
            // flpMessages
            // 
            flpMessages.AutoScroll = true;
            flpMessages.FlowDirection = FlowDirection.TopDown;
            flpMessages.Location = new Point(0, 68);
            flpMessages.Name = "flpMessages";
            flpMessages.Size = new Size(1102, 700);
            flpMessages.TabIndex = 1;
            flpMessages.WrapContents = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(lblChatName);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1102, 69);
            panel3.TabIndex = 0;
            // 
            // lblChatName
            // 
            lblChatName.BackColor = Color.Transparent;
            lblChatName.Font = new Font("Gadugi", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChatName.Location = new Point(32, 0);
            lblChatName.Name = "lblChatName";
            lblChatName.Size = new Size(936, 69);
            lblChatName.TabIndex = 0;
            lblChatName.Text = "label1";
            lblChatName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 853);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ChatForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChatForm";
            Load += ChatForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtSearch;
        private FlowLayoutPanel flpUsers;
        private Panel panel2;
        private FlowLayoutPanel flpMessages;
        private Panel panel3;
        private Label lblChatName;
        private Button btnSend;
        private TextBox txtMessage;
        private Label label1;
    }
}