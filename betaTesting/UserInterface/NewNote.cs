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
using betaTesting.DataLayer;
using System.IO;
using betaTesting.FrameWork;

namespace betaTesting
{
    //[id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    public partial class NewNote : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlParameter picture;
        int nextid;
        DataAccess _da = new DataAccess();
        bool saveButtonClicked = false;
        public NewNote()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(300, 200);

            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
        }

        

        private void createNoteTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            saveNoteButton.Enabled = true;
            createNoteWriteNoteTextBox.AppendText("");
            
        }
       

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

        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if ((e.CloseReason == CloseReason.UserClosing|| e.CloseReason == CloseReason.WindowsShutDown)&&saveButtonClicked==false)
            {
                SqlCommand command = new SqlCommand("delete FROM notePicture where noteTitleDescriptionId= " + nextid);
                _da.Query(command);
            }
        }



        private void Form2_Load(object sender, EventArgs e)
        {

            cn.ConnectionString = "Data Source=DESKTOP-DME6Q27;Initial Catalog=mydatabase;Integrated Security=True";
            cmd.Connection = cn;
            label1.Text = "";
            picture = new SqlParameter("@picture", SqlDbType.Image);
        }
        private void saveNoteButton_Click(object sender, EventArgs e)
        {
            StreamReader readtext = new StreamReader("nextidkeeper.txt");
            nextid = int.Parse(readtext.ReadLine());
            readtext.Close();
            nextid++;
            StreamWriter writetext = new StreamWriter("nextidkeeper.txt");
            writetext.WriteLine(nextid);
            writetext.Close();
            saveButtonClicked = true;
            NewNoteData newNoteData = new NewNoteData(richTextBox1.Text, createNoteWriteNoteTextBox.Text);
            Thread th;
            this.Close();

            th = new Thread(openNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            saveNoteButton.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            saveNoteButton.Enabled = true;
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

        
        private void getautoid()
        {
            StreamReader readtext = new StreamReader("nextidkeeper.txt");
            nextid = int.Parse(readtext.ReadLine());
            readtext.Close();
        }
        
        private void savepicture()
        {
            if (pictureBox1.Image != null)
            {
                getautoid();
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] a = ms.GetBuffer();
                ms.Close();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@picture", a);
                cmd.Parameters.AddWithValue("@noteTitleDescriptionId", nextid);
                cmd.CommandText = "insert into notePicture (noteTitleDescriptionId,picture) values (@noteTitleDescriptionId,@picture)";
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                pictureBox1.Image = null;
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            open();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            savepicture();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
