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
    using FastBitmap;
    public partial class RGBToGrayScaleForm : Form
    {
        byte[] saturation;
        public RGBToGrayScaleForm()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var filename = ofd.FileName;
                var bitmap = new Bitmap(filename);
                pictureBox1.Image = bitmap;
                Bitmap bmp = pictureBox1.Image as Bitmap;
                int w = bmp.Width;
                int h = bmp.Height;
                Rectangle rect = new Rectangle(0, 0, w, h);
                this.Size = new Size(w+pictureBox1.Location.X*3, h+89+pictureBox1.Location.Y);

                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
            }
        }

        private void hdtv_gs(Bitmap bitmap)
        {
            using (var fastBitmap = new FastBitmap(bitmap))
            {
                for (var x = 0; x < fastBitmap.Width; x++)
                    for (var y = 0; y < fastBitmap.Height; y++)
                    {
                        var color = fastBitmap[x, y];
                        double R, G, B;
                        R = G = B = 0.0722 * color.B + 0.7152 * color.G + 0.2126 * color.R;
                        fastBitmap[x, y] = Color.FromArgb(
                            (int)R, (int)G, (int)B
                        );
                    }
            }
        }

        private void hdtv2(Bitmap bitmap)
        {
            using (var fastBitmap = new FastBitmap(bitmap))
            {
                for (var x = 0; x < fastBitmap.Width; x++)
                    for (var y = 0; y < fastBitmap.Height; y++)
                    {
                        var color = fastBitmap[x, y];
                        double R, G, B;
                        //R = G = B = 0.114 * color.B + 0.587 * color.G + 0.299 * color.R;
                        R = G = B = 0.3333 * color.B + 0.3333 * color.G + 0.3333 * color.R;
                        fastBitmap[x, y] = Color.FromArgb(
                            (int)R, (int)G, (int)B
                        );
                    }
            }
        }

        private void diff(Bitmap bitmap)
        {
            using (var fastBitmap = new FastBitmap(bitmap))
            {
                for (var x = 0; x < fastBitmap.Width; x++)
                    for (var y = 0; y < fastBitmap.Height; y++)
                    {
                        var color = fastBitmap[x, y];
                        double R, G, B;
                        double R1, G1, B1;
                      
                        R1 = G1 = B1 = 0.114 * color.B + 0.587 * color.G + 0.299 * color.R;
                        R = G = B = 0.0722 * color.B + 0.7152 * color.G + 0.2126 * color.R;
                        //R1 = G1 = B1 = 0.3333 * color.B + 0.3333 * color.G + 0.3333 * color.R;
                        double dif = R - R1 + 0.3819 * 255;
                        fastBitmap[x, y] = Color.FromArgb(
                            (int)dif, (int)dif, (int)dif
                        );
                    }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap hdtv = pictureBox1.Image.Clone() as Bitmap;
            hdtv_gs(hdtv);
            var newForm = new PictureForm(hdtv);
            newForm.Text = "Greyscale(HDTV)";
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap hdtv = pictureBox1.Image.Clone() as Bitmap;
            hdtv2(hdtv);
            var newForm = new PictureForm(hdtv);
            newForm.Text = "Greyscale(simple)";
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap hdtv = pictureBox1.Image.Clone() as Bitmap;
            diff(hdtv);
            var newForm = new PictureForm(hdtv);
            newForm.Text = "Greyscale(diff)";
            newForm.Show();
        }

        private Bitmap GShist(Bitmap bmp)
        {
            saturation = new byte[256];

            for (int i = 0; i < bmp.Width; ++i)
                for (int j = 0; j < bmp.Height; ++j)
                {
                    Color color = bmp.GetPixel(i, j);
                    ++saturation[color.R];
                }

            int width = 256, height = 300;

            Bitmap histogram = new Bitmap(width, height);

            int max_saturation = saturation.Max();

            double point = (double)max_saturation / height;

            for (int i = 0; i < width; ++i)
            {
                for (int j = height - 1; j > height - saturation[i] / point; --j)
                {
                    histogram.SetPixel(i, j, Color.Black);
                }
            }

            return histogram;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bmp = pictureBox1.Image.Clone() as Bitmap;
            hdtv_gs(bmp);

            var newForm = new PictureForm(GShist(bmp));
            newForm.Text = "Histogram(HDTV)";
            newForm.Show();
        }
    }
}
