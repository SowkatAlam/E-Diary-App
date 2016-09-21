using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace betaTesting
{
    public partial class RemainderGUI : Form
    {
        public RemainderGUI()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(300, 200);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Thread th;
            this.Close();

            th = new Thread(openNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openNewForm()
        {
            Application.Run(new Form1());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void RemainderGUI_Load(object sender, EventArgs e)
        {

        }

        private void reminderSetReminderButton_Click(object sender, EventArgs e)
        {
            
        }

        private void remainderMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        private DateTime myRemindTime;
        ReminderSetTimeGUI reminder = new ReminderSetTimeGUI();
        ReminderForm reminderForm;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (reminder.ShowDialog() == DialogResult.OK)
                {
                    reminderForm = new ReminderForm(richTextBox1.Text);
                    myRemindTime = reminder.remainderMonthCalendar.SelectionStart.AddHours(reminder.remainderDataTimePicker.Value.Hour).AddMinutes(reminder.remainderDataTimePicker.Value.Minute).AddSeconds(reminder.remainderDataTimePicker.Value.Second);
                    this.Visible = false;
                }
            }
            catch (Exception eee)
            {

            }
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            try
            {
                if (myRemindTime.CompareTo(DateTime.Now) < 0)
                {
                    reminderForm.Visible = true;

                    reminderForm.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
                   
                }
            }
            catch (Exception eeeee)
            {

            }
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit();
            throw new NotImplementedException();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
