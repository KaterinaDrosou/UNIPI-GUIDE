using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIPI_GUIDE
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtNewUsername.Text;
            string password = txtNewPassword.Text;

            // Hash the password (replace with your actual hashing logic)
            string passwordHash = password; 

            // Insert user into the database
            string relativePath = "users.db";
            string databasePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
            string connectionString = $"Data Source={databasePath};Version=3;";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand("INSERT INTO Users (Username, PasswordHash) VALUES (@username, @passwordHash)", connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@passwordHash", passwordHash);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Your account has been created successfully. Return to the home page and enter your login credentials");
                        
                        Form1 Form1 = new Form1();
                        Form1.Show();
                        this.Close();
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show("Error creating account: " + ex.Message);
                    }
                }
            }
        }
    }
}
