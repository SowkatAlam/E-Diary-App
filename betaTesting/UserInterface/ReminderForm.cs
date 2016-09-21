using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace betaTesting
{
    public partial class ReminderForm : Form
    {
        private string  ss;
        public ReminderForm(string s)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(300, 200);
            ss = s;
            richTextBox1.Text = ss;
            richTextBox1.ReadOnly = true;
        }

        
       
        private void ReminderForm_Load(object sender, EventArgs e)
        {

        }

        private void reminderFormLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
