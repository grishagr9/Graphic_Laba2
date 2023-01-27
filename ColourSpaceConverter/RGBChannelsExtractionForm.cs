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

    public partial class RGBChannelsExtractionForm : Form
    {
        public RGBChannelsExtractionForm()
        {
            InitializeComponent();
        }

        private void RGBChannelsExtractionForm_Load(object sender, EventArgs e)
        {

        }

        private void chooseImageButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TrySetImage(ofd.FileName);
            }
        }

        private void TrySetImage(string filename)
        {
            try
            {
                var baseBitmap = new Bitmap(filename);
                var colourChannels = ExctractChannels(baseBitmap);
                var histogramBitmap = CreateHistogram(baseBitmap, histogramPictureBox.Size);
                baseImagePictureBox.Image = baseBitmap;
                redChannelPictureBox.Image = colourChannels[0];
                blueChannelPictureBox.Image = colourChannels[1];
                greenChannelPictureBox.Image = colourChannels[2];
                histogramPictureBox.Image = histogramBitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        private static Bitmap[] ExctractChannels(Bitmap baseBitmap)
        {
            var colourChannels = new Bitmap[3];
            for (int i = 0; i < 3; i++)
            {
                colourChannels[i] = new Bitmap(baseBitmap.Width, baseBitmap.Height);
            }

            using (var fastBaseBitmap = new FastBitmap(baseBitmap))
            using (var fastRedChannelBitmap = new FastBitmap(colourChannels[0]))
            using (var fastGreenChannelBitmap = new FastBitmap(colourChannels[1]))
            using (var fastBlueChannelBitmap = new FastBitmap(colourChannels[2]))
            {
                for (int x = 0; x < baseBitmap.Width; x++)
                {
                    for (int y = 0; y < baseBitmap.Height; y++)
                    {
                        var currentPixelColour = fastBaseBitmap[x, y];
                        fastRedChannelBitmap[x, y] = Color.FromArgb(
                            currentPixelColour.A, currentPixelColour.R, 0, 0);
                        fastGreenChannelBitmap[x, y] = Color.FromArgb(
                            currentPixelColour.A, 0, currentPixelColour.G, 0);
                        fastBlueChannelBitmap[x, y] = Color.FromArgb(
                            currentPixelColour.A, 0, 0, currentPixelColour.B);
                    }
                }
            }

            return colourChannels;
        }

        private static Bitmap CreateHistogram(Bitmap baseBitmap, Size size)
        {
            var histogramBitmap = new Bitmap(size.Width, size.Height);

            var redChannelFrequencies = new int[256];
            var greenChannelFrequencies = new int[256];
            var blueChannelFrequencies = new int[256];

            for (int i = 0; i < 256; i++)
            {
                redChannelFrequencies[i] = 0;
                greenChannelFrequencies[i] = 0;
                blueChannelFrequencies[i] = 0;
            }

            using (var fastBaseBitmap = new FastBitmap(baseBitmap))
            using (var fastHistogramBitmap = new FastBitmap(histogramBitmap))
            {
                int minY = int.MaxValue;
                int maxY = int.MinValue;

                for (int x = 0; x < baseBitmap.Width; x++)
                {
                    for (int y = 0; y < baseBitmap.Height; y++)
                    {
                        var currentPixelColour = fastBaseBitmap[x, y];

                        redChannelFrequencies[currentPixelColour.R] += 1;
                        minY = Math.Min(minY, redChannelFrequencies[currentPixelColour.R]);
                        maxY = Math.Max(maxY, redChannelFrequencies[currentPixelColour.R]);

                        greenChannelFrequencies[currentPixelColour.G] += 1;
                        minY = Math.Min(minY, greenChannelFrequencies[currentPixelColour.G]);
                        maxY = Math.Max(maxY, greenChannelFrequencies[currentPixelColour.G]);

                        blueChannelFrequencies[currentPixelColour.B] += 1;
                        minY = Math.Min(minY, blueChannelFrequencies[currentPixelColour.B]);
                        maxY = Math.Max(maxY, blueChannelFrequencies[currentPixelColour.B]);
                    }
                }

                int stepSize = histogramBitmap.Width / 256;
                for (int x = 0; x < 256; x++)
                {
                    int relativeX = x * stepSize;

                    int relativeY = histogramBitmap.Height - redChannelFrequencies[x] * minY * histogramBitmap.Height / maxY;
                    DrawVerticalLine(fastHistogramBitmap, relativeX, relativeY, Color.Red);

                    relativeY = histogramBitmap.Height - greenChannelFrequencies[x] * minY * histogramBitmap.Height / maxY;
                    DrawVerticalLine(fastHistogramBitmap, relativeX, relativeY, Color.Green);

                    relativeY = histogramBitmap.Height - blueChannelFrequencies[x] * minY * histogramBitmap.Height / maxY;
                    DrawVerticalLine(fastHistogramBitmap, relativeX, relativeY, Color.Blue);
                }
            }

            return histogramBitmap;
        }

        private static void DrawVerticalLine(FastBitmap fastBitmap, int relativeX, int relativeY, Color colour)
        {
            for (int y = fastBitmap.Height - 1; y >= relativeY; y--)
            {
                fastBitmap[relativeX, y] = colour;
            }
        }
    }
}
