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

namespace betaTesting
{
    public partial class ReviewGUI : Form
    {
        DataAccess _da = new DataAccess();
        private static int maxbuttonsize = 500;
        private System.Windows.Forms.Button[] button = new System.Windows.Forms.Button[maxbuttonsize];
        private PictureBox[] p = new PictureBox[maxbuttonsize];
        private int buttonArraySize=0;
        private int xaxis = 250;
        private int x = 250, y = 150;
        Thread th;
        private string titleNote,descriptionNote;
        private int noteId;

       
        public ReviewGUI()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(300, 200);
           
        }
        private void ReviewGUI_Load(object sender, EventArgs e)
        {

            

            Query();
            textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnter);

           
            
        }

       

        //individual data query and  button clicked event start here
        //
        public void Query()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM noteTitleDescription");

            DataTable dt = _da.Query(command);
            
            
            buttonArraySize = dt.Rows.Count;
            for (int i = 0; i < buttonArraySize; i++)
            {
                button[i] = new System.Windows.Forms.Button();

                button[i].Text = (dt.Rows[i][1]).ToString();
                titleNote = (dt.Rows[i][1]).ToString();
                descriptionNote = (dt.Rows[i][2]).ToString();


                p[i] = new PictureBox();
                this.p[i].BackgroundImage = betaTesting.Properties.Resources.n;
                this.p[i].Size = new Size(100, 80);
                
                this.p[i].BackgroundImageLayout = ImageLayout.Stretch;
                this.p[i].Location = new Point(x - 50, y);
                button[i].Location = new System.Drawing.Point(x, y);
                button[i].Size = new System.Drawing.Size(490, 80);
                y += 95;

                
                button[i].Name = "button"+ (dt.Rows[i][0]).ToString();
                
                button[i].TabIndex = 6;
                button[i].Click +=btnClick;
                button[i].UseVisualStyleBackColor = true;
                button[i].BackColor = Color.Moccasin;
                this.Controls.Add(p[i]);

                Controls.Add(button[i]);
            }
            
        }

        public void recentQuery()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM noteTitleDescription");

            DataTable dt = _da.Query(command);
            

            for (int i= buttonArraySize-1,j=1;i>=0&&j<=5;i--,j++)
            {
                button[i] = new System.Windows.Forms.Button();

                button[i].Text = (dt.Rows[i][1]).ToString();
                titleNote = (dt.Rows[i][1]).ToString();
                descriptionNote = (dt.Rows[i][2]).ToString();


                p[i] = new PictureBox();
                this.p[i].BackgroundImage = betaTesting.Properties.Resources.n;
                this.p[i].Size = new Size(100, 80);

                this.p[i].BackgroundImageLayout = ImageLayout.Stretch;
                this.p[i].Location = new Point(x - 50, y);
                button[i].Location = new System.Drawing.Point(x, y);
                button[i].Size = new System.Drawing.Size(490, 80);
                y += 95;

                button[i].Name = "button" + (dt.Rows[i][0]).ToString();
                
                button[i].TabIndex = 6;
                button[i].Click += btnClick;
                button[i].UseVisualStyleBackColor = true;
                button[i].BackColor = Color.Moccasin;
                this.Controls.Add(p[i]);
                Controls.Add(button[i]);

            }

        }

        public void btnClick(object sender, EventArgs e)
        {
            Button tempButton = sender as Button;
            showNote(tempButton.Name);
        }
        private void openNewForm1()
        {
            Application.Run(new NoteShow(noteId));
        }


        public void keywordQuery(string ss)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM noteTitleDescription where Title like '%" + ss + "%'");
            
            DataTable dt = _da.Query(command);
            searchNotesLabel.Text = dt.Rows.Count + " Notes Found";
            searchNotesLabel.Visible = true;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                button[i] = new System.Windows.Forms.Button();

                button[i].Text = (dt.Rows[i][1]).ToString();
                titleNote = (dt.Rows[i][1]).ToString();
                descriptionNote = (dt.Rows[i][2]).ToString();

                p[i] = new PictureBox();
                this.p[i].BackgroundImage = betaTesting.Properties.Resources.n;
                this.p[i].Size = new Size(100, 80);

                this.p[i].BackgroundImageLayout = ImageLayout.Stretch;
                this.p[i].Location = new Point(x - 50, y);
                button[i].Location = new System.Drawing.Point(x, y);
                button[i].Size = new System.Drawing.Size(490, 80);
                y += 95;

                button[i].Name = "button" + (dt.Rows[i][0]).ToString();
               
                button[i].TabIndex = 6;
                button[i].BackColor = Color.Moccasin;
                button[i].Click += btnClick;
                button[i].UseVisualStyleBackColor = true;
               this.Controls.Add(p[i]);
                Controls.Add(button[i]);

            }

        }

        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                
                clear();

                TextBox tt = sender as TextBox;
                recentNotesLabel.Visible = false;
                allNotesLabel.Visible = false;

                x = xaxis;
                y = 150;
                
                keywordQuery(tt.Text.ToString());

            }
        }


        //
        //showNote()
        //
        private void showNote(string buttonName)
        {
            int stringLength = buttonName.Length;
            
            int idOfNote=0;

            for(int i=6;i<stringLength;i++)
            {
                idOfNote = (idOfNote*10) + (int)Char.GetNumericValue(buttonName[i]);
            }
            
            SqlCommand command = new SqlCommand("SELECT * FROM noteTitleDescription where Id="+idOfNote);
            DataTable dt = _da.Query(command);

            titleNote = (dt.Rows[0][1]).ToString();
            descriptionNote = (dt.Rows[0][2]).ToString();
            noteId = Convert.ToInt32(dt.Rows[0][0]);
            this.Close();
            Thread th;
            th = new Thread(openNewForm1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void clear()
        {
            for(int i=0;i<buttonArraySize;i++)
            {
                this.Controls.Remove(p[i]);
                Controls.Remove(button[i]);
            }
        }
        private void AllNotesButton_Click(object sender, EventArgs e)
        {
            clear();
            searchNotesLabel.Visible = false;
            recentNotesLabel.Visible = false;
            allNotesLabel.Visible=true;
            x = xaxis;
            y = 150;
            Query();
        }

        private void RecentNotesButton_Click(object sender, EventArgs e)
        {
            clear();
            allNotesLabel.Visible = false;
            searchNotesLabel.Visible = false;
            recentNotesLabel.Visible = true;
            
            x = xaxis;
            y = 150;
            recentQuery();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }


        //
        // back button code start here
        //
        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
        private void openNewForm()
        {
            Application.Run(new Form1());
        }
        //
    }
}
