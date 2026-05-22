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
    public partial class JobSeekerDashboard : Form
    {
        public JobSeekerDashboard()
        {
            InitializeComponent();
        }

        private void JobSeekerDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"{Session.UserName}";
            lblUserID.Text = "Job Seeker ID: " + Session.UserID;
            CheckProfile();
            LoadMatchingJobs();
        }

        private void CheckProfile()
        {
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM JobSeekerProfile WHERE UserID=?";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", Session.UserID);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                {
                    MessageBox.Show("Please complete your profile first!");
                    JobSeekerProfileForm form = new JobSeekerProfileForm();
                    form.ShowDialog();
                    LoadMatchingJobs();
                }
            }
        }

        private void LoadMatchingJobs()
        {
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string profileQuery = "SELECT * FROM JobSeekerProfile WHERE UserID=?";
                OleDbCommand profileCmd = new OleDbCommand(profileQuery, con);
                profileCmd.Parameters.AddWithValue("?", Session.UserID);
                OleDbDataReader reader = profileCmd.ExecuteReader();
                if (reader.Read())
                {
                    string category = reader["PreferredCategory"].ToString();
                    string skills = reader["Skills"].ToString();
                    int experience = Convert.ToInt32(reader["ExperienceYears"]);
                    int age = Convert.ToInt32(reader["Age"]);
                    reader.Close();

                    string jobQuery;

                    if (category == "None")
                    {
                        jobQuery = @"SELECT * FROM Jobs WHERE RequiredSkills LIKE ? AND MinExperience <= ? AND AgeMin <= ? AND AgeMax >= ?";
                        OleDbCommand jobCmd = new OleDbCommand(jobQuery, con);
                        jobCmd.Parameters.AddWithValue("?", "%" + skills + "%");
                        jobCmd.Parameters.AddWithValue("?", experience);
                        jobCmd.Parameters.AddWithValue("?", age);
                        jobCmd.Parameters.AddWithValue("?", age);
                        OleDbDataAdapter da = new OleDbDataAdapter(jobCmd);
                        System.Data.DataTable dt = new System.Data.DataTable();
                        da.Fill(dt);
                        dgvJobs.DataSource = dt;
                        dgvJobs.Columns["Description"].Visible = false;
                        dgvJobs.Columns["RequiredSkills"].Visible = false;
                    }
                    else
                    {
                        jobQuery = @"SELECT * FROM Jobs WHERE Category = ? AND RequiredSkills LIKE ? AND MinExperience <= ? AND AgeMin <= ? AND AgeMax >= ?";
                        OleDbCommand jobCmd = new OleDbCommand(jobQuery, con);
                        jobCmd.Parameters.AddWithValue("?", category);
                        jobCmd.Parameters.AddWithValue("?", "%" + skills + "%");
                        jobCmd.Parameters.AddWithValue("?", experience);
                        jobCmd.Parameters.AddWithValue("?", age);
                        jobCmd.Parameters.AddWithValue("?", age);
                        OleDbDataAdapter da = new OleDbDataAdapter(jobCmd);
                        System.Data.DataTable dt = new System.Data.DataTable();
                        da.Fill(dt);
                        dgvJobs.DataSource = dt;
                        dgvJobs.Columns["Description"].Visible = false;
                        dgvJobs.Columns["RequiredSkills"].Visible = false;
                    }
                }
            }
        }

        private void btnViewJob_Click(object sender, EventArgs e)
        {
            if (dgvJobs.CurrentRow == null)
            {
                MessageBox.Show("Select a job first!");
                return;
            }

            int jobId = Convert.ToInt32(dgvJobs.CurrentRow.Cells["JobID"].Value);

            ViewJobForm form = new ViewJobForm(jobId);
            form.ShowDialog();
        }

        private void btnViewApplications_Click(object sender, EventArgs e)
        {
            ViewMyApplicationsForm form = new ViewMyApplicationsForm();
            form.ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            JobSeekerProfileForm form = new JobSeekerProfileForm();
            form.ShowDialog();
            LoadMatchingJobs();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadMatchingJobs();
                return;
            }

            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string keyword = txtSearch.Text.Trim();
                string profileQuery = "SELECT * FROM JobSeekerProfile WHERE UserID=?";
                OleDbCommand profileCmd = new OleDbCommand(profileQuery, con);
                profileCmd.Parameters.AddWithValue("?", Session.UserID);
                OleDbDataReader reader = profileCmd.ExecuteReader();
                if (reader.Read())
                {
                    string category = reader["PreferredCategory"].ToString();
                    string skills = reader["Skills"].ToString();
                    int experience = Convert.ToInt32(reader["ExperienceYears"]);
                    int age = Convert.ToInt32(reader["Age"]);
                    reader.Close();
                    string jobQuery;
                    if (category == "None")
                    {
                        jobQuery = @"SELECT * FROM Jobs WHERE (RequiredSkills LIKE ? AND MinExperience <= ? AND AgeMin <= ? AND AgeMax >= ?) AND (Title LIKE ? OR Location LIKE ? OR Category LIKE ?)";
                        OleDbCommand jobCmd = new OleDbCommand(jobQuery, con);
                        jobCmd.Parameters.AddWithValue("?", "%" + skills + "%");
                        jobCmd.Parameters.AddWithValue("?", experience);
                        jobCmd.Parameters.AddWithValue("?", age);
                        jobCmd.Parameters.AddWithValue("?", age);
                        jobCmd.Parameters.AddWithValue("?", "%" + keyword + "%");
                        jobCmd.Parameters.AddWithValue("?", "%" + keyword + "%");
                        jobCmd.Parameters.AddWithValue("?", "%" + keyword + "%");
                        OleDbDataAdapter da = new OleDbDataAdapter(jobCmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvJobs.DataSource = dt;
                        dgvJobs.Columns["Description"].Visible = false;
                        dgvJobs.Columns["RequiredSkills"].Visible = false;
                    }
                    else
                    {
                        jobQuery = @"SELECT * FROM Jobs WHERE (Category = ? AND RequiredSkills LIKE ? AND MinExperience <= ? AND AgeMin <= ? AND AgeMax >= ?) AND (Title LIKE ? OR Location LIKE ? OR Category LIKE ?)";
                        OleDbCommand jobCmd = new OleDbCommand(jobQuery, con);
                        jobCmd.Parameters.AddWithValue("?", category);
                        jobCmd.Parameters.AddWithValue("?", "%" + skills + "%");
                        jobCmd.Parameters.AddWithValue("?", experience);
                        jobCmd.Parameters.AddWithValue("?", age);
                        jobCmd.Parameters.AddWithValue("?", age);
                        jobCmd.Parameters.AddWithValue("?", "%" + keyword + "%");
                        jobCmd.Parameters.AddWithValue("?", "%" + keyword + "%");
                        jobCmd.Parameters.AddWithValue("?", "%" + keyword + "%");
                        OleDbDataAdapter da = new OleDbDataAdapter(jobCmd);
                        System.Data.DataTable dt = new System.Data.DataTable();
                        da.Fill(dt);
                        dgvJobs.DataSource = dt;
                        dgvJobs.Columns["Description"].Visible = false;
                        dgvJobs.Columns["RequiredSkills"].Visible = false;
                    }
                }
            }
        }

        private void btnMailInbox_Click(object sender, EventArgs e)
        {
            MailInboxForm form = new MailInboxForm();
            form.ShowDialog();
        }

        private void btnChats_Click(object sender, EventArgs e)
        {
            ChatForm form = new ChatForm();
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }
    }
}
