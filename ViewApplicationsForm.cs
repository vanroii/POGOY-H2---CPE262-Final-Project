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
    public partial class ViewApplicationsForm : Form
    {
        public ViewApplicationsForm()
        {
            InitializeComponent();
        }

        private void ViewApplicationsForm_Load(object sender, EventArgs e)
        {
            LoadApplications();

            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("Pending");
            cmbStatus.Items.Add("Accepted");
            cmbStatus.Items.Add("Rejected");
        }

        private void LoadApplications()
        {
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = @"
                SELECT ApplicationID, JobID, UserID, Status, DateApplied
                FROM Applications";

                OleDbDataAdapter da = new OleDbDataAdapter(query, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvApplications.DataSource = dt;
            }
        }

        private void btnRemoveApplication_Click(object sender, EventArgs e)
        {
            if (dgvApplications.CurrentRow == null)
            {
                MessageBox.Show("Select an application first!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Remove this application?",
                "Confirm",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.No) return;

            int appId = Convert.ToInt32(
                dgvApplications.CurrentRow.Cells["ApplicationID"].Value);

            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = "DELETE FROM Applications WHERE ApplicationID=?";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", appId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Application removed!");
            LoadApplications();
        }

        private void dgvApplications_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvApplications.Rows[e.RowIndex];

            txtAppID.Text = row.Cells["ApplicationID"].Value.ToString();
            cmbStatus.Text = row.Cells["Status"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAppID.Text))
            {
                MessageBox.Show("Select an application first!");
                return;
            }

            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = "UPDATE Applications SET Status=? WHERE ApplicationID=?";
                OleDbCommand cmd = new OleDbCommand(query, con);

                cmd.Parameters.AddWithValue("?", cmbStatus.Text);
                cmd.Parameters.AddWithValue("?", txtAppID.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Status updated!");
            LoadApplications();
        }
    }
}
