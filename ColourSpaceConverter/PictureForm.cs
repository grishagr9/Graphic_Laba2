using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColourSpaceConverter
{
    public partial class PictureForm : Form
    {
        public PictureForm(Bitmap bitmap)
        {
            InitializeComponent();
            pictureBox1.Image = bitmap;
            int w = bitmap.Width;
            int h = bitmap.Height;
            this.Size = new Size(w + pictureBox1.Location.X * 3, h + 89 + pictureBox1.Location.Y);
            pictureBox1.Size = new Size(w + pictureBox1.Location.X * 3, h + 89 + pictureBox1.Location.Y);

        }

        private void PictureForm_Load(object sender, EventArgs e)
        {

        }
    }
}
