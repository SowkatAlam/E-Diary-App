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
using betaTesting.UserInterface;
using betaTesting.FrameWork;
using System.Data.SqlClient;
using System.IO;
using betaTesting.Properties;
using System.Resources;

namespace betaTesting
{
    public partial class Form1 : Form
    {
        Thread th;
        private int xaxis, yaxis;
        private PictureBox[] pictureBox = new PictureBox[500];
        private int pictureBoxIndex = 0;
        private int pictureBoxSize = 0;
        DataTable photoDataTable;
        DataAccess _da = new DataAccess();
        Random random = new Random();
        int randomImage;
        private int noteId;

        ResourceManager rm;
        Bitmap myImage;
        private int ii, iii, jj, jjj;
       
        public Form1()
        {

            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(300, 200);
            xaxisyaxiscontrol();
            retrievePictureIntoDataTable();
            if (pictureBoxSize == 0)
            {
                pictureBox1.Visible = true;
            }
            else
            {
                dynamicPictureBox();
                pictureBox1.Visible = false;
                showPictureIntoFrom();
                pictureControl();
            }

        }
        private void dynamicPictureBox()
        {
            ii = random.Next(0, 2);
            iii = random.Next(0, 2);
            while (ii == iii)
            {
                ii = random.Next(0, 2);
                iii = random.Next(0, 2);
            }
            jj = random.Next(0, 2);
            jjj = random.Next(0, 2);


        }
        private void xaxisyaxiscontrol()
        {
            xaxis = 50;
            yaxis = 100;
        }
        private void retrievePictureIntoDataTable()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM notePicture");
            photoDataTable = _da.Query(command);
            pictureBoxSize = photoDataTable.Rows.Count;

        }

        private void showPictureIntoFrom()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    PictureBox temp = this.pictureBox[pictureBoxIndex];
                    //this.Controls.Remove(this.pictureBox[pictureBoxIndex]);
                    this.pictureBox[pictureBoxIndex] = new System.Windows.Forms.PictureBox();

                    this.pictureBox[pictureBoxIndex].Location = new System.Drawing.Point(xaxis, yaxis);
                    if ((i == ii && j == jj) || (i == iii && j == jjj))
                    {
                        this.pictureBox[pictureBoxIndex].Size = new System.Drawing.Size(300, 120);

                    }
                    else
                    {
                        this.pictureBox[pictureBoxIndex].Size = new System.Drawing.Size(150, 120);
                    }

                    this.pictureBox[pictureBoxIndex].TabIndex = 0;
                    this.pictureBox[pictureBoxIndex].TabStop = false;
                    this.pictureBox[pictureBoxIndex].BorderStyle = BorderStyle.Fixed3D;
                    this.pictureBox[pictureBoxIndex].SizeMode = PictureBoxSizeMode.StretchImage;
                    if (pictureBoxSize != 0)
                    {
                        this.pictureBox[pictureBoxIndex].Click += pictureBoxClick;
                    }

                    this.Controls.Add(this.pictureBox[pictureBoxIndex]);
                    this.Controls.Remove(temp);
                    if ((i == ii && j == jj) || (i == iii && j == jjj))
                    {
                        xaxis += 300;
                        j++;
                    }
                    else
                    {
                        xaxis += 150;
                    }

                    if (pictureBoxSize != 0)
                    {
                        loadpicture();
                    }
                    else
                    {
                        load_no_image_picture();
                    }
                    pictureBoxIndex++;
                }
                yaxis += 120;
                xaxis = 50;
            }

        }
        private void pictureBoxClick(object sender, EventArgs e)
        {
            PictureBox tempPictureBox = sender as PictureBox;

            showNote(tempPictureBox.Name);

        }

        private void pictureControl()
        {
            int j = 0;

            timer1.Start();


        }

        private void load_no_image_picture()
        {
            // this.Controls.Remove(this.pictureBox[pictureBoxIndex]);
            MessageBox.Show("hi");
            pictureBox[pictureBoxIndex].Image = Image.FromFile(@"Resources\a.bmp");
            //this.Controls.Add(this.pictureBox[pictureBoxIndex]);
        }

        private void loadpicture()
        {
            this.Controls.Remove(this.pictureBox[pictureBoxIndex]);

            randomImage = random.Next(0, pictureBoxSize);
            this.pictureBox[pictureBoxIndex].Name = "pictureBox" + randomImage;
            byte[] ap = (byte[])(photoDataTable.Rows[randomImage][2]);
            MemoryStream ms = new MemoryStream(ap);
            pictureBox[pictureBoxIndex].Image = Image.FromStream(ms);
            ms.Close();
            this.Controls.Add(this.pictureBox[pictureBoxIndex]);
        }




        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();

            th = new Thread(openNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openNewForm()
        {


            Application.Run(new NewNote());
        }


        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
            timer1.Stop();
            th = new Thread(openNewForm2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();






        }

        private void openNewForm2()
        {
            Application.Run(new RemainderGUI());
        }

        private void openNewForm3()
        {
            Application.Run(new ReviewGUI());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();

            th = new Thread(openNewForm3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();


        }


        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void passwordRecovery_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openRecovery);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openRecovery()
        {
            Application.Run(new UserinformationRecovery(false));
        }

        private void showNote(string buttonName)
        {
            int stringLength = buttonName.Length;

            int idOfNote = 0;

            for (int i = 10; i < stringLength; i++)
            {
                idOfNote = (idOfNote * 10) + (int)Char.GetNumericValue(buttonName[i]);
            }
            int tempinfornote = Convert.ToInt32(photoDataTable.Rows[idOfNote][1]);

            SqlCommand command = new SqlCommand("SELECT * FROM noteTitleDescription where Id=" + tempinfornote);
            DataTable dt = _da.Query(command);

            noteId = Convert.ToInt32(dt.Rows[0][0]);
            this.Close();
            Thread th;
            th = new Thread(openNewForm1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            timer1.Stop();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            dynamicPictureBox();
            pictureBoxIndex = 0;
            xaxisyaxiscontrol();
            for (int k = 0; k < 7; k++)
            {
                this.Controls.Remove(this.pictureBox[k]);
            }
            showPictureIntoFrom();
        }

        private void openNewForm1()
        {
            Application.Run(new NoteShow(noteId));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_2(object sender, EventArgs e)
        {


            

               

            pictureBoxIndex = random.Next(0, 7);
            loadpicture();
        }
    }
}
