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
    public partial class Form2 : Form
    {
        // List with Historical Events
        private List<HistoricalEvent> events;
        public Form2()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form2_Load);


            // Create and initialize the list of events
            events = new List<HistoricalEvent>
            {
                new HistoricalEvent("1945 - 1966", "1945: It was renamed the Higher School of Industrial Studies and its purpose was defined as the systematic, theoretical and practical training of administrative officers.\r\n" +
                                    "1958: The Higher School of Industrial Studies was renamed the Higher Industrial School and Piraeus was designated as its seat. The course is four years long and the degrees awarded are equal to those of other universities.\r\n" +
                                    "1966: The school functioned as NPDD (Public Law Legal Entity).\r\n"),
                new HistoricalEvent("1971 - 1978", "1971-1972: The studies at the School were separated from the second year into Economics and Organization and Business Administration studies\r\n" +
                                    "1977-1978: The Department of Statistics and Insurance Science begins its operation.\r\n"),
                new HistoricalEvent("1982", "With Law 1268/82, the School initially operated as a single-departmental HEI. The School was organized to include three departments:\r\n\tEconomic Sciences,\r\n\tOrganization and Business Administration and\r\n\tStatistics and Insurance Science\r\n"),
                new HistoricalEvent("1989", "In June 1989, the School was renamed the University of Piraeus, to which three more Departments of Studies were added, namely:\r\n\t Financial and Banking Administration\r\n\tMaritime Studies\r\n\tTechnology and Production Systems\r\n"),
                new HistoricalEvent("1990 - 1991", "From the academic year 1990-1991, to the three already operating Departments (Economic Science, Organization and Business Administration, Statistics and Insurance Science), only the two new ones out of the three foreseen were put into operation.\r\n\tDepartment of Finance and Banking Administration\r\n\tDepartment of Maritime Studies\r\n"),
                new HistoricalEvent("1991 - 2000", "The Department of Industrial Management and Technology started operating from the academic year 1991-1992 as the Department of Technology and Production Systems.\r\n" +
                                    "The Department of Informatics started operating from the academic year 1992-1993.\r\n" +
                                    "The Department of Technology Education began to operate from the academic year 1999-2000, which was renamed the Department of Teaching Technology and Digital Systems. Then, the Department was renamed the Department of Digital Systems.\r\n"),
                new HistoricalEvent("2000 - Today", "The Department of International and European Studies started operating from the academic year 2000-2001.\r\n" +
                                    "The Department of Tourism Studies started operating from the academic year 2017-2018.\r\n")
            };

            // Add years to ListBox
            LoadYearsIntoListBox();
        }
        private void Form2_Load(object sender, EventArgs e)
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

            private void LoadYearsIntoListBox()
        {
            // Clear ListBox
            listBoxYears.Items.Clear();

            // Adding years from the list of events to the ListBox
            foreach (var ev in events)
            {
                listBoxYears.Items.Add(ev); // Add HistoricalEvent items
            }
        }

        // Method to show bulleted description in RichTextBox
        private void DisplayDescriptionWithBullets(string description)
        {
            // Clear RichTextBox
            richTextBoxInfo.Clear();

            // Split description into separate lines (based on '\r\n')
            string[] lines = description.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            // Enable bullets in RichTextBox
            richTextBoxInfo.SelectionBullet = true;

            // Add each line with a bullet
            foreach (string line in lines)
            {
                richTextBoxInfo.AppendText(line + "\r\n");
            }

            // Enable bullets
            richTextBoxInfo.SelectionBullet = false;
        }

        // Internal class about historical events
        private class HistoricalEvent
        {
            public String Year { get; set; }
            public string Description { get; set; }

            public HistoricalEvent(String year, string description)
            {
                Year = year;
                Description = description;
            }

            // ToString returns the date (as a decryption), to be displayed in the ListBox
            public override string ToString()
            {
                return Year;
            }

        }

        // Handle user selection from ListBox
        private void listBoxYears_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Check if a date has been selected
            if (listBoxYears.SelectedItem != null)
            {
                // Get the selected event
                var selectedEvent = (HistoricalEvent)listBoxYears.SelectedItem;

                // Display the description with bullets
                DisplayDescriptionWithBullets(selectedEvent.Description);
            }
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
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

        private void BenefitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void ActToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void CalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
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
                    this.Hide(); }
            } 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the application?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void userProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
        }
    }
}
