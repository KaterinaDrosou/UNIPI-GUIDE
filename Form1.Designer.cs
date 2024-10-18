using System.Drawing;

namespace UNIPI_GUIDE
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.dropdown2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonDep = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.buttonInf = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.buttonIMT = new System.Windows.Forms.Button();
            this.dropdownContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonServices = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.buttonBen = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.buttonAct = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonCal = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dropdownTimer = new System.Windows.Forms.Timer(this.components);
            this.SlideshowTimer = new System.Windows.Forms.Timer(this.components);
            this.dropdownDept = new System.Windows.Forms.Timer(this.components);
            this.Slideshow = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonComments = new System.Windows.Forms.Button();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonPlay = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.dropdown2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.dropdownContainer.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Slideshow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Sidebar.Controls.Add(this.panel1);
            this.Sidebar.Controls.Add(this.panel2);
            this.Sidebar.Controls.Add(this.panel3);
            this.Sidebar.Controls.Add(this.dropdown2);
            this.Sidebar.Controls.Add(this.dropdownContainer);
            this.Sidebar.Controls.Add(this.panel7);
            this.Sidebar.Controls.Add(this.panel8);
            this.Sidebar.Controls.Add(this.panelLogin);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sidebar.MaximumSize = new System.Drawing.Size(207, 615);
            this.Sidebar.MinimumSize = new System.Drawing.Size(73, 615);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(207, 615);
            this.Sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 69);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(72, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::UNIPI_GUIDE.Properties.Resources.menu;
            this.menuButton.Location = new System.Drawing.Point(20, 16);
            this.menuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(36, 34);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonHome);
            this.panel2.Location = new System.Drawing.Point(3, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 50);
            this.panel2.TabIndex = 1;
            // 
            // buttonHome
            // 
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonHome.Image = global::UNIPI_GUIDE.Properties.Resources.home_button_icon_resized;
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(-20, -18);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(0, 2, 3, 2);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.buttonHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonHome.Size = new System.Drawing.Size(224, 75);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Home page";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHome.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonHistory);
            this.panel3.Location = new System.Drawing.Point(3, 129);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 50);
            this.panel3.TabIndex = 2;
            // 
            // buttonHistory
            // 
            this.buttonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonHistory.Image = global::UNIPI_GUIDE.Properties.Resources.history_line_icon_resized;
            this.buttonHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHistory.Location = new System.Drawing.Point(-20, -9);
            this.buttonHistory.Margin = new System.Windows.Forms.Padding(0, 2, 3, 2);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.buttonHistory.Size = new System.Drawing.Size(228, 75);
            this.buttonHistory.TabIndex = 1;
            this.buttonHistory.Text = "History";
            this.buttonHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // dropdown2
            // 
            this.dropdown2.Controls.Add(this.panel4);
            this.dropdown2.Controls.Add(this.panel11);
            this.dropdown2.Controls.Add(this.panel12);
            this.dropdown2.Location = new System.Drawing.Point(3, 183);
            this.dropdown2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dropdown2.MaximumSize = new System.Drawing.Size(203, 145);
            this.dropdown2.MinimumSize = new System.Drawing.Size(203, 59);
            this.dropdown2.Name = "dropdown2";
            this.dropdown2.Size = new System.Drawing.Size(203, 59);
            this.dropdown2.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonDep);
            this.panel4.Location = new System.Drawing.Point(3, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(195, 50);
            this.panel4.TabIndex = 2;
            // 
            // buttonDep
            // 
            this.buttonDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonDep.Image = global::UNIPI_GUIDE.Properties.Resources.graduation_cap_icon_resized;
            this.buttonDep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDep.Location = new System.Drawing.Point(-23, -5);
            this.buttonDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDep.Name = "buttonDep";
            this.buttonDep.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.buttonDep.Size = new System.Drawing.Size(228, 75);
            this.buttonDep.TabIndex = 1;
            this.buttonDep.Text = "Departments";
            this.buttonDep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDep.UseVisualStyleBackColor = true;
            this.buttonDep.Click += new System.EventHandler(this.buttonDep_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.buttonInf);
            this.panel11.Location = new System.Drawing.Point(3, 56);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(195, 38);
            this.panel11.TabIndex = 7;
            // 
            // buttonInf
            // 
            this.buttonInf.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonInf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonInf.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInf.Location = new System.Drawing.Point(-11, -15);
            this.buttonInf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInf.Name = "buttonInf";
            this.buttonInf.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.buttonInf.Size = new System.Drawing.Size(240, 65);
            this.buttonInf.TabIndex = 1;
            this.buttonInf.Text = "Informatics";
            this.buttonInf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInf.UseVisualStyleBackColor = false;
            this.buttonInf.Click += new System.EventHandler(this.buttonInf_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.buttonIMT);
            this.panel12.Location = new System.Drawing.Point(3, 98);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(195, 41);
            this.panel12.TabIndex = 8;
            // 
            // buttonIMT
            // 
            this.buttonIMT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonIMT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonIMT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonIMT.Location = new System.Drawing.Point(-40, -23);
            this.buttonIMT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIMT.Name = "buttonIMT";
            this.buttonIMT.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.buttonIMT.Size = new System.Drawing.Size(240, 85);
            this.buttonIMT.TabIndex = 1;
            this.buttonIMT.Text = "Industrial Management and Technology";
            this.buttonIMT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIMT.UseVisualStyleBackColor = false;
            this.buttonIMT.Click += new System.EventHandler(this.buttonIMT_Click);
            // 
            // dropdownContainer
            // 
            this.dropdownContainer.Controls.Add(this.panel5);
            this.dropdownContainer.Controls.Add(this.panel9);
            this.dropdownContainer.Controls.Add(this.panel10);
            this.dropdownContainer.Location = new System.Drawing.Point(3, 246);
            this.dropdownContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dropdownContainer.MaximumSize = new System.Drawing.Size(203, 155);
            this.dropdownContainer.MinimumSize = new System.Drawing.Size(203, 52);
            this.dropdownContainer.Name = "dropdownContainer";
            this.dropdownContainer.Size = new System.Drawing.Size(203, 52);
            this.dropdownContainer.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonServices);
            this.panel5.Location = new System.Drawing.Point(3, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(195, 50);
            this.panel5.TabIndex = 3;
            // 
            // buttonServices
            // 
            this.buttonServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonServices.Image = global::UNIPI_GUIDE.Properties.Resources.crowd_icon_resized;
            this.buttonServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonServices.Location = new System.Drawing.Point(-23, -9);
            this.buttonServices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonServices.Name = "buttonServices";
            this.buttonServices.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.buttonServices.Size = new System.Drawing.Size(228, 75);
            this.buttonServices.TabIndex = 1;
            this.buttonServices.Text = "Services";
            this.buttonServices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonServices.UseVisualStyleBackColor = true;
            this.buttonServices.Click += new System.EventHandler(this.buttonServices_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.buttonBen);
            this.panel9.Location = new System.Drawing.Point(3, 56);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(195, 41);
            this.panel9.TabIndex = 4;
            // 
            // buttonBen
            // 
            this.buttonBen.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonBen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonBen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBen.Location = new System.Drawing.Point(-13, -9);
            this.buttonBen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBen.Name = "buttonBen";
            this.buttonBen.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.buttonBen.Size = new System.Drawing.Size(219, 62);
            this.buttonBen.TabIndex = 1;
            this.buttonBen.Text = "Benefits to Students";
            this.buttonBen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBen.UseVisualStyleBackColor = false;
            this.buttonBen.Click += new System.EventHandler(this.buttonBen_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.buttonAct);
            this.panel10.Location = new System.Drawing.Point(3, 101);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(195, 60);
            this.panel10.TabIndex = 5;
            // 
            // buttonAct
            // 
            this.buttonAct.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonAct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAct.Location = new System.Drawing.Point(-11, -7);
            this.buttonAct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAct.Name = "buttonAct";
            this.buttonAct.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.buttonAct.Size = new System.Drawing.Size(240, 71);
            this.buttonAct.TabIndex = 1;
            this.buttonAct.Text = "Activities";
            this.buttonAct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAct.UseVisualStyleBackColor = false;
            this.buttonAct.Click += new System.EventHandler(this.buttonAct_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.buttonCal);
            this.panel7.Location = new System.Drawing.Point(3, 302);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(195, 50);
            this.panel7.TabIndex = 5;
            // 
            // buttonCal
            // 
            this.buttonCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonCal.Image = global::UNIPI_GUIDE.Properties.Resources.calendar_line_icon_resized;
            this.buttonCal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCal.Location = new System.Drawing.Point(-20, -7);
            this.buttonCal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCal.Name = "buttonCal";
            this.buttonCal.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.buttonCal.Size = new System.Drawing.Size(228, 75);
            this.buttonCal.TabIndex = 1;
            this.buttonCal.Text = "Events";
            this.buttonCal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCal.UseVisualStyleBackColor = true;
            this.buttonCal.Click += new System.EventHandler(this.buttonCal_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.buttonExit);
            this.panel8.Location = new System.Drawing.Point(3, 356);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(195, 50);
            this.panel8.TabIndex = 5;
            // 
            // buttonExit
            // 
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonExit.Image = global::UNIPI_GUIDE.Properties.Resources.power_off_line_icon_resized;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(-20, -14);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.buttonExit.Size = new System.Drawing.Size(228, 75);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Location = new System.Drawing.Point(4, 412);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(195, 50);
            this.panelLogin.TabIndex = 8;
            // 
            // buttonLogin
            // 
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonLogin.Image = global::UNIPI_GUIDE.Properties.Resources.id_card_line_icon_resized;
            this.buttonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogin.Location = new System.Drawing.Point(-20, -14);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.buttonLogin.Size = new System.Drawing.Size(228, 75);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // SidebarTimer
            // 
            this.SidebarTimer.Interval = 10;
            this.SidebarTimer.Tick += new System.EventHandler(this.sidebarAnimation_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.richTextBox1.Location = new System.Drawing.Point(208, 11);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(661, 34);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Welcome to University of Piraeus";
            // 
            // dropdownTimer
            // 
            this.dropdownTimer.Interval = 1;
            this.dropdownTimer.Tick += new System.EventHandler(this.dropdownTimer_Tick);
            // 
            // SlideshowTimer
            // 
            this.SlideshowTimer.Tick += new System.EventHandler(this.SlideshowTimer_Tick);
            // 
            // dropdownDept
            // 
            this.dropdownDept.Interval = 1;
            this.dropdownDept.Tick += new System.EventHandler(this.dropdownDept_Tick);
            // 
            // Slideshow
            // 
            this.Slideshow.Location = new System.Drawing.Point(216, 352);
            this.Slideshow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Slideshow.Name = "Slideshow";
            this.Slideshow.Size = new System.Drawing.Size(503, 263);
            this.Slideshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Slideshow.TabIndex = 3;
            this.Slideshow.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UNIPI_GUIDE.Properties.Resources.unipi_logo;
            this.pictureBox1.Location = new System.Drawing.Point(879, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelWelcome.Location = new System.Drawing.Point(209, 48);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(87, 23);
            this.labelWelcome.TabIndex = 4;
            this.labelWelcome.Text = "Visitor";
            // 
            // buttonComments
            // 
            this.buttonComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonComments.Location = new System.Drawing.Point(879, 151);
            this.buttonComments.Margin = new System.Windows.Forms.Padding(4);
            this.buttonComments.Name = "buttonComments";
            this.buttonComments.Size = new System.Drawing.Size(227, 89);
            this.buttonComments.TabIndex = 5;
            this.buttonComments.Text = "See comments and reviews";
            this.buttonComments.UseVisualStyleBackColor = true;
            this.buttonComments.Click += new System.EventHandler(this.buttonComments_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(1008, 582);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(100, 28);
            this.buttonPlay.TabIndex = 11;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(546, 288);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(285, 212);
            this.axWindowsMediaPlayer1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UNIPI_GUIDE.Properties.Resources.papei_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1121, 625);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.buttonComments);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.Slideshow);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Sidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home page";
            this.Sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.dropdown2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.dropdownContainer.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Slideshow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonDep;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonServices;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer SidebarTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button buttonCal;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.FlowLayoutPanel dropdownContainer;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button buttonBen;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button buttonAct;
        private System.Windows.Forms.Timer dropdownTimer;
        private System.Windows.Forms.PictureBox Slideshow;
        private System.Windows.Forms.Timer SlideshowTimer;
        private System.Windows.Forms.FlowLayoutPanel dropdown2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button buttonInf;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button buttonIMT;
        private System.Windows.Forms.Timer dropdownDept;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonComments;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Button buttonPlay;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

