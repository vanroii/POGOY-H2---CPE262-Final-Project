using System.Data;
using System.Data.Common;
using System.Data.OleDb;

namespace POGOY_H2___CPE262_Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();
                string hashedPassword = PasswordHelper.HashPassword(txtPassword.Text);

                //string query = "SELECT * FROM Users WHERE Email=@Email AND [Password]=@Password";
                //OleDbCommand cmd = new OleDbCommand(query, con);

                //cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                //cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                string query = "SELECT * FROM Users WHERE Email=? AND [Password]=?";
                OleDbCommand cmd = new OleDbCommand(query, con);

                cmd.Parameters.AddWithValue("?", txtEmail.Text);
                cmd.Parameters.AddWithValue("?", hashedPassword);

                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string role = reader["Role"].ToString();
                    Session.UserID = Convert.ToInt32(reader["UserID"]);
                    Session.UserName = reader["Name"].ToString();
                    Session.Role = role;

                    if (role == "Admin")
                    {
                        new AdminDashboard().Show();
                    }
                    else if (role == "Employer")
                    {
                        new EmployerDashboard().Show();
                    }
                    else
                    {
                        new JobSeekerDashboard().Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login!");
                }
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }
    }
}
