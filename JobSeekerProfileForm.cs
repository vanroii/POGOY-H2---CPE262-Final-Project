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
    public partial class JobSeekerProfileForm : Form
    {
        public JobSeekerProfileForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string checkQuery = "SELECT COUNT(*) FROM JobSeekerProfile WHERE UserID=?";
                OleDbCommand checkCmd = new OleDbCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("?", Session.UserID);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count == 0)
                {
                    string insertQuery = @"INSERT INTO JobSeekerProfile (UserID, Skills, ExperienceYears, Age, PreferredCategory) VALUES (?, ?, ?, ?, ?)";

                    OleDbCommand cmd = new OleDbCommand(insertQuery, con);

                    cmd.Parameters.AddWithValue("?", Session.UserID);
                    cmd.Parameters.AddWithValue("?", txtSkills.Text);
                    cmd.Parameters.AddWithValue("?", numExperience.Value);
                    cmd.Parameters.AddWithValue("?", numAge.Value);
                    cmd.Parameters.AddWithValue("?", cmbCategory.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Profile Saved!");
                    this.Close();
                }
                else
                {
                    string updateQuery = @"UPDATE JobSeekerProfile SET Skills=?, ExperienceYears=?, Age=?, PreferredCategory=? WHERE UserID=?";

                    OleDbCommand cmd = new OleDbCommand(updateQuery, con);

                    cmd.Parameters.AddWithValue("?", txtSkills.Text);
                    cmd.Parameters.AddWithValue("?", numExperience.Value);
                    cmd.Parameters.AddWithValue("?", numAge.Value);
                    cmd.Parameters.AddWithValue("?", cmbCategory.Text);
                    cmd.Parameters.AddWithValue("?", Session.UserID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Profile Updated!");
                    this.Close();
                }
            }
        }

        private void JobSeekerProfileForm_Load(object sender, EventArgs e)
        {
            txtName.Text = Session.UserName;

            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = "SELECT * FROM JobSeekerProfile WHERE UserID=?";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", Session.UserID);

                OleDbDataReader reader = cmd.ExecuteReader();

                cmbCategory.Items.Clear();

                cmbCategory.Items.Add("None");
                cmbCategory.Items.Add("IT");
                cmbCategory.Items.Add("Sales");
                cmbCategory.Items.Add("Service");
                cmbCategory.Items.Add("Construction");
                cmbCategory.Items.Add("Creative");
                cmbCategory.Items.Add("Office");
                cmbCategory.Items.Add("Healthcare");
                cmbCategory.Items.Add("Education");
                cmbCategory.Items.Add("Engineering");
                cmbCategory.Items.Add("Logistics");

                if (reader.Read())
                {
                    txtSkills.Text = reader["Skills"].ToString();
                    numExperience.Value = Convert.ToDecimal(reader["ExperienceYears"]);
                    numAge.Value = Convert.ToDecimal(reader["Age"]);
                    cmbCategory.Text = reader["PreferredCategory"].ToString();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
