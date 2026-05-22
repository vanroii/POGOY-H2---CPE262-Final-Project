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
    public partial class ViewMyApplicationsForm : Form
    {
        public ViewMyApplicationsForm()
        {
            InitializeComponent();
        }

        private void ViewMyApplicationsForm_Load(object sender, EventArgs e)
        {
            LoadApplications();
        }

        private void LoadApplications()
        {
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = @"SELECT ApplicationID, JobID, Status, DateApplied, ResumePath FROM Applications WHERE UserID = ?";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", Session.UserID);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);
                dgvMyApplications.DataSource = dt;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMyApplications.CurrentRow == null)
            {
                MessageBox.Show("Select an application!");
                return;
            }
            int appId = Convert.ToInt32(dgvMyApplications.CurrentRow.Cells["ApplicationID"].Value);
            EditApplicationForm form = new EditApplicationForm(appId);
            form.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteApplication_Click(object sender, EventArgs e)
        {
            if (dgvMyApplications.CurrentRow == null)
            {
                MessageBox.Show("Select an application first!");
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this application?","Confirm",MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;
            int appId = Convert.ToInt32(dgvMyApplications.CurrentRow.Cells["ApplicationID"].Value);
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = "DELETE FROM Applications WHERE ApplicationID=?";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", appId);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Application deleted!");
            LoadApplications();
        }
    }
}
