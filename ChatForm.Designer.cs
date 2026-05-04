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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            panelSide = new Panel();
            txtSearch = new TextBox();
            flpUsers = new FlowLayoutPanel();
            btnBack = new Button();
            panelMain = new Panel();
            txtMessage = new TextBox();
            flpMessages = new FlowLayoutPanel();
            panel3 = new Panel();
            lblChatName = new Label();
            btnSend = new Button();
            panelSide.SuspendLayout();
            panelMain.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelSide
            // 
            panelSide.BackColor = Color.Transparent;
            panelSide.BackgroundImage = Properties.Resources.Black_Translucent_50;
            panelSide.Controls.Add(txtSearch);
            panelSide.Controls.Add(flpUsers);
            panelSide.Controls.Add(btnBack);
            panelSide.Dock = DockStyle.Left;
            panelSide.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelSide.Location = new Point(0, 0);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(320, 853);
            panelSide.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(72, 23);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(223, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // flpUsers
            // 
            flpUsers.AutoScroll = true;
            flpUsers.Dock = DockStyle.Bottom;
            flpUsers.FlowDirection = FlowDirection.TopDown;
            flpUsers.Location = new Point(0, 70);
            flpUsers.Name = "flpUsers";
            flpUsers.Size = new Size(320, 783);
            flpUsers.TabIndex = 0;
            flpUsers.WrapContents = false;
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
            btnBack.TabIndex = 2;
            btnBack.Text = "←";
            btnBack.TextAlign = ContentAlignment.TopCenter;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.Transparent;
            panelMain.Controls.Add(txtMessage);
            panelMain.Controls.Add(flpMessages);
            panelMain.Controls.Add(panel3);
            panelMain.Controls.Add(btnSend);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(320, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1102, 853);
            panelMain.TabIndex = 1;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(40, 797);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(946, 27);
            txtMessage.TabIndex = 2;
            // 
            // flpMessages
            // 
            flpMessages.AutoScroll = true;
            flpMessages.BackColor = Color.Transparent;
            flpMessages.Dock = DockStyle.Top;
            flpMessages.FlowDirection = FlowDirection.TopDown;
            flpMessages.Location = new Point(0, 70);
            flpMessages.Name = "flpMessages";
            flpMessages.Size = new Size(1102, 700);
            flpMessages.TabIndex = 1;
            flpMessages.WrapContents = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.black_70pct_transparent;
            panel3.Controls.Add(lblChatName);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1102, 70);
            panel3.TabIndex = 0;
            // 
            // lblChatName
            // 
            lblChatName.BackColor = Color.Transparent;
            lblChatName.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChatName.ForeColor = Color.White;
            lblChatName.Location = new Point(40, 0);
            lblChatName.Name = "lblChatName";
            lblChatName.Size = new Size(1035, 70);
            lblChatName.TabIndex = 0;
            lblChatName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSend
            // 
            btnSend.Cursor = Cursors.Hand;
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSend.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Gadugi", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(987, 779);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(83, 65);
            btnSend.TabIndex = 3;
            btnSend.Text = "➤";
            btnSend.TextAlign = ContentAlignment.TopCenter;
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1422, 853);
            Controls.Add(panelMain);
            Controls.Add(panelSide);
            Name = "ChatForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChatForm";
            Load += ChatForm_Load;
            panelSide.ResumeLayout(false);
            panelSide.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSide;
        private TextBox txtSearch;
        private FlowLayoutPanel flpUsers;
        private Panel panelMain;
        private FlowLayoutPanel flpMessages;
        private Panel panel3;
        private Label lblChatName;
        private Button btnSend;
        private TextBox txtMessage;
        private Label label1;
        private Button btnBack;
    }
}