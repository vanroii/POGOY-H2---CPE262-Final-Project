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

namespace POGOY_H2___CPE262_Final_Project
{
    public partial class MailInboxForm : Form
    {
        public MailInboxForm()
        {
            InitializeComponent();
        }

        private void MailInboxForm_Load(object sender, EventArgs e)
        {
            LoadInbox();

            pnlDetails.Hide();
        }

        private void LoadInbox()
        {
            flpInbox.Controls.Clear();

            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = @"SELECT U.Name AS Sender, M.Subject, M.Body, M.DateSent FROM Mails M
                                INNER JOIN Users U ON M.SenderID = U.UserID
                                WHERE M.ReceiverID = ?
                                ORDER BY M.DateSent DESC";

                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", Session.UserID);
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MailItem item = new MailItem(
                        reader["Sender"].ToString(),
                        reader["Subject"].ToString(),
                        reader["Body"].ToString(),
                        Convert.ToDateTime(reader["DateSent"])
                    );

                    item.MailClicked += MailItem_Clicked;
                    flpInbox.Controls.Add(item);
                }
            }
        }

        private void MailItem_Clicked(object sender, EventArgs e)
        {
            pnlDetails.Show();

            MailItem item = (MailItem)sender;
            lblSender.Text = "From: " + item.Sender;
            lblReceiver.Text = "To: " + Session.UserName;
            lblSubject.Text = item.Subject;
            lblDate.Text = item.DateSent.ToString("MMMM dd, yyyy hh:mm tt");
            txtBody.Text = item.Body;
        }
    }
}
