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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();        
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = "INSERT INTO Users (Name, Email, [Password], Role) VALUES (?, ?, ?, ?)";
                OleDbCommand cmd = new OleDbCommand(query, con);

                cmd.Parameters.AddWithValue("?", txtName.Text);
                cmd.Parameters.AddWithValue("?", txtEmail.Text);

                string hashedPassword = PasswordHelper.HashPassword(txtPassword.Text);
                cmd.Parameters.AddWithValue("?", hashedPassword);

                cmd.Parameters.AddWithValue("?", cmbRole.SelectedItem.ToString());

                if (cmbRole.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a role!");
                    return;
                }

                cmd.ExecuteNonQuery();

                MessageBox.Show("Account Created Successfully!");

                new Form1().Show();
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }
    }
}
