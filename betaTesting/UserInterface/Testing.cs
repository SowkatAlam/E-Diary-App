using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace betaTesting.UserInterface
{
    public partial class Testing : Form
    {
        PictureBox p;
        public Testing()
        {
            InitializeComponent();
            //button1.Background = Brushes.Green;
            p = new PictureBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Testing_Load(object sender, EventArgs e)
        {
            this.p.BackgroundImage = betaTesting.Properties.Resources.n;
            this.p.Size = new Size(200, 200);
            this.p.Location = new Point(0, 100);
            this.p.BackgroundImageLayout = ImageLayout.Stretch;

            this.Controls.Add(p);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}