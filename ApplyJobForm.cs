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
    public partial class ApplyJobForm : Form
    {
        int jobId;
        string resumePath = "";
        private string referralLetterPath = "";

        public ApplyJobForm(int id, string title)
        {
            InitializeComponent();
            jobId = id;

            lblJobTitle.Text = "Job Title: " + title;
        }

        private void btnUploadResume_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF Files|*.pdf|Word Files|*.docx";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = openFileDialog1.FileName;

                string destFolder = @"C:\Users\jovan\source\repos\POGOY H2 - CPE262 Final Project\RESUMES";

                if (!Directory.Exists(destFolder))
                {
                    Directory.CreateDirectory(destFolder);
                }

                string fileName = Path.GetFileNameWithoutExtension(sourcePath)
                                  + "_" + Guid.NewGuid().ToString()
                                  + Path.GetExtension(sourcePath);

                string destPath = Path.Combine(destFolder, fileName);

                File.Copy(sourcePath, destPath);

                resumePath = destPath;
                lblFilePath.Text = fileName;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            object referralLetter = DBNull.Value;

            if (!string.IsNullOrEmpty(referralLetterPath))
            {
                referralLetter = referralLetterPath;
            }

            string query = @"INSERT INTO Applications (JobID, UserID, Status, DateApplied, ResumePath, ReferralLetterPath) VALUES (?, ?, ?, ?, ?, ?)";

            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand(query, con);

                cmd.Parameters.AddWithValue("?", jobId);
                cmd.Parameters.AddWithValue("?", Session.UserID);
                cmd.Parameters.AddWithValue("?", "Pending");
                cmd.Parameters.Add("DateApplied", OleDbType.Date).Value = DateTime.Now;
                cmd.Parameters.AddWithValue("?", resumePath);
                cmd.Parameters.AddWithValue("?", referralLetter);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Application Submitted!");
                this.Close();
            }
        }

        private void btnBrowseReferralLetter_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "PDF Files|*.pdf|Word Files|*.docx";

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = openFileDialog2.FileName;
                string destFolder = @"C:\Users\jovan\source\repos\POGOY H2 - CPE262 Final Project\REFERRALS";

                if (!Directory.Exists(destFolder))
                    Directory.CreateDirectory(destFolder);

                string fileName = Path.GetFileNameWithoutExtension(sourcePath)
                                  + "_" + Guid.NewGuid().ToString()
                                  + Path.GetExtension(sourcePath);

                string destPath = Path.Combine(destFolder, fileName);

                File.Copy(sourcePath, destPath);

                referralLetterPath = destPath;
                lblReferralLetterPath.Text = fileName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void lblFilePath_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(resumePath))
            {
                MessageBox.Show("No file uploaded.");
                return;
            }

            OpenFile(resumePath);
        }

        private void lblReferralLetterPath_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(referralLetterPath))
            {
                MessageBox.Show("No file uploaded.");
                return;
            }

            OpenFile(referralLetterPath);
        }

        private void OpenFile(string path)
        {
            try
            {
                if (!System.IO.File.Exists(path))
                {
                    MessageBox.Show("File not found.");
                    return;
                }

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = path,
                    UseShellExecute = true
                });
            }
            catch
            {
                MessageBox.Show("Unable to open file.");
            }
        }
    }
}
