using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UNIPI_GUIDE
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        private void Form11_Load(object sender, EventArgs e)
        {
            LoadComments();
        }

        private void LoadComments()
        {
            string relativePath = "users.db"; 
            string databasePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
            string connectionString = $"Data Source={databasePath};Version=3;";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT CommentText, DateAdded FROM Comments", connection);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string comment = $" {reader["CommentText"]} (Posted on: {reader["DateAdded"]})";
                        
                        listBoxComments.Items.Add(comment);
                    }
                }
            }
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            if (!UserSession.IsLoggedIn)
            {
                MessageBox.Show("Only logged in users can leave a review!");
                return;
            }

            string commentText = txtComment.Text;
            if (string.IsNullOrEmpty(commentText))
            {
                MessageBox.Show("The field for entering a comment is empty");
                return;
            }

            // Insert comment into database
            string relativePath = "users.db";
            string databasePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
            string connectionString = $"Data Source={databasePath};Version=3;";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("INSERT INTO Comments (Username, CommentText) VALUES (@username, @commentText)", connection);
                command.Parameters.AddWithValue("@username", UserSession.Username);
                command.Parameters.AddWithValue("@commentText", commentText);
                command.ExecuteNonQuery();
            }

            // Refresh comments list
            listBoxComments.Items.Clear();
            LoadComments();
            txtComment.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!UserSession.IsLoggedIn)
            {
                Form1 Form = new Form1();
                Form.Show();
                this.Close();   
            }
            else
            {
                Form10 Form = new Form10();
                Form.Show();
                this.Close();
            }  
        }
    }
}
