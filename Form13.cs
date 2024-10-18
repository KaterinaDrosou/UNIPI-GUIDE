using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIPI_GUIDE
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void LoadUserData()
        {
            // Load user data into the DataGridView
            string connectionString = "Data Source=users.db;Version=3;";
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT * FROM UserInfo WHERE Username = @username", connection);
                command.Parameters.AddWithValue("@username", UserSession.Username);
                var adapter = new SQLiteDataAdapter(command);
                var table = new System.Data.DataTable();
                adapter.Fill(table);
                dataGridViewUserInfo.DataSource = table;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=users.db;Version=3;";
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("INSERT INTO UserInfo (Username, Department, Subjects, Notes, Activities) VALUES (@username, @department, @subjects, @notes, @activities)", connection);
                command.Parameters.AddWithValue("@username", UserSession.Username);
                command.Parameters.AddWithValue("@department", txtDepartment.Text);
                command.Parameters.AddWithValue("@subjects", txtSubjects.Text);
                command.Parameters.AddWithValue("@notes", txtNotes.Text);
                command.Parameters.AddWithValue("@activities", txtActivities.Text);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("User information saved successfully.");
                    LoadUserData(); // Refresh data in DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving user information: " + ex.Message);
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            
                string connectionString = "Data Source=users.db;Version=3;";
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    var command = new SQLiteCommand("SELECT * FROM UserInfo WHERE Username = @username", connection);
                    command.Parameters.AddWithValue("@username", UserSession.Username);

                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "UserInfo.txt");

                                using (StreamWriter writer = new StreamWriter(filePath))
                                {
                                    while (reader.Read())
                                    {
                                        writer.WriteLine("Department of Study: " + reader["Department"]);
                                        writer.WriteLine("Subject: " + reader["Subjects"]);
                                        writer.WriteLine("Comments - Notes: " + reader["Notes"]);
                                        writer.WriteLine("Activities: " + reader["Activities"]);
                                        writer.WriteLine("--------------------");
                                    }
                                }

                                MessageBox.Show("The data was saved to the UserInfo.txt file on the desktop");
                            }
                            else
                            {
                                MessageBox.Show("No user data found");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error exporting data: " + ex.Message);
                    }
                }
            }
        }
    }


 
