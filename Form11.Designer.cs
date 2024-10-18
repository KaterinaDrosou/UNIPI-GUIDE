namespace UNIPI_GUIDE
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxComments
            // 
            this.listBoxComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.ItemHeight = 20;
            this.listBoxComments.Location = new System.Drawing.Point(12, 50);
            this.listBoxComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(941, 144);
            this.listBoxComments.TabIndex = 0;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(12, 283);
            this.txtComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(941, 50);
            this.txtComment.TabIndex = 1;
            // 
            // btnAddComment
            // 
            this.btnAddComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnAddComment.Location = new System.Drawing.Point(12, 347);
            this.btnAddComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(360, 30);
            this.btnAddComment.TabIndex = 2;
            this.btnAddComment.Text = "Submit Comment";
            this.btnAddComment.UseVisualStyleBackColor = true;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // button1
            // 
            this.button1.Image = global::UNIPI_GUIDE.Properties.Resources.left_arrow1;
            this.button1.Location = new System.Drawing.Point(16, 398);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 57);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Comments/Reviews";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(15, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(547, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Enter your comment and then press \"Submit Comment\":";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UNIPI_GUIDE.Properties.Resources.papei_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 532);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddComment);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.listBoxComments);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comments";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }

}

        #endregion
    