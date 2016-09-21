using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using betaTesting.FrameWork;
using System.Data.SqlClient;
using System.Threading;

namespace betaTesting.UserInterface
{
    public partial class UserinformationRecovery : Form
    {
        private bool isRecoveryPressed;
        private DataTable dt;
        DataAccess _da = new DataAccess();
        System.Windows.Forms.Label templabel;
        
        public UserinformationRecovery(bool isRecoveryPressed)
        {
            InitializeComponent();
            this.isRecoveryPressed = isRecoveryPressed;
            templabel = new Label();
            templabel.AutoSize = true;
            templabel.Location = new System.Drawing.Point(50, 400);
            templabel.Size = new System.Drawing.Size(356, 13);
            templabel.TabIndex = 0;
        }

        private void UserinformationRecovery_Load(object sender, EventArgs e)
        {
            if(isRecoveryPressed==true)
            {
                panel2.Visible = false;
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
                panel2.Visible = true;
            }
            retriveDatabase();
        }
        private void retriveDatabase()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM userInformation where id=" + 1);
            dt = _da.Query(command);
        }

        private void submitPanel1_Click(object sender, EventArgs e)
        {
            if (string.Equals(dt.Rows[0][3], textBox1.Text)&&(textBox2.Text!=""&& textBox3.Text != ""&& textBox4.Text != "")&&string.Equals(textBox3.Text,textBox4.Text))
            {
                    SqlCommand command = new SqlCommand("update userInformation set userName = '" + textBox2.Text + "' , password = '" + textBox3.Text + "' where id = " + 1);
                
                    _da.Query(command);
                    this.Close();
                    Thread th;
                    th = new Thread(openSignIn);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
            }
            else
            {
                
                templabel.Text = "Your given information is invalid or wrong . Retry again (Don't keep any information blank)";
                this.Controls.Add(templabel);
            }
        }
        private void openSignIn()
        {
            Application.Run(new SignIn());
        }

        private void openHome()
        {
            Application.Run(new Form1());
        }

        private void submitPanel2_Click(object sender, EventArgs e)
        {
            if (string.Equals(dt.Rows[0][2], textBox5.Text) && (textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != ""&& textBox9.Text != "") && string.Equals(textBox7.Text, textBox8.Text))
            {
                SqlCommand command = new SqlCommand("update userInformation set userName = '" + textBox6.Text + "' , password = '" + textBox7.Text + "' , securityQuestion = '" + textBox9.Text + "' where id = " + 1);

                _da.Query(command);
                this.Close();
                Thread th;
                th = new Thread(openHome);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {

                templabel.Text = "Your given information is invalid or wrong (Give correct password) . Retry again (Don't keep any information blank)";
                this.Controls.Add(templabel);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
