namespace betaTesting
{
    partial class ReviewGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewGUI));
            this.AllNotesButton = new System.Windows.Forms.Button();
            this.RecentNotesButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchTextButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.allNotesLabel = new System.Windows.Forms.Label();
            this.recentNotesLabel = new System.Windows.Forms.Label();
            this.searchNotesLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllNotesButton
            // 
            this.AllNotesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AllNotesButton.BackgroundImage")));
            this.AllNotesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AllNotesButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllNotesButton.Location = new System.Drawing.Point(0, 106);
            this.AllNotesButton.Name = "AllNotesButton";
            this.AllNotesButton.Size = new System.Drawing.Size(152, 38);
            this.AllNotesButton.TabIndex = 3;
            this.AllNotesButton.Text = "All Notes";
            this.AllNotesButton.UseVisualStyleBackColor = true;
            this.AllNotesButton.Click += new System.EventHandler(this.AllNotesButton_Click);
            // 
            // RecentNotesButton
            // 
            this.RecentNotesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RecentNotesButton.BackgroundImage")));
            this.RecentNotesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RecentNotesButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecentNotesButton.Location = new System.Drawing.Point(0, 180);
            this.RecentNotesButton.Name = "RecentNotesButton";
            this.RecentNotesButton.Size = new System.Drawing.Size(152, 37);
            this.RecentNotesButton.TabIndex = 4;
            this.RecentNotesButton.Text = "Recent Notes";
            this.RecentNotesButton.UseVisualStyleBackColor = true;
            this.RecentNotesButton.Click += new System.EventHandler(this.RecentNotesButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.searchTextButton);
            this.panel1.Controls.Add(this.RecentNotesButton);
            this.panel1.Controls.Add(this.AllNotesButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 511);
            this.panel1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(0, 282);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 24);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchTextButton
            // 
            this.searchTextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchTextButton.BackgroundImage")));
            this.searchTextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchTextButton.Enabled = false;
            this.searchTextButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextButton.Image = global::betaTesting.Properties.Resources.Zoom_icon;
            this.searchTextButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.searchTextButton.Location = new System.Drawing.Point(0, 250);
            this.searchTextButton.Name = "searchTextButton";
            this.searchTextButton.Size = new System.Drawing.Size(152, 37);
            this.searchTextButton.TabIndex = 5;
            this.searchTextButton.Text = "Search";
            this.searchTextButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Magneto", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(337, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "Review Notes";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 57);
            this.button2.TabIndex = 7;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // allNotesLabel
            // 
            this.allNotesLabel.BackColor = System.Drawing.Color.Transparent;
            this.allNotesLabel.Font = new System.Drawing.Font("Magneto", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allNotesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.allNotesLabel.Location = new System.Drawing.Point(349, 69);
            this.allNotesLabel.Name = "allNotesLabel";
            this.allNotesLabel.Size = new System.Drawing.Size(156, 37);
            this.allNotesLabel.TabIndex = 7;
            this.allNotesLabel.Text = "All Notes";
            // 
            // recentNotesLabel
            // 
            this.recentNotesLabel.BackColor = System.Drawing.Color.Transparent;
            this.recentNotesLabel.Font = new System.Drawing.Font("Magneto", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentNotesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.recentNotesLabel.Location = new System.Drawing.Point(329, 69);
            this.recentNotesLabel.Name = "recentNotesLabel";
            this.recentNotesLabel.Size = new System.Drawing.Size(191, 37);
            this.recentNotesLabel.TabIndex = 8;
            this.recentNotesLabel.Text = "Recent Notes";
            // 
            // searchNotesLabel
            // 
            this.searchNotesLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchNotesLabel.Font = new System.Drawing.Font("Magneto", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchNotesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.searchNotesLabel.Location = new System.Drawing.Point(319, 69);
            this.searchNotesLabel.Name = "searchNotesLabel";
            this.searchNotesLabel.Size = new System.Drawing.Size(269, 37);
            this.searchNotesLabel.TabIndex = 9;
            // 
            // ReviewGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.searchNotesLabel);
            this.Controls.Add(this.recentNotesLabel);
            this.Controls.Add(this.allNotesLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "ReviewGUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReviewGUI";
            this.Load += new System.EventHandler(this.ReviewGUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Button AllNotesButton;
        private System.Windows.Forms.Button RecentNotesButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchTextButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label allNotesLabel;
        private System.Windows.Forms.Label recentNotesLabel;
        private System.Windows.Forms.Label searchNotesLabel;
    }
}