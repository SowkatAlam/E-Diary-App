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
using System.IO;

namespace betaTesting.UserInterface
{
    public partial class NoteShow : Form
    {
        
        DataAccess _da = new DataAccess();
        private int noteId;

        // picture box code
        //
        private SqlConnection cn = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();
        
        private System.Windows.Forms.PictureBox pictureBox2;
        DataTable dt;
        DataTable pictureTable;
        private int pictureArraySize = 0;
        private int currentPictureIndex = 0;
        //

        public NoteShow(int noteId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(300, 200);
            
            this.noteId = noteId;
            
        }

        private void NoteShow_Load(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM noteTitleDescription where Id= "+noteId);
            dt = _da.Query(command);
            richTextBox1.Text = (dt.Rows[0][1]).ToString();
            richTextBox2.Text = (dt.Rows[0][2]).ToString();
            richTextBox1.ReadOnly = true;
            richTextBox2.ReadOnly = true;

            //picture box code
            //

            command = new SqlCommand("select * from notePicture where noteTitleDescriptionId=" +noteId);
            pictureTable = _da.Query(command);
            pictureArraySize = pictureTable.Rows.Count;
            pictureBoxLoad();
            //


        }

        // picture boc control code @wahid and sowkat
        //
        private void pictureBoxLoad()
        {
            
            pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox2.Location = new System.Drawing.Point(495, 205);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(257, 192);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(this.pictureBox2);
            loadpicture();
        }
        private void loadpicture()
        {
            if(pictureArraySize!=0)
            {
                byte[] ap = (byte[])(pictureTable.Rows[currentPictureIndex][2]);
                MemoryStream ms = new MemoryStream(ap);
                pictureBox2.Image = Image.FromStream(ms);


                ms.Close();
            }
            
        }

        private void previousButton_Click_1(object sender, EventArgs e)
        {

            currentPictureIndex--;
            if (currentPictureIndex == -1) currentPictureIndex = pictureArraySize - 1;
            loadpicture();
        }

        private void nextButton_Click_1(object sender, EventArgs e)
        {

            
        }
        //


        private void button1_Click(object sender, EventArgs e)
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
        

        private void noteShowEditButton_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();

            th = new Thread(openNewForm1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        

        private void openNewForm1()
        {


            Application.Run(new UpdateNoteGUI(noteId));
        }

        private void noteShowDeleteButton_Click(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("delete FROM notePicture where noteTitleDescriptionId =" + noteId);

            _da.Query(command1);

            SqlCommand command = new SqlCommand("delete FROM noteTitleDescription where Id="+noteId);

            _da.Query(command);

            Thread th;
            this.Close();

            th = new Thread(openNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void galleryButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th;
            th = new Thread(openGalleryShow);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openGalleryShow()
        {
            Application.Run(new GalleryShow(noteId));
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            currentPictureIndex++;
            if (currentPictureIndex == pictureArraySize) currentPictureIndex = 0;
            loadpicture();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
