namespace betaTesting
{
    partial class ReminderSetTimeGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReminderSetTimeGUI));
            this.remainderDataTimePicker = new System.Windows.Forms.DateTimePicker();
            this.remainderMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // remainderDataTimePicker
            // 
            this.remainderDataTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.remainderDataTimePicker.Location = new System.Drawing.Point(127, 110);
            this.remainderDataTimePicker.Name = "remainderDataTimePicker";
            this.remainderDataTimePicker.ShowUpDown = true;
            this.remainderDataTimePicker.Size = new System.Drawing.Size(227, 20);
            this.remainderDataTimePicker.TabIndex = 0;
            this.remainderDataTimePicker.ValueChanged += new System.EventHandler(this.remainderDataTimePicker_ValueChanged);
            // 
            // remainderMonthCalendar
            // 
            this.remainderMonthCalendar.Location = new System.Drawing.Point(127, 151);
            this.remainderMonthCalendar.Name = "remainderMonthCalendar";
            this.remainderMonthCalendar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(503, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Magneto", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Set Reminder Time";
            // 
            // ReminderSetTimeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.remainderMonthCalendar);
            this.Controls.Add(this.remainderDataTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReminderSetTimeGUI";
            this.Text = "ReminderSetTimeGUI";
            this.Load += new System.EventHandler(this.ReminderSetTimeGUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DateTimePicker remainderDataTimePicker;
        public System.Windows.Forms.MonthCalendar remainderMonthCalendar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}