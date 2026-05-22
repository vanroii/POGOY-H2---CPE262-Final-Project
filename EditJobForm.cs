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
    public partial class EditJobForm : Form
    {
        int jobId;

        public EditJobForm(int id)
        {
            InitializeComponent();
            jobId = id;
        }

        private void EditJobForm_Load(object sender, EventArgs e)
        {
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM Jobs WHERE JobID = ?";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", jobId);
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cmbCategory.Text = reader["Category"].ToString();
                    txtTitle.Text = reader["Title"].ToString();
                    txtDescription.Text = reader["Description"].ToString();
                    txtLocation.Text = reader["Location"].ToString();
                    txtSkills.Text = reader["RequiredSkills"].ToString();
                    numExperience.Value = Convert.ToDecimal(reader["MinExperience"]);
                    numAgeMin.Value = Convert.ToDecimal(reader["AgeMin"]);
                    numAgeMax.Value = Convert.ToDecimal(reader["AgeMax"]);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = "UPDATE Jobs SET Category=?, Title=?, Description=?, Location=?, RequiredSkills=?, MinExperience=?, AgeMin=?, AgeMax=? WHERE JobID=?";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", cmbCategory.Text);
                cmd.Parameters.AddWithValue("?", txtTitle.Text);
                cmd.Parameters.AddWithValue("?", txtDescription.Text);
                cmd.Parameters.AddWithValue("?", txtLocation.Text);
                cmd.Parameters.AddWithValue("?", txtSkills.Text);
                cmd.Parameters.AddWithValue("?", numExperience.Value);
                cmd.Parameters.AddWithValue("?", numAgeMin.Value);
                cmd.Parameters.AddWithValue("?", numAgeMax.Value);
                cmd.Parameters.AddWithValue("?", jobId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Job Updated Successfully!");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
