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
    public partial class ChatItem : UserControl
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }

        public event EventHandler ChatClicked;

        public ChatItem(int id, string name, string role)
        {
            InitializeComponent();
            UserID = id;
            UserName = name;
            Role = role;
            lblName.Text = name;
            lblRole.Text = role;
            lblUserID.Text = "ID: " + id;
            this.Click += ClickAll;
            foreach (Control c in this.Controls)
                c.Click += ClickAll;
        }

        private void ClickAll(object sender, EventArgs e)
        {
            ChatClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
