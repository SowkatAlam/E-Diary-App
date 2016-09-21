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
    public partial class GalleryShow : Form
    {
        DataAccess _da = new DataAccess();
        DataTable photoDataTable;
        
        private int noteId=2;
        private int xaxis=20, yaxis=80;
        private PictureBox[] pictureBox=new PictureBox[500];
        private int pictureBoxIndex = 0;
        private int pictureBoxSize = 0;

        public GalleryShow(int noteId)
        {
            InitializeComponent();
            this.noteId = noteId;
        }

        private void GalleryShow_Load(object sender, EventArgs e)
        {
            InitializeCustomComponent();
            retrievePictureIntoDataTable();
            for(;pictureBoxIndex<pictureBoxSize;pictureBoxIndex++)
            {
                showPictureIntoFrom();
            }
        }

        // picture retriving and storing
        //
        private void retrievePictureIntoDataTable()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM notePicture where noteTitleDescriptionId="+noteId);
            photoDataTable= _da.Query(command);
            pictureBoxSize = photoDataTable.Rows.Count;
        }
        private void showPictureIntoFrom()
        {
            if (xaxis + 180 >= 800)
            {
                xaxis = 20; yaxis += 140;
            }
            this.pictureBox[pictureBoxIndex] = new System.Windows.Forms.PictureBox();
            this.pictureBox[pictureBoxIndex].Location = new System.Drawing.Point(xaxis,yaxis);
            this.pictureBox[pictureBoxIndex].Name = "pictureBox"+pictureBoxIndex;
            this.pictureBox[pictureBoxIndex].Size = new System.Drawing.Size(180, 130);
            this.pictureBox[pictureBoxIndex].TabIndex = 0;
            this.pictureBox[pictureBoxIndex].TabStop = false;
            this.pictureBox[pictureBoxIndex].BorderStyle = BorderStyle.Fixed3D;
            this.pictureBox[pictureBoxIndex].SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox[pictureBoxIndex].Click += pictureBoxClick;
            this.Controls.Add(this.pictureBox[pictureBoxIndex]);
            xaxis += 190;
            yaxis += 0;
            loadpicture();
        }
        private void loadpicture()
        {
                byte[] ap = (byte[])(photoDataTable.Rows[pictureBoxIndex][2]);
                MemoryStream ms = new MemoryStream(ap);
                pictureBox[pictureBoxIndex].Image = Image.FromStream(ms);
                ms.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th;
            th = new Thread(openNoteShow);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openNoteShow()
        {
            Application.Run(new NoteShow(noteId));
        }
        //

        private PictureBox tempPictureBox;
        //
        int idOfNote = 0;
        int pictureBoxNumber = 0;
        private void pictureBoxClick(object sender, EventArgs e)
        {
            tempPictureBox= sender as PictureBox;
            int stringLength = tempPictureBox.Name.Length;
            

            for (int i = 10; i < stringLength; i++)
            {
                idOfNote = (idOfNote * 10) + (int)Char.GetNumericValue(tempPictureBox.Name[i]);
            }
            pictureBoxNumber = idOfNote;
            idOfNote = Convert.ToInt32(photoDataTable.Rows[idOfNote][0]);
            Thread th;
            th = new Thread(openNewForm1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openNewForm1()
        {
            
            Application.Run(new GalleryPictureShow(photoDataTable,tempPictureBox.Image,pictureBoxNumber,idOfNote));
            idOfNote = 0;
        }








        // adding custom components
        //
        private void InitializeCustomComponent()
        {
            
        }
        //
    }
}
