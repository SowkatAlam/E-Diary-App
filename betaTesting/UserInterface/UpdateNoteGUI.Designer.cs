namespace betaTesting.UserInterface
{
    partial class UpdateNoteGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateNoteGUI));
            this.updateNoteButton = new System.Windows.Forms.Button();
            this.updateNoteDescriptionBox = new System.Windows.Forms.RichTextBox();
            this.updateNoteTItleBox = new System.Windows.Forms.RichTextBox();
            this.updateNoteBackButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.galleryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // updateNoteButton
            // 
            this.updateNoteButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.updateNoteButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateNoteButton.Location = new System.Drawing.Point(153, 447);
            this.updateNoteButton.Name = "updateNoteButton";
            this.updateNoteButton.Size = new System.Drawing.Size(132, 43);
            this.updateNoteButton.TabIndex = 0;
            this.updateNoteButton.Text = "Update Note";
            this.updateNoteButton.UseVisualStyleBackColor = false;
            this.updateNoteButton.Click += new System.EventHandler(this.updateNoteButton_Click);
            // 
            // updateNoteDescriptionBox
            // 
            this.updateNoteDescriptionBox.Location = new System.Drawing.Point(74, 181);
            this.updateNoteDescriptionBox.Name = "updateNoteDescriptionBox";
            this.updateNoteDescriptionBox.Size = new System.Drawing.Size(475, 245);
            this.updateNoteDescriptionBox.TabIndex = 2;
            this.updateNoteDescriptionBox.Text = "";
            // 
            // updateNoteTItleBox
            // 
            this.updateNoteTItleBox.Location = new System.Drawing.Point(74, 102);
            this.updateNoteTItleBox.Name = "updateNoteTItleBox";
            this.updateNoteTItleBox.Size = new System.Drawing.Size(475, 33);
            this.updateNoteTItleBox.TabIndex = 3;
            this.updateNoteTItleBox.Text = "";
            // 
            // updateNoteBackButton
            // 
            this.updateNoteBackButton.BackColor = System.Drawing.Color.Khaki;
            this.updateNoteBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.updateNoteBackButton.Image = global::betaTesting.Properties.Resources.Arrow_Back_icon;
            this.updateNoteBackButton.Location = new System.Drawing.Point(74, 446);
            this.updateNoteBackButton.Name = "updateNoteBackButton";
            this.updateNoteBackButton.Size = new System.Drawing.Size(51, 44);
            this.updateNoteBackButton.TabIndex = 4;
            this.updateNoteBackButton.UseVisualStyleBackColor = false;
            this.updateNoteBackButton.Click += new System.EventHandler(this.updateNoteBackButton_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Magneto", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(320, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 42);
            this.label3.TabIndex = 7;
            this.label3.Text = "Update Note";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Magneto", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(69, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Magneto", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(69, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Description";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(555, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 143);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.nextButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.nextButton.Location = new System.Drawing.Point(673, 395);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(99, 31);
            this.nextButton.TabIndex = 18;
            this.nextButton.Text = "Upload Picture";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.previousButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.previousButton.Location = new System.Drawing.Point(555, 395);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(93, 31);
            this.previousButton.TabIndex = 17;
            this.previousButton.Text = "Save Picture";
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // galleryButton
            // 
            this.galleryButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.galleryButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.galleryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.galleryButton.Location = new System.Drawing.Point(636, 180);
            this.galleryButton.Name = "galleryButton";
            this.galleryButton.Size = new System.Drawing.Size(136, 60);
            this.galleryButton.TabIndex = 19;
            this.galleryButton.Text = "Gallery";
            this.galleryButton.UseVisualStyleBackColor = false;
            this.galleryButton.Click += new System.EventHandler(this.galleryButton_Click);
            // 
            // UpdateNoteGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.galleryButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updateNoteBackButton);
            this.Controls.Add(this.updateNoteTItleBox);
            this.Controls.Add(this.updateNoteDescriptionBox);
            this.Controls.Add(this.updateNoteButton);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UpdateNoteGUI";
            this.Text = "UpdateNoteGUI";
            this.Load += new System.EventHandler(this.UpdateNoteGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateNoteButton;
        private System.Windows.Forms.RichTextBox updateNoteDescriptionBox;
        private System.Windows.Forms.RichTextBox updateNoteTItleBox;
        private System.Windows.Forms.Button updateNoteBackButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button galleryButton;
    }
}