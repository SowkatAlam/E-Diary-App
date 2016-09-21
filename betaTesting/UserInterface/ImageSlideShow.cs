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
    public partial class ImageSlideShow : Form
    {
        private Image currentImage;
        public ImageSlideShow(Image currentImage)
        {
            InitializeComponent();
            this.currentImage = currentImage;
        }

        private void ImageSlideShow_Load(object sender, EventArgs e)
        {

            pictureBox1.BackgroundImage = currentImage;
  
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
