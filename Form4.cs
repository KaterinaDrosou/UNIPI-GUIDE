using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIPI_GUIDE
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form4_Load);

        }
        private void Form4_Load(object sender, EventArgs e)
        {
            if (!UserSession.IsLoggedIn)
            {

                userProfileToolStripMenuItem.Visible = false;
                labelWelcome.Visible = false;
            }
            else
            {
                userProfileToolStripMenuItem.Visible = true;
                labelWelcome.Visible = true;
                labelWelcome.Text = $"You are logged in as: {UserSession.Username}!";
            }
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void HistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void InfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void IMTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void BenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void CalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to exit the application?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void SignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 Form9 = new Form9();
            Form9.Show();
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!UserSession.IsLoggedIn)
            {
                Form8 Form8 = new Form8();
                Form8.Show();
            }
            else
            {
                if (MessageBox.Show("You are already logged in as: " + UserSession.Username + ". Do you want to log out?", "Login",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Handle sign-out logic here
                    UserSession.IsLoggedIn = false;  // Sign out the user
                    Form1 Form1 = new Form1();   // Show login form
                    Form1.Show();
                    this.Hide();
                }
            }
        }

        private void userProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
        }
    }
}
