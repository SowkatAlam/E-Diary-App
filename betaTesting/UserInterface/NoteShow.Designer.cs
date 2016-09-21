namespace betaTesting.UserInterface
{
    partial class NoteShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteShow));
            this.button1 = new System.Windows.Forms.Button();
            this.noteShowDeleteButton = new System.Windows.Forms.Button();
            this.noteShowUpdateButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.galleryButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Image = global::betaTesting.Properties.Resources.Arrow_Back_icon;
            this.button1.Location = new System.Drawing.Point(36, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 45);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // noteShowDeleteButton
            // 
            this.noteShowDeleteButton.BackColor = System.Drawing.Color.Khaki;
            this.noteShowDeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.noteShowDeleteButton.Image = global::betaTesting.Properties.Resources.trash_icon;
            this.noteShowDeleteButton.Location = new System.Drawing.Point(250, 442);
            this.noteShowDeleteButton.Name = "noteShowDeleteButton";
            this.noteShowDeleteButton.Size = new System.Drawing.Size(51, 45);
            this.noteShowDeleteButton.TabIndex = 3;
            this.noteShowDeleteButton.UseVisualStyleBackColor = false;
            this.noteShowDeleteButton.Click += new System.EventHandler(this.noteShowDeleteButton_Click);
            // 
            // noteShowUpdateButton
            // 
            this.noteShowUpdateButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.noteShowUpdateButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteShowUpdateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.noteShowUpdateButton.Location = new System.Drawing.Point(116, 443);
            this.noteShowUpdateButton.Name = "noteShowUpdateButton";
            this.noteShowUpdateButton.Size = new System.Drawing.Size(105, 44);
            this.noteShowUpdateButton.TabIndex = 4;
            this.noteShowUpdateButton.Text = "Update";
            this.noteShowUpdateButton.UseVisualStyleBackColor = false;
            this.noteShowUpdateButton.Click += new System.EventHandler(this.noteShowEditButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.previousButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.previousButton.Location = new System.Drawing.Point(489, 405);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(93, 31);
            this.previousButton.TabIndex = 5;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click_1);
            // 
            // galleryButton
            // 
            this.galleryButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.galleryButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.galleryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.galleryButton.Location = new System.Drawing.Point(619, 143);
            this.galleryButton.Name = "galleryButton";
            this.galleryButton.Size = new System.Drawing.Size(136, 60);
            this.galleryButton.TabIndex = 7;
            this.galleryButton.Text = "Gallery";
            this.galleryButton.UseVisualStyleBackColor = false;
            this.galleryButton.Click += new System.EventHandler(this.galleryButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.nextButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.nextButton.Location = new System.Drawing.Point(656, 405);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(99, 31);
            this.nextButton.TabIndex = 8;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(36, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(433, 42);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(36, 143);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(433, 293);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Magneto", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Magneto", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(31, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Description";
            // 
            // NoteShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.galleryButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.noteShowUpdateButton);
            this.Controls.Add(this.noteShowDeleteButton);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NoteShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteShow";
            this.Load += new System.EventHandler(this.NoteShow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button noteShowDeleteButton;
        private System.Windows.Forms.Button noteShowUpdateButton;
        private System.Windows.Forms.Button previousButton;
        
        private System.Windows.Forms.Button galleryButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}