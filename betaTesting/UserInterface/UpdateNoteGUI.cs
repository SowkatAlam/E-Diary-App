using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using betaTesting.UserInterface;
using betaTesting.FrameWork;
using System.Data.SqlClient;
using System.Threading;
using System.IO;

namespace betaTesting.UserInterface
{
    public partial class UpdateNoteGUI : Form
    {
        private int noteId;
        DataAccess _da = new DataAccess();
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlParameter picture;
        
        public UpdateNoteGUI(int noteId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(300, 200);
            this.noteId = noteId;
            
        }

        private void UpdateNoteGUI_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM noteTitleDescription where Id="+noteId);
            DataTable dt = _da.Query(command);
            updateNoteTItleBox.Text = (dt.Rows[0][1]).ToString();
            updateNoteDescriptionBox.Text = (dt.Rows[0][2]).ToString();

            cn.ConnectionString = "Data Source=DESKTOP-DME6Q27;Initial Catalog=mydatabase;Integrated Security=True";
            cmd.Connection = cn;
            label1.Text = "";
            picture = new SqlParameter("@picture", SqlDbType.Image);
        }

        private void updateNoteButton_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("update noteTitleDescription set Title = " + updateNoteTItleBox.Text + " Description = " + updateNoteDescriptionBox.Text + " where Id = " + noteId);
            SqlCommand command = new SqlCommand("update noteTitleDescription set Title = '" + updateNoteTItleBox.Text.ToString() + "' , Description = '" + updateNoteDescriptionBox.Text.ToString() + "' where Id = " + noteId);
            _da.Query(command);
            this.Close();
            Thread th;
            th = new Thread(openNote);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }
        private void openNote()
        {
            Application.Run(new NoteShow(this.noteId));
        }
        private void updateNoteBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th;
            th = new Thread(openNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void openNewForm()
        {
            Application.Run(new NoteShow(noteId));
        }




        private void open()
        {
            try
            {

                OpenFileDialog f = new OpenFileDialog();
                f.InitialDirectory = "C:/Picture/";
                f.Filter = "All Files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
                f.FilterIndex = 2;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(f.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                    label1.Text = f.SafeFileName.ToString();
                }
            }
            catch (Exception ee)
            { }
        }



        private void savepicture()
        {
            if (pictureBox1.Image != null)
            {
                
                System.IO.MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] a = ms.GetBuffer();
                ms.Close();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@picture", a);
                cmd.Parameters.AddWithValue("@noteTitleDescriptionId", noteId);
                cmd.CommandText = "insert into notePicture (noteTitleDescriptionId,picture) values (@noteTitleDescriptionId,@picture)";
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                pictureBox1.Image = null;
            }
        }
        

        private void previousButton_Click(object sender, EventArgs e)
        {
            savepicture();
            
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            open();
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
    }
}
