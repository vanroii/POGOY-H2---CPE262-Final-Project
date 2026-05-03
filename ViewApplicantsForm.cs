using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POGOY_H2___CPE262_Final_Project
{
    public partial class ViewApplicantsForm : Form
    {
        int jobId;

        public ViewApplicantsForm(int id)
        {
            InitializeComponent();
            jobId = id;
        }

        private void ViewApplicantsForm_Load(object sender, EventArgs e)
        {
            LoadApplicants();
        }

        private void LoadApplicants()
        {
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = @"SELECT * FROM qryApplicants WHERE JobID=?";

                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", jobId);

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvApplicants.AutoGenerateColumns = false;
                dgvApplicants.Columns.Clear();

                dgvApplicants.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "ApplicationID",
                    HeaderText = "ApplicantID",
                    DataPropertyName = "ApplicationID",
                });

                dgvApplicants.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "Applicant",
                    HeaderText = "Applicant",
                    DataPropertyName = "Applicant"
                });

                dgvApplicants.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "Email",
                    DataPropertyName = "Email"
                });

                dgvApplicants.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "DateApplied",
                    HeaderText = "Date Applied",
                    DataPropertyName = "DateApplied"
                });

                DataGridViewTextBoxColumn iconCol = new DataGridViewTextBoxColumn();
                iconCol.Name = "StatusIcon";
                iconCol.HeaderText = "";
                iconCol.Width = 40;
                dgvApplicants.Columns.Add(iconCol);
                dgvApplicants.Columns["StatusIcon"].Width = 40;
                dgvApplicants.Columns["StatusIcon"].MinimumWidth = 40;
                dgvApplicants.Columns["StatusIcon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvApplicants.Columns["StatusIcon"].DefaultCellStyle.Padding = new Padding(0);

                DataGridViewComboBoxColumn cmbStatus = new DataGridViewComboBoxColumn();
                cmbStatus.Name = "Status";
                cmbStatus.HeaderText = "Status";
                cmbStatus.DataPropertyName = "Status";

                cmbStatus.FlatStyle = FlatStyle.Standard;

                cmbStatus.Items.Add("Pending");
                cmbStatus.Items.Add("Accepted");
                cmbStatus.Items.Add("Rejected");

                dgvApplicants.Columns.Add(cmbStatus);


                dgvApplicants.Columns.Add(new DataGridViewButtonColumn()
                {
                    Name = "ViewResume",
                    HeaderText = "Resume",
                    Text = "View",
                    UseColumnTextForButtonValue = true
                });

                dgvApplicants.Columns.Add(new DataGridViewButtonColumn()
                {
                    Name = "ViewReferral",
                    HeaderText = "Referral Letter",
                    Text = "View",
                    UseColumnTextForButtonValue = true
                });

                dgvApplicants.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "Resume",
                    DataPropertyName = "Resume",
                    Visible = false
                });

                dgvApplicants.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "ReferralLetterPath",
                    DataPropertyName = "ReferralLetterPath",
                    Visible = false
                });

                dgvApplicants.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "UserID",
                    DataPropertyName = "UserID",
                    Visible = false
                });

                dgvApplicants.DataSource = dt;
                SetStatusIcons();
            }
        }

        private void dgvApplicants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvApplicants.Rows[e.RowIndex];

            if (dgvApplicants.Columns[e.ColumnIndex].Name == "ViewResume")
            {
                string path = row.Cells["Resume"].Value?.ToString();

                if (string.IsNullOrEmpty(path))
                {
                    MessageBox.Show("No resume uploaded.");
                    return;
                }

                Process.Start(new ProcessStartInfo()
                {
                    FileName = path,
                    UseShellExecute = true
                });
            }

            if (dgvApplicants.Columns[e.ColumnIndex].Name == "ViewReferral")
            {
                string path = row.Cells["ReferralLetterPath"].Value?.ToString();

                if (string.IsNullOrEmpty(path))
                {
                    MessageBox.Show("No referral letter uploaded.");
                    return;
                }

                Process.Start(new ProcessStartInfo()
                {
                    FileName = path,
                    UseShellExecute = true
                });
            }
        }

        private void dgvApplicants_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvApplicants.Columns[e.ColumnIndex].Name == "Status")
            {
                var row = dgvApplicants.Rows[e.RowIndex];

                int appId = Convert.ToInt32(row.Cells["ApplicationID"].Value);
                string newStatus = row.Cells["Status"].Value.ToString();

                using (OleDbConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string query = "UPDATE Applications SET Status=? WHERE ApplicationID=?";
                    OleDbCommand cmd = new OleDbCommand(query, con);

                    cmd.Parameters.AddWithValue("?", newStatus);
                    cmd.Parameters.AddWithValue("?", appId);

                    cmd.ExecuteNonQuery();
                }
                dgvApplicants.Refresh();
                SetStatusIcons();
                MessageBox.Show("Status changed!");
            }
        }

        private void dgvApplicants_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvApplicants.IsCurrentCellDirty)
            {
                dgvApplicants.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnRemoveApplicant_Click(object sender, EventArgs e)
        {
            if (dgvApplicants.CurrentRow == null)
            {
                MessageBox.Show("Select an applicant first!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Remove this applicant?",
                "Confirm",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.No) return;

            int appId = Convert.ToInt32(
                dgvApplicants.CurrentRow.Cells["ApplicationID"].Value);

            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = "DELETE FROM Applications WHERE ApplicationID=?";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", appId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Applicant removed!");
            LoadApplicants();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvApplicants_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadApplicants();
                return;
            }

            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string keyword = txtSearch.Text;

                string query = @"SELECT * FROM qryApplicants WHERE JobID=? AND (Applicant LIKE ? OR Status LIKE ?)";

                OleDbCommand cmd = new OleDbCommand(query, con);

                cmd.Parameters.AddWithValue("?", jobId);
                cmd.Parameters.AddWithValue("?", "%" + keyword + "%");
                cmd.Parameters.AddWithValue("?", "%" + keyword + "%");

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvApplicants.DataSource = dt;
            }
        }

        private void dgvApplicants_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvApplicants.Rows[e.RowIndex];

            if (row.Cells["Status"].Value == null) return;

            string status = row.Cells["Status"].Value.ToString();

            if (status == "Accepted")
            {
                row.DefaultCellStyle.BackColor = Color.LightGreen;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
            else if (status == "Rejected")
            {
                row.DefaultCellStyle.BackColor = Color.LightCoral;
                row.DefaultCellStyle.ForeColor = Color.White;
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void SetStatusIcons()
        {
            foreach (DataGridViewRow row in dgvApplicants.Rows)
            {
                if (row.Cells["Status"].Value == null) continue;

                string status = row.Cells["Status"].Value.ToString();

                if (status == "Accepted")
                {
                    row.Cells["StatusIcon"].Value = "✔";
                }
                else if (status == "Rejected")
                {
                    row.Cells["StatusIcon"].Value = "✖";
                }
                else
                {
                    row.Cells["StatusIcon"].Value = "⏳";
                }
            }
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            if (dgvApplicants.CurrentRow == null)
            {
                MessageBox.Show("Select an applicant first!");
                return;
            }

            //var drv = dgvApplicants.CurrentRow?.DataBoundItem as DataRowView;
            //int receiverId = Convert.ToInt32(drv["UserID"]);

            int receiverId = Convert.ToInt32(
                dgvApplicants.CurrentRow.Cells["UserID"].Value);

            SendMailForm form = new SendMailForm(Session.UserID, receiverId);
            form.ShowDialog();
        }
    }
}

