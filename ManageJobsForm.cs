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
    public partial class ManageJobsForm : Form
    {
        public ManageJobsForm()
        {
            InitializeComponent();
        }

        private void ManageJobsForm_Load(object sender, EventArgs e)
        {
            LoadJobs();
        }

        private void LoadJobs()
        {
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = "SELECT JobID, Title, Location, Category, EmployerID FROM Jobs";
                OleDbDataAdapter da = new OleDbDataAdapter(query, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvJobs.DataSource = dt;
            }
        }

        private void btnDeleteJob_Click(object sender, EventArgs e)
        {
            if (dgvJobs.CurrentRow == null)
            {
                MessageBox.Show("Select a job first!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Delete this job and all its applications?",
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

        private void dgvJobs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvJobs.Rows[e.RowIndex];

            txtJobID.Text = row.Cells["JobID"].Value.ToString();
            txtTitle.Text = row.Cells["Title"].Value.ToString();
            txtLocation.Text = row.Cells["Location"].Value.ToString();
            cmbCategory.Text = row.Cells["Category"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtJobID.Text))
            {
                MessageBox.Show("Select a job first!");
                return;
            }

            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = "UPDATE Jobs SET Title=?, Location=?, Category=? WHERE JobID=?";
                OleDbCommand cmd = new OleDbCommand(query, con);

                cmd.Parameters.AddWithValue("?", txtTitle.Text);
                cmd.Parameters.AddWithValue("?", txtLocation.Text);
                cmd.Parameters.AddWithValue("?", cmbCategory.Text);
                cmd.Parameters.AddWithValue("?", txtJobID.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Job updated!");
            LoadJobs();
        }
    }
}
