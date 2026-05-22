using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace POGOY_H2___CPE262_Final_Project
{
    public partial class ChatForm : Form
    {
        int currentChatUserId = 0;

        public ChatForm()
        {
            InitializeComponent();
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            LoadChatUsers();
            panelMain.Hide();
        }

        private void LoadChatUsers()
        {
            flpUsers.Controls.Clear();
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = @"SELECT U.[UserID], U.[Name], U.[Role], MAX(C.[DateSent]) AS LastDate FROM [Users] AS U
                    INNER JOIN [Chats] AS C ON (U.[UserID] = C.[SenderID] OR U.[UserID] = C.[ReceiverID])
                    WHERE (C.[SenderID] = ? OR C.[ReceiverID] = ?) AND U.[UserID] <> ?
                    GROUP BY U.[UserID], U.[Name], U.[Role]
                    ORDER BY MAX(C.[DateSent]) DESC";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", Session.UserID);
                cmd.Parameters.AddWithValue("?", Session.UserID);
                cmd.Parameters.AddWithValue("?", Session.UserID);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ChatItem item = new ChatItem(
                        Convert.ToInt32(reader["UserID"]),
                        reader["Name"].ToString(),
                        reader["Role"].ToString()
                    );
                    item.ChatClicked += ChatItem_Clicked;
                    flpUsers.Controls.Add(item);
                }
            }
        }

        private void ChatItem_Clicked(object sender, EventArgs e)
        {
            ChatItem item = (ChatItem)sender;
            currentChatUserId = item.UserID;
            lblChatName.Text = item.UserName;
            panelMain.Show();
            LoadMessages();
        }

        private void LoadMessages()
        {
            flpMessages.Controls.Clear();
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = @"SELECT * FROM Chats WHERE (SenderID = ? AND ReceiverID = ?) OR (SenderID = ? AND ReceiverID = ?) ORDER BY DateSent ASC";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", Session.UserID);
                cmd.Parameters.AddWithValue("?", currentChatUserId);
                cmd.Parameters.AddWithValue("?", currentChatUserId);
                cmd.Parameters.AddWithValue("?", Session.UserID);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bool isMe = Convert.ToInt32(reader["SenderID"]) == Session.UserID;
                    bool delivered = reader["IsDelivered"] != DBNull.Value && (bool)reader["IsDelivered"];
                    bool seen = reader["IsSeen"] != DBNull.Value && (bool)reader["IsSeen"];
                    DateTime date = Convert.ToDateTime(reader["DateSent"]);
                    string msg = reader["Message"].ToString();
                    Panel msgPanel = new Panel();
                    msgPanel.AutoSize = false;
                    msgPanel.Width = Math.Max(200, flpMessages.ClientSize.Width - 50);
                    FlowLayoutPanel inner = new FlowLayoutPanel();
                    inner.FlowDirection = FlowDirection.TopDown;
                    inner.WrapContents = false;
                    inner.AutoSize = true;
                    Label bubble = new Label();
                    bubble.Text = msg;
                    bubble.AutoSize = true;
                    bubble.MaximumSize = new Size(450, 0);
                    bubble.Padding = new Padding(10);
                    bubble.Margin = new Padding(0, 0, 0, 3);
                    FlowLayoutPanel metaRow = new FlowLayoutPanel();
                    metaRow.AutoSize = true;
                    metaRow.FlowDirection = FlowDirection.LeftToRight;
                    metaRow.WrapContents = false;
                    Label lblDate = new Label();
                    lblDate.Text = date.ToString("hh:mm tt");
                    lblDate.Font = new Font("Gadugi", 7);
                    lblDate.ForeColor = Color.White;
                    lblDate.AutoSize = true;
                    lblDate.Margin = new Padding(0, 0, 8, 0);
                    Label status = new Label();
                    status.AutoSize = true;
                    status.Font = new Font("Gadugi", 7);
                    status.ForeColor = Color.White;
                    if (isMe)
                    {
                        bubble.BackColor = Color.LightGray;
                        bubble.TextAlign = ContentAlignment.MiddleRight;
                        bubble.Dock = DockStyle.Right;
                        if (seen) status.Text = "Seen";
                        else if (delivered) status.Text = "Delivered";
                        else status.Text = "Sent";
                        metaRow.Controls.Add(status);
                        metaRow.Controls.Add(lblDate);
                        metaRow.Dock = DockStyle.Right;
                        inner.Controls.Add(bubble);
                        inner.Controls.Add(metaRow);
                        msgPanel.Controls.Add(inner);
                        inner.Location = new Point(msgPanel.Width - inner.PreferredSize.Width - 10, 0);
                        msgPanel.Height = inner.PreferredSize.Height;
                    }
                    else
                    {
                        bubble.BackColor = Color.Black;
                        bubble.ForeColor = Color.White;
                        bubble.TextAlign = ContentAlignment.MiddleLeft;
                        metaRow.Controls.Add(lblDate);
                        inner.Controls.Add(bubble);
                        inner.Controls.Add(metaRow);
                        msgPanel.Controls.Add(inner);
                        inner.Location = new Point(40, 0);
                        msgPanel.Height = inner.PreferredSize.Height;
                    }
                    flpMessages.Controls.Add(msgPanel);
                }
            }

            if (flpMessages.Controls.Count == 0)
            {
                var placeholder = new Label
                {
                    Text = "No messages yet",
                    AutoSize = true,
                    ForeColor = Color.White,
                    Margin = new Padding(10)
                };
                flpMessages.Controls.Add(placeholder);
            }
            else flpMessages.ScrollControlIntoView(flpMessages.Controls[flpMessages.Controls.Count - 1]);    
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMessage.Text) || currentChatUserId == 0) return;
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = @"INSERT INTO Chats (SenderID, ReceiverID, Message, DateSent, IsDelivered, IsSeen) VALUES (?, ?, ?, ?, ?, ?)";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", Session.UserID);
                cmd.Parameters.AddWithValue("?", currentChatUserId);
                cmd.Parameters.AddWithValue("?", txtMessage.Text);
                cmd.Parameters.Add("DateSent", OleDbType.Date).Value = DateTime.Now;
                cmd.Parameters.AddWithValue("?", false);
                cmd.Parameters.AddWithValue("?", false);
                cmd.ExecuteNonQuery();
            }
            txtMessage.Clear();
            MarkAsDelivered();
            MarkAsSeen();
            LoadMessages();
            LoadChatUsers();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text)) LoadChatUsers();
            else SearchUsers(txtSearch.Text);          
        }

        private void SearchUsers(string keyword)
        {
            flpUsers.Controls.Clear();
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = @"SELECT UserID, Name, Role FROM Users WHERE (Name LIKE ? OR Role LIKE ?) AND UserID <> ?";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", "%" + keyword + "%");
                cmd.Parameters.AddWithValue("?", "%" + keyword + "%");
                cmd.Parameters.AddWithValue("?", Session.UserID);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ChatItem item = new ChatItem(
                        Convert.ToInt32(reader["UserID"]),
                        reader["Name"].ToString(),
                        reader["Role"].ToString()
                    );
                    item.ChatClicked += ChatItem_Clicked;
                    flpUsers.Controls.Add(item);
                }
            }
        }

        private void MarkAsDelivered()
        {
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = @"UPDATE Chats SET IsDelivered = true WHERE ReceiverID = ? AND SenderID = ? AND IsDelivered = false";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", Session.UserID);
                cmd.Parameters.AddWithValue("?", currentChatUserId);
                cmd.ExecuteNonQuery();
            }
        }

        private void MarkAsSeen()
        {
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = @"UPDATE Chats SET IsSeen = true WHERE ReceiverID = ? AND SenderID = ? AND IsSeen = false";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", Session.UserID);
                cmd.Parameters.AddWithValue("?", currentChatUserId);
                cmd.ExecuteNonQuery();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
