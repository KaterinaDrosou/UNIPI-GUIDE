using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace UNIPI_GUIDE
{
    public partial class Form10 : Form
    {
        bool sidebarExpand;
        bool expand = false; // for dropdownContainer

        // Array of image file paths
        private SpeechSynthesizer synthesizer;
        private string[] imagePaths = { "images/unipi1.jpg", "images/unipi2.jpg", "images/unipi3.jpg", "images/unipi4.jpg", "images/unipi5.jpg", "images/unipi6.jpg", "images/unipi7.png", "images/unipi8.png", "images/unipi9.jpg", "images/unipi10.jpg" };
        private int currentImageIndex = 0;
        private Timer timer;
        public Form10()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form10_Load);
            // Set up the PictureBox
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // Set up the Timer
            timer = new Timer();
            timer.Interval = 2000; // 2000 milliseconds = 2 seconds
            timer.Tick += SlideshowTimer_Tick;
            timer.Start();
            synthesizer = new SpeechSynthesizer();

            // Load the first image
            LoadImage();

            // Timer setup
            animationTimer = new Timer();
            animationTimer.Interval = 5000;  // 5 seconds interval
            animationTimer.Tick += animationTimer_Tick;
            animationTimer.Start();
            SpeakHello();

        }
        private void Form10_Load(object sender, EventArgs e)
        {
            if (!UserSession.IsLoggedIn)
            {
                labelWelcome.Text = $"Welcome Guest!";
                buttonUserProfile.Visible = true; 
                //menuItemUserProfile.Visible = true; 
            }
            else
            {
                // Load user-specific data and settings
                labelWelcome.Text = $"Welcome, {UserSession.Username}!";
            }
        }

        // Button Click Event
        private void buttonUserProfile_Click(object sender, EventArgs e)
        {
            Form13 userProfileForm = new Form13();
            userProfileForm.Show();
        }

        // Menu Item Click Event
        private void menuItemUserProfile_Click(object sender, EventArgs e)
        {
            Form13 userProfileForm = new Form13();
            userProfileForm.Show();
        }

        //sidebar 
        private void sidebarAnimation_Tick(object sender, EventArgs e)
        {
            // SET min and max size for sidebar
            if (sidebarExpand)
            {
                Sidebar.Width -= 10;
                if (Sidebar.Width == Sidebar.MinimumSize.Width)
                {
                    // if sidebar is expand, minimize
                    sidebarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                Sidebar.Width += 10;
                if (Sidebar.Width == Sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        //dropdown Container
        private void dropdownTimer_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                dropdownContainer.Height += 15;
                if (dropdownContainer.Height >= dropdownContainer.MaximumSize.Height)
                {
                    dropdownTimer.Stop();
                    expand = true;
                }
            }
            else
            {
                dropdownContainer.Height -= 15;
                if (dropdownContainer.Height <= dropdownContainer.MinimumSize.Height)
                {
                    dropdownTimer.Stop();
                    expand = false;
                }
            }
        }

        private void buttonServices_Click(object sender, EventArgs e)
        {
            dropdownTimer.Start();
        }

        private void buttonBen_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void buttonAct_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }


        //slideshow
        private void SlideshowTimer_Tick(object sender, EventArgs e)
        {
            // Update the image index
            currentImageIndex = (currentImageIndex + 1) % imagePaths.Length;

            // Load the next image
            LoadImage();
        }

        private void LoadImage()
        {
            // Set the image to the PictureBox
            Slideshow.Image = Image.FromFile(imagePaths[currentImageIndex]);
        }

        // dropdown Department
        private void dropdownDept_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                dropdown2.Height += 15;
                if (dropdown2.Height >= dropdown2.MaximumSize.Height)
                {
                    dropdownDept.Stop();
                    expand = true;
                }
            }
            else
            {
                dropdown2.Height -= 15;
                if (dropdown2.Height <= dropdown2.MinimumSize.Height)
                {
                    dropdownDept.Stop();
                    expand = false;
                }
            }
        }

        private void buttonDep_Click(object sender, EventArgs e)
        {
            dropdownDept.Start();
        }

        private void buttonInf_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void buttonIMT_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void buttonCal_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the application?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            UserSession.Username = null; 
            UserSession.IsLoggedIn = false;

            // Redirect to login form
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void buttonComm_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();

        }
        
        private void animationTimer_Tick(object sender, EventArgs e)
        {
            // Hide picturebox after the defined interval
            pictureBoxChild.Hide();
        }
        private void SpeakHello()
        {

            synthesizer.SelectVoice("Microsoft Zira Desktop");

            synthesizer.SpeakAsync("Welcome to university of Piraeus!");
        }
    }
}
