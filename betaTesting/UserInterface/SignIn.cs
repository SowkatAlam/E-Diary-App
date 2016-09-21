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
using System.Data.SqlClient;
using betaTesting.FrameWork;
using betaTesting.UserInterface;

namespace betaTesting.UserInterface
{
    public partial class SignIn : Form
    {
        DataAccess _da = new DataAccess();
        public SignIn()
        {
            InitializeComponent();
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM userInformation where id=" + 1);
                DataTable dt = _da.Query(command);

                if (string.Equals(dt.Rows[0][1], userNameTextBox.Text) && string.Equals(dt.Rows[0][2], passwordTextBox.Text))
                {
                    this.Close();
                    Thread th;
                    th = new Thread(openNewForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();

                }
                else
                {
                    this.warningLable.Text = "User Name or Password is Invalid . Try again";
                    this.warningLable.Visible = true;
                }
            }
            catch (Exception ee)
            {

            }
           
        }
        private void openNewForm()
        {
            Application.Run(new Form1());
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            this.warningLable.Visible = false;
        }

        private void warningLable_Click(object sender, EventArgs e)
        {

        }

        private void accountRecoverButton_Click(object sender, EventArgs e)
        {
           
        }

        private void openRecovery()
        {
            Application.Run(new UserinformationRecovery(true));
        }

        private void accountRecoverButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Thread th;
            th = new Thread(openRecovery);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
