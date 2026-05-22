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
    public partial class AddJobForm : Form
    {
        public AddJobForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = @"INSERT INTO Jobs (Category, Title, Description, Location, RequiredSkills, MinExperience, AgeMin, AgeMax, EmployerID) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", cmbCategory.Text);
                cmd.Parameters.AddWithValue("?", txtTitle.Text);
                cmd.Parameters.AddWithValue("?", txtDescription.Text);
                cmd.Parameters.AddWithValue("?", txtLocation.Text);
                cmd.Parameters.AddWithValue("?", txtSkills.Text);
                cmd.Parameters.AddWithValue("?", numExperience.Value);
                cmd.Parameters.AddWithValue("?", numAgeMin.Value);
                cmd.Parameters.AddWithValue("?", numAgeMax.Value);
                cmd.Parameters.AddWithValue("?", Session.UserID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Job Added Successfully!");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
