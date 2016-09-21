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
using System.IO;
using System.Threading;

namespace betaTesting.UserInterface
{
    public partial class GalleryPictureShow : Form
    {
        DataAccess _da = new DataAccess();
        DataTable photoDataTable;
        Image startImage;
        Thread th;
        
        private int deleteImageIndex = 0;
        private int pictureBoxNumber = 0;
        private int dataTableSize;
        
        public GalleryPictureShow(DataTable photoDataTable,Image startImage,int pictureBoxNumber,int idinfo)
        {
            InitializeComponent();
            this.photoDataTable = photoDataTable;
            dataTableSize = photoDataTable.Rows.Count;
            this.startImage = startImage;

            this.pictureBoxNumber = pictureBoxNumber;
            this.deleteImageIndex = idinfo;
        }

        private void GalleryPictureShow_Load(object sender, EventArgs e)
        {
            GalleryPictureShow_Custom_Load();
            
        }


        private void GalleryPictureShow_Custom_Load()
        {
            try
            {
                byte[] ap = (byte[])(photoDataTable.Rows[pictureBoxNumber][2]);
                MemoryStream ms = new MemoryStream(ap);
                startImage = Image.FromStream(ms);
                ms.Close();

                th = new Thread(openNewForm1);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            catch(Exception e)
            {

            }
        }
        private void openNewForm1()
        {
            try
            {
                Application.Run(new ImageSlideShow(startImage));
            }
            catch (Exception e)
            {

            }
           
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBoxNumber == 0)
            {
                pictureBoxNumber = dataTableSize - 1;
            }
            else
            {
                pictureBoxNumber--;
            }

            th.Abort();
            GalleryPictureShow_Custom_Load();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(pictureBoxNumber==dataTableSize-1)
            {
                pictureBoxNumber = 0;
            }
            else
            {
                pictureBoxNumber++;
            }
            
            th.Abort();
            GalleryPictureShow_Custom_Load();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            th.Abort();
            this.Close();
        }
        private void openRecovery()
        {
            Application.Run(new GalleryShow(Convert.ToInt32(photoDataTable.Rows[0][1])));
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command1 = new SqlCommand("delete FROM notePicture where id=" + Convert.ToInt32(photoDataTable.Rows[pictureBoxNumber][0]));
                _da.Query(command1);

                FormCollection fc = Application.OpenForms;



                foreach (Form frm in fc)
                {
                    if (frm is ImageSlideShow)
                    {
                        frm.Close();
                        break;
                    }
                }
                this.Close();
                foreach (Form frm in fc)
                {
                    if (frm is GalleryShow)
                    {
                        frm.Close();
                        break;
                    }
                }
                this.Close();
                Thread newTh;
                newTh = new Thread(openRecovery);
                newTh.SetApartmentState(ApartmentState.STA);
                newTh.Start();
            }
            catch (Exception ee)
            {

            }
        }
    }
}
