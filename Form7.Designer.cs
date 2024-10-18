namespace UNIPI_GUIDE
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IMTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.παροχέςΠροςΦοιτητέςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.δραστηριότητεςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SignLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(364, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Announcements - Events";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(47, 199);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.richTextBox1.Location = new System.Drawing.Point(539, 199);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(497, 251);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeToolStripMenuItem,
            this.HistoryToolStripMenuItem,
            this.DepToolStripMenuItem,
            this.ServicesToolStripMenuItem,
            this.CalToolStripMenuItem,
            this.SignLoginToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.userProfileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1121, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HomeToolStripMenuItem
            // 
            this.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem";
            this.HomeToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.HomeToolStripMenuItem.Text = "Home page";
            this.HomeToolStripMenuItem.Click += new System.EventHandler(this.HomeToolStripMenuItem_Click);
            // 
            // HistoryToolStripMenuItem
            // 
            this.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem";
            this.HistoryToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.HistoryToolStripMenuItem.Text = "History";
            this.HistoryToolStripMenuItem.Click += new System.EventHandler(this.HistoryToolStripMenuItem_Click);
            // 
            // DepToolStripMenuItem
            // 
            this.DepToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfToolStripMenuItem,
            this.IMTToolStripMenuItem});
            this.DepToolStripMenuItem.Name = "DepToolStripMenuItem";
            this.DepToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.DepToolStripMenuItem.Text = "Departments";
            // 
            // InfToolStripMenuItem
            // 
            this.InfToolStripMenuItem.Name = "InfToolStripMenuItem";
            this.InfToolStripMenuItem.Size = new System.Drawing.Size(354, 26);
            this.InfToolStripMenuItem.Text = "Informatics";
            this.InfToolStripMenuItem.Click += new System.EventHandler(this.InfToolStripMenuItem_Click);
            // 
            // IMTToolStripMenuItem
            // 
            this.IMTToolStripMenuItem.Name = "IMTToolStripMenuItem";
            this.IMTToolStripMenuItem.Size = new System.Drawing.Size(354, 26);
            this.IMTToolStripMenuItem.Text = "Industrial Management and Technology";
            this.IMTToolStripMenuItem.Click += new System.EventHandler(this.IMTToolStripMenuItem_Click);
            // 
            // ServicesToolStripMenuItem
            // 
            this.ServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.παροχέςΠροςΦοιτητέςToolStripMenuItem,
            this.δραστηριότητεςToolStripMenuItem});
            this.ServicesToolStripMenuItem.Name = "ServicesToolStripMenuItem";
            this.ServicesToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.ServicesToolStripMenuItem.Text = "Services";
            // 
            // παροχέςΠροςΦοιτητέςToolStripMenuItem
            // 
            this.παροχέςΠροςΦοιτητέςToolStripMenuItem.Name = "παροχέςΠροςΦοιτητέςToolStripMenuItem";
            this.παροχέςΠροςΦοιτητέςToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.παροχέςΠροςΦοιτητέςToolStripMenuItem.Text = "Παροχές προς Φοιτητές";
            this.παροχέςΠροςΦοιτητέςToolStripMenuItem.Click += new System.EventHandler(this.BenToolStripMenuItem_Click);
            // 
            // δραστηριότητεςToolStripMenuItem
            // 
            this.δραστηριότητεςToolStripMenuItem.Name = "δραστηριότητεςToolStripMenuItem";
            this.δραστηριότητεςToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.δραστηριότητεςToolStripMenuItem.Text = "Δραστηριότητες";
            this.δραστηριότητεςToolStripMenuItem.Click += new System.EventHandler(this.ActToolStripMenuItem_Click);
            // 
            // CalToolStripMenuItem
            // 
            this.CalToolStripMenuItem.Name = "CalToolStripMenuItem";
            this.CalToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.CalToolStripMenuItem.Text = "Events";
            // 
            // SignLoginToolStripMenuItem
            // 
            this.SignLoginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SignToolStripMenuItem,
            this.LoginToolStripMenuItem});
            this.SignLoginToolStripMenuItem.Name = "SignLoginToolStripMenuItem";
            this.SignLoginToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.SignLoginToolStripMenuItem.Text = "Sign up/Login";
            // 
            // SignToolStripMenuItem
            // 
            this.SignToolStripMenuItem.Name = "SignToolStripMenuItem";
            this.SignToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.SignToolStripMenuItem.Text = "Sign up";
            this.SignToolStripMenuItem.Click += new System.EventHandler(this.SignToolStripMenuItem_Click);
            // 
            // LoginToolStripMenuItem
            // 
            this.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
            this.LoginToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.LoginToolStripMenuItem.Text = "Login";
            this.LoginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // userProfileToolStripMenuItem
            // 
            this.userProfileToolStripMenuItem.Name = "userProfileToolStripMenuItem";
            this.userProfileToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.userProfileToolStripMenuItem.Text = "User Profile";
            this.userProfileToolStripMenuItem.Click += new System.EventHandler(this.userProfileToolStripMenuItem_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelWelcome.Location = new System.Drawing.Point(535, 473);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(64, 20);
            this.labelWelcome.TabIndex = 7;
            this.labelWelcome.Text = "Visitor";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UNIPI_GUIDE.Properties.Resources.papei_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1121, 564);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IMTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem παροχέςΠροςΦοιτητέςToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem δραστηριότητεςToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SignLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userProfileToolStripMenuItem;
        private System.Windows.Forms.Label labelWelcome;
    }
}