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
    public partial class ViewJobForm : Form
    {
        int jobId;

        public ViewJobForm(int id)
        {
            InitializeComponent();
            jobId = id;
        }

        private void ViewJobForm_Load(object sender, EventArgs e)
        {
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = "SELECT * FROM Jobs WHERE JobID=?";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", jobId);

                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtTitle.Text = reader["Title"].ToString();
                    txtLocation.Text = reader["Location"].ToString();
                    txtCategory.Text = reader["Category"].ToString();
                    txtDescription.Text = reader["Description"].ToString();
                    txtSkills.Text = reader["RequiredSkills"].ToString();
                    txtExperience.Text = reader["MinExperience"].ToString() + " years/s";
                    txtAgeMin.Text = reader["AgeMin"].ToString();
                    txtAgeMax.Text = reader["AgeMax"].ToString();
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = "SELECT COUNT(*) FROM Applications WHERE JobID=? AND UserID=?";
                OleDbCommand cmd = new OleDbCommand(query, con);

                cmd.Parameters.AddWithValue("?", jobId);
                cmd.Parameters.AddWithValue("?", Session.UserID);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("You already applied for this job!");
                    return;
                }
            }

            ApplyJobForm form = new ApplyJobForm(jobId, txtTitle.Text);
            form.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
