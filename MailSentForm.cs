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
    public partial class MailSentForm : Form
    {
        int selectedMailId = 0;

        public MailSentForm()
        {
            InitializeComponent();
        }

        private void MailSentForm_Load(object sender, EventArgs e)
        {
            LoadSentMails();
            pnlDetails.Hide();
        }

        private void LoadSentMails()
        {
            flpSent.Controls.Clear();
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = @"SELECT U.Name AS Receiver, M.Subject, M.Body, M.DateSent, M.MailID FROM Mails M INNER JOIN Users U ON M.ReceiverID = U.UserID WHERE M.SenderID = ? ORDER BY M.DateSent DESC";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", Session.UserID);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MailItem item = new MailItem(
                        reader["Receiver"].ToString(),
                        reader["Subject"].ToString(),
                        reader["Body"].ToString(),
                        Convert.ToDateTime(reader["DateSent"])
                    );
                    item.Tag = reader["MailID"];
                    item.MailClicked += SentMail_Clicked;
                    flpSent.Controls.Add(item);
                }
            }
        }

        private void SentMail_Clicked(object sender, EventArgs e)
        {
            pnlDetails.Show();
            MailItem item = (MailItem)sender;
            lblSender.Text = "From: " + Session.UserName;
            lblReceiver.Text = "To: " + item.Sender;
            lblSubject.Text = item.Subject;
            lblDate.Text = item.DateSent.ToString("MMMM dd, yyyy hh:mm tt");
            lblBody.Text = item.Body;
            selectedMailId = Convert.ToInt32(item.Tag);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMailId == 0)
            {
                MessageBox.Show("Select a mail first.");
                return;
            }
            DialogResult result = MessageBox.Show("Delete this mail?","Confirm",MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = "DELETE FROM Mails WHERE MailID = ?";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", selectedMailId);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Mail deleted!");
            selectedMailId = 0;
            lblBody.Text = "";
            lblSubject.Text = "";
            lblSender.Text = "";
            lblReceiver.Text = "";
            lblDate.Text = "";
            pnlDetails.Hide();
            LoadSentMails();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
