namespace UNIPI_GUIDE
{
    partial class Form13
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblSubjects = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblActivities = new System.Windows.Forms.Label();
            this.dataGridViewUserInfo = new System.Windows.Forms.DataGridView();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtSubjects = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtActivities = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDepartment.Location = new System.Drawing.Point(27, 25);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(196, 25);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "Department of Study:";
            // 
            // lblSubjects
            // 
            this.lblSubjects.AutoSize = true;
            this.lblSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSubjects.Location = new System.Drawing.Point(27, 74);
            this.lblSubjects.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubjects.Name = "lblSubjects";
            this.lblSubjects.Size = new System.Drawing.Size(84, 25);
            this.lblSubjects.TabIndex = 2;
            this.lblSubjects.Text = "Subject:";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNotes.Location = new System.Drawing.Point(27, 123);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(181, 25);
            this.lblNotes.TabIndex = 4;
            this.lblNotes.Text = "Comments - Notes:";
            // 
            // lblActivities
            // 
            this.lblActivities.AutoSize = true;
            this.lblActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblActivities.Location = new System.Drawing.Point(27, 172);
            this.lblActivities.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivities.Name = "lblActivities";
            this.lblActivities.Size = new System.Drawing.Size(95, 25);
            this.lblActivities.TabIndex = 6;
            this.lblActivities.Text = "Activities:";
            // 
            // dataGridViewUserInfo
            // 
            this.dataGridViewUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserInfo.Location = new System.Drawing.Point(16, 271);
            this.dataGridViewUserInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewUserInfo.Name = "dataGridViewUserInfo";
            this.dataGridViewUserInfo.RowHeadersWidth = 51;
            this.dataGridViewUserInfo.RowTemplate.Height = 24;
            this.dataGridViewUserInfo.Size = new System.Drawing.Size(1013, 246);
            this.dataGridViewUserInfo.TabIndex = 9;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(277, 25);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(675, 22);
            this.txtDepartment.TabIndex = 1;
            // 
            // txtSubjects
            // 
            this.txtSubjects.Location = new System.Drawing.Point(277, 74);
            this.txtSubjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubjects.Name = "txtSubjects";
            this.txtSubjects.Size = new System.Drawing.Size(675, 22);
            this.txtSubjects.TabIndex = 3;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(277, 123);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(675, 22);
            this.txtNotes.TabIndex = 5;
            // 
            // txtActivities
            // 
            this.txtActivities.Location = new System.Drawing.Point(277, 172);
            this.txtActivities.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtActivities.Name = "txtActivities";
            this.txtActivities.Size = new System.Drawing.Size(675, 22);
            this.txtActivities.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(777, 219);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 28);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(644, 542);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(309, 28);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Export Data to .txt";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UNIPI_GUIDE.Properties.Resources.papei_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtActivities);
            this.Controls.Add(this.lblActivities);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtSubjects);
            this.Controls.Add(this.lblSubjects);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.dataGridViewUserInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Profile";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblSubjects;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblActivities;
        private System.Windows.Forms.DataGridView dataGridViewUserInfo;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtSubjects;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtActivities;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExport;
    }
}
