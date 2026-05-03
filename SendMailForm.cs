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
    public partial class SendMailForm : Form
    {
        int senderId, receiverId;

        public SendMailForm(int sender, int receiver)
        {
            InitializeComponent();
            senderId = sender;
            receiverId = receiver;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = @"
            INSERT INTO Mails
            (SenderID, ReceiverID, Subject, Body, DateSent)
            VALUES (?, ?, ?, ?, ?)";

                OleDbCommand cmd = new OleDbCommand(query, con);

                cmd.Parameters.AddWithValue("?", senderId);
                cmd.Parameters.AddWithValue("?", receiverId);
                cmd.Parameters.AddWithValue("?", txtSubject.Text);
                cmd.Parameters.AddWithValue("?", txtBody.Text);
                cmd.Parameters.Add("DateSent", OleDbType.Date).Value = DateTime.Now;

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Mail sent!");
            this.Close();
        }
    }
}
