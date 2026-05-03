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
using System.Windows.Forms.DataVisualization.Charting;

namespace POGOY_H2___CPE262_Final_Project
{
    public partial class EmployerDashboard : Form
    {
        public EmployerDashboard()
        {
            InitializeComponent();
        }

        private void LoadJobs()
        {
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = "SELECT * FROM qryJobApplicantCount WHERE EmployerID=?";

                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", Session.UserID);

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);

                dgvJobs.DataSource = dt;
                dgvJobs.Columns["EmployerID"].Visible = false;
            }
        }

        private void EmployerDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"{Session.UserName}";
            lblUserID.Text = "Employer ID: " + Session.UserID;

            LoadJobs();
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            AddJobForm form = new AddJobForm();
            form.ShowDialog();
            LoadJobs();
        }

        private void btnEditJob_Click(object sender, EventArgs e)
        {
            if (dgvJobs.CurrentRow == null)
            {
                MessageBox.Show("Select a job first!");
                return;
            }

            int employerId = Convert.ToInt32(dgvJobs.CurrentRow.Cells["EmployerID"].Value);

            if (employerId != Session.UserID)
            {
                MessageBox.Show("You can only edit your own jobs!");
                return;
            }

            int jobId = Convert.ToInt32(dgvJobs.CurrentRow.Cells["JobID"].Value);

            EditJobForm form = new EditJobForm(jobId);
            form.ShowDialog();

            LoadJobs();
        }

        private void btnDeleteJob_Click(object sender, EventArgs e)
        {
            if (dgvJobs.CurrentRow == null)
            {
                MessageBox.Show("Select a job first!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Deleting this job will remove all applicants. Continue?",
                "Confirm",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.No) return;

            int jobId = Convert.ToInt32(
                dgvJobs.CurrentRow.Cells["JobID"].Value);

            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string deleteApps = "DELETE FROM Applications WHERE JobID=?";
                OleDbCommand cmd1 = new OleDbCommand(deleteApps, con);
                cmd1.Parameters.AddWithValue("?", jobId);
                cmd1.ExecuteNonQuery();

                string deleteJob = "DELETE FROM Jobs WHERE JobID=?";
                OleDbCommand cmd2 = new OleDbCommand(deleteJob, con);
                cmd2.Parameters.AddWithValue("?", jobId);
                cmd2.ExecuteNonQuery();
            }

            MessageBox.Show("Job deleted!");
            LoadJobs();
        }

        private void btnViewApplicants_Click(object sender, EventArgs e)
        {
            if (dgvJobs.CurrentRow == null)
            {
                MessageBox.Show("Select a job first!");
                return;
            }

            int jobId = Convert.ToInt32(dgvJobs.CurrentRow.Cells["JobID"].Value);

            ViewApplicantsForm form = new ViewApplicantsForm(jobId);
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadJobs();
                return;
            }

            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string keyword = txtSearch.Text.Trim();

                string query = "SELECT * FROM qryJobApplicantCount WHERE EmployerID=? AND (Title LIKE ? OR Location LIKE ? OR Category LIKE ?)";
                OleDbCommand cmd = new OleDbCommand(query, con);

                cmd.Parameters.AddWithValue("?", Session.UserID);
                cmd.Parameters.AddWithValue("?", "%" + keyword + "%");
                cmd.Parameters.AddWithValue("?", "%" + keyword + "%");
                cmd.Parameters.AddWithValue("?", "%" + keyword + "%");

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);

                dgvJobs.DataSource = dt;
                dgvJobs.Columns["EmployerID"].Visible = false;
            }
        }

        private void btnSentMails_Click(object sender, EventArgs e)
        {
            MailSentForm form = new MailSentForm();
            form.ShowDialog();
        }

        private void btnChats_Click(object sender, EventArgs e)
        {
            ChatForm form = new ChatForm();
            form.ShowDialog();
        }
    }
}
