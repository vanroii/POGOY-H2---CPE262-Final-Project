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
    public partial class ManageUsersForm : Form
    {
        public ManageUsersForm()
        {
            InitializeComponent();
        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = "SELECT UserID, Name, Email, Role FROM Users";
                OleDbDataAdapter da = new OleDbDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUsers.DataSource = dt;
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
            txtUserID.Text = row.Cells["UserID"].Value.ToString();
            txtName.Text = row.Cells["Name"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            cmbRole.Text = row.Cells["Role"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text)){
                MessageBox.Show("Select a user first!");
                return;
            } using (OleDbConnection con = DBConnection.GetConnection()) {
                con.Open();
                string query = "UPDATE Users SET Name=?, Email=?, Role=? WHERE UserID=?";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", txtName.Text);
                cmd.Parameters.AddWithValue("?", txtEmail.Text);
                cmd.Parameters.AddWithValue("?", cmbRole.Text);
                cmd.Parameters.AddWithValue("?", txtUserID.Text);
                cmd.ExecuteNonQuery();
            } MessageBox.Show("User updated!");
            LoadUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "1") {
                MessageBox.Show("Cannot delete Admin!");
                return;
            } if (string.IsNullOrEmpty(txtUserID.Text)) {
                MessageBox.Show("Select a user first!");
                return;
            } 
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?\n\nAll related jobs and applications will also be deleted.","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;
            int userId = Convert.ToInt32(txtUserID.Text);
            using (OleDbConnection con = DBConnection.GetConnection()) {
                con.Open();
                string deleteUserApps = "DELETE FROM Applications WHERE UserID=?";
                OleDbCommand cmd1 = new OleDbCommand(deleteUserApps, con);
                cmd1.Parameters.AddWithValue("?", userId);
                cmd1.ExecuteNonQuery();
                string deleteAppsFromJobs = @"DELETE FROM Applications WHERE JobID IN (SELECT JobID FROM Jobs WHERE EmployerID=?)";
                OleDbCommand cmd2 = new OleDbCommand(deleteAppsFromJobs, con);
                cmd2.Parameters.AddWithValue("?", userId);
                cmd2.ExecuteNonQuery();
                string deleteJobs = "DELETE FROM Jobs WHERE EmployerID=?";
                OleDbCommand cmd3 = new OleDbCommand(deleteJobs, con);
                cmd3.Parameters.AddWithValue("?", userId);
                cmd3.ExecuteNonQuery();
                string deleteUser = "DELETE FROM Users WHERE UserID=?";
                OleDbCommand cmd4 = new OleDbCommand(deleteUser, con);
                cmd4.Parameters.AddWithValue("?", userId);
                cmd4.ExecuteNonQuery();
            } MessageBox.Show("User and related data deleted successfully!");
            LoadUsers();
        }
    }
}