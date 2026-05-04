using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POGOY_H2___CPE262_Final_Project
{
    public partial class MailItem : UserControl
    {
        public string Sender { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime DateSent { get; set; }

        public event EventHandler MailClicked;

        public MailItem(string sender, string subject, string body, DateTime date)
        {
            InitializeComponent();

            Sender = sender;
            Subject = subject;
            Body = body;
            DateSent = date;

            lblSender.Text = sender;
            lblSubject.Text = subject;
            lblPreview.Text = body.Length > 35 ? body.Substring(0, 35) + "..." : body;
            lblDate.Text = date.ToString("MMM dd");

            this.Click += ClickAll;
            foreach (Control c in this.Controls)
                c.Click += ClickAll;
        }

        private void ClickAll(object sender, EventArgs e)
        {
            MailClicked?.Invoke(this, EventArgs.Empty);
        }

    }
}
