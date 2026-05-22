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
    public partial class EditApplicationForm : Form
    {
        int applicationId;
        string resumePath = "";
        private string referralLetterPath = "";

        public EditApplicationForm(int id)
        {
            InitializeComponent();
            applicationId = id;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(resumePath))
            {
                MessageBox.Show("Please upload a resume first!");
                return;
            }
            object referralLetter = DBNull.Value;
            if (!string.IsNullOrEmpty(referralLetterPath)) referralLetter = referralLetterPath;
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = "UPDATE Applications SET ResumePath=?, ReferralLetterPath=? WHERE ApplicationID=?";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", resumePath);
                cmd.Parameters.AddWithValue("?", referralLetter);
                cmd.Parameters.AddWithValue("?", applicationId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Application Updated Successfully!");
                this.Close();
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF Files|*.pdf|Word Files|*.docx";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = openFileDialog1.FileName;
                string destFolder = @"C:\Users\jovan\source\repos\POGOY H2 - CPE262 Final Project\RESUMES";
                if (!Directory.Exists(destFolder)) Directory.CreateDirectory(destFolder);
                string fileName = Path.GetFileNameWithoutExtension(sourcePath) + "_" + Guid.NewGuid().ToString() + Path.GetExtension(sourcePath);
                string destPath = Path.Combine(destFolder, fileName);
                File.Copy(sourcePath, destPath);
                resumePath = destPath;
                lblResumePath.Text = fileName;
            }
        }

        private void EditApplicationForm_Load(object sender, EventArgs e)
        {
            LoadApplicationData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowseReferralLetter_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "PDF Files|*.pdf|Word Files|*.docx";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = openFileDialog2.FileName;
                string destFolder = @"C:\Users\jovan\source\repos\POGOY H2 - CPE262 Final Project\REFERRALS";
                if (!Directory.Exists(destFolder)) Directory.CreateDirectory(destFolder);
                string fileName = Path.GetFileNameWithoutExtension(sourcePath) + "_" + Guid.NewGuid().ToString() + Path.GetExtension(sourcePath);
                string destPath = Path.Combine(destFolder, fileName);
                File.Copy(sourcePath, destPath);
                referralLetterPath = destPath;
                lblReferralLetterPath.Text = fileName;
            }
        }

        private void LoadApplicationData()
        {
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string query = @"SELECT ResumePath, ReferralLetterPath FROM Applications WHERE ApplicationID = ?";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("?", applicationId);
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    resumePath = reader["ResumePath"]?.ToString();
                    lblFilePath.Text = string.IsNullOrEmpty(resumePath) ? "No resume uploaded." : System.IO.Path.GetFileName(resumePath);
                    referralLetterPath = reader["ReferralLetterPath"]?.ToString();
                    lblFilePath2.Text = string.IsNullOrEmpty(referralLetterPath) ? "No referral letter uploaded." : System.IO.Path.GetFileName(referralLetterPath);
                }
            }
        }

        private void lblFilePath_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(resumePath))
            {
                MessageBox.Show("No resume uploaded.");
                return;
            }
            OpenFile(resumePath);
        }

        private void lblFilePath2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(referralLetterPath))
            {
                MessageBox.Show("No referral letter uploaded.");
                return;
            }
            OpenFile(referralLetterPath);
        }

        private void lblResumePath_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(resumePath) || lblResumePath.Text == "No file uploaded.")
            {
                MessageBox.Show("No file uploaded.");
                return;
            }
            OpenFile(resumePath);
        }

        private void lblReferralLetterPath_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(referralLetterPath) || lblReferralLetterPath.Text == "No file uploaded.")
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
