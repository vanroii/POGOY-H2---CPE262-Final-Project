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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void LoadForm(Form form)
        {
            panelMain.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panelMain.Controls.Add(form);
            form.Show();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"{Session.UserName}";
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            LoadForm(new ManageUsersForm());
        }

        private void btnManageJobs_Click(object sender, EventArgs e)
        {
            LoadForm(new ManageJobsForm());
        }

        private void btnViewApplications_Click(object sender, EventArgs e)
        {
            LoadForm(new ViewApplicationsForm());
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            LoadForm(new AnalyticsForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void btnChats_Click(object sender, EventArgs e)
        {
            ChatForm form = new ChatForm();
            form.ShowDialog();
        }
    }
}
