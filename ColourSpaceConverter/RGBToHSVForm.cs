using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace ColourSpaceConverter
{
    using FastBitmap;
    
    public partial class RGBToHSVForm : Form
    {
        int tb1 = 100;
        int tb2 = 100;
        int tb3 = 100;

        Bitmap image;
        Bitmap newImage;
        Bitmap newImageHSV;
        public RGBToHSVForm()
        {
            InitializeComponent();
        }
        //загрузить изображение
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    newImage = new Bitmap(660, 526);
                    using (Graphics gr = Graphics.FromImage(newImage))
                    {
                        gr.SmoothingMode = SmoothingMode.HighQuality;
                        gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        gr.DrawImage(image, new Rectangle(0, 0, 660, 526));
                    }
                    pictureBox1.Image = newImage;
                    newImageHSV = new Bitmap(newImage);
                    pictureBox2.Image = newImageHSV;
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //сохранить изображение
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog open_dialog = new SaveFileDialog();
            open_dialog.Filter = "Image Files(*.JPG;*.BMP;*.PNG)|*.JPG;*.BMP;*.PNG";
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    newImageHSV.Save(open_dialog.FileName);
                    MessageBox.Show("Картинка сохранена");
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно сохранить",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //изменить тон
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int Proc = trackBar1.Value;
            using (var fast_newImageHSV = new FastBitmap(newImageHSV))
            {
                for (int x = 0; x < fast_newImageHSV.Width; x++)
                {
                    for (int y = 0; y < fast_newImageHSV.Height; y++)
                    {
                        Color pixelColor = fast_newImageHSV[x, y];
                        int R = pixelColor.R;
                        int G = pixelColor.G;
                        int B = pixelColor.B;
                        int H = ToH(R, G, B);
                        int S = ToS(R, G, B);
                        int V = ToV(R, G, B);

                        
                        if (Proc <= tb1)
                        {
                            H = H * Proc / tb1;
                        }
                        else
                        {
                            H = 360 - H * (200 - Proc) / (200 - tb1);
                        }
                        
                        R = ToR(H, S, V);
                        G = ToG(H, S, V);
                        B = ToB(H, S, V);
                        Color newColor = Color.FromArgb(R, G, B);
                        //newImageHSV.SetPixel(x, y, newColor);
                        fast_newImageHSV[x, y] = newColor;
                    }
                }
            }
            tb1 = Proc;
            if (tb1 == 0)
            {
                tb1 = 1;
            }
            pictureBox2.Image = newImageHSV;
        }
        //изменить насыщенность
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            int Proc = trackBar2.Value;
            using (var fast_newImageHSV = new FastBitmap(newImageHSV))
            {
                for (int x = 0; x < fast_newImageHSV.Width; x++)
            {
                for (int y = 0; y < fast_newImageHSV.Height; y++)
                {
                    Color pixelColor = fast_newImageHSV[x, y];
                    int R = pixelColor.R;
                    int G = pixelColor.G;
                    int B = pixelColor.B;
                    int H = ToH(R, G, B);
                    int S = ToS(R, G, B);
                    int V = ToV(R, G, B);

                    
                    if (Proc <= tb2)
                    {
                        S = S * Proc / tb2;
                    }
                    else
                    {
                        S = 100 - S * (200 - Proc) / (200 - tb2);
                    }
                    
                    R = ToR(H, S, V);
                    G = ToG(H, S, V);
                    B = ToB(H, S, V);
                    Color newColor = Color.FromArgb(R, G, B);
                    //newImageHSV.SetPixel(x, y, newColor);
                    fast_newImageHSV[x, y] = newColor;
                }
            }
            }
            tb2 = Proc;
            if (tb2 == 0)
            {
                tb2 = 1;
            }
            pictureBox2.Image = newImageHSV;
        }
        //изменить яркость
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            int Proc = trackBar3.Value;
            using (var fast_newImageHSV = new FastBitmap(newImageHSV))
            {
                for (int x = 0; x < fast_newImageHSV.Width; x++)
                {
                    for (int y = 0; y < fast_newImageHSV.Height; y++)
                    {
                        Color pixelColor = fast_newImageHSV[x, y];
                        int R = pixelColor.R;
                        int G = pixelColor.G;
                        int B = pixelColor.B;
                        int H = ToH(R, G, B);
                        int S = ToS(R, G, B);
                        int V = ToV(R, G, B);

                        
                        if (Proc <= tb3)
                        {
                            V = V * Proc / tb3;
                        }
                        else
                        {
                            V = 100 - V * (200 - Proc) / (200 - tb3);
                        }
                        
                        R = ToR(H, S, V);
                        G = ToG(H, S, V);
                        B = ToB(H, S, V);
                        Color newColor = Color.FromArgb(R, G, B);
                        //newImageHSV.SetPixel(x, y, newColor);
                        fast_newImageHSV[x, y] = newColor;
                    }
                }
            }
            tb3 = Proc;
            if (tb3==0)
            {
                tb3 = 1;
            }
            pictureBox2.Image = newImageHSV;
        }

        //RGB -> HSV
        private int ToH(int R, int G, int B) {
            int max = Math.Max(R, G);
            max = Math.Max(max, B);
            int min = Math.Min(R, G);
            min = Math.Min(min, B);
            if (max == min)
            {
                return 0;
            }
            int t = 0;
            if ((max == R) && (G>=B))
            {
                t = (G - B) * 60 / (max - min);
            }
            if ((max == R) && (G < B))
            {
                t = (G - B) * 60 / (max - min) + 360;
            }
            if (max == G)
            {
                t = (B - R) * 60 / (max - min) + 120;
            }
            if (max == B)
            {
                t = (R - G) * 60 / (max - min) + 240;
            }
            return t;
        }
        private int ToS(int R, int G, int B)
        {
            int max = Math.Max(R, G);
            max = Math.Max(max, B);
            int min = Math.Min(R, G);
            min = Math.Min(min, B);
            if (max == 0)
            {
                return 0;
            }
            int t = 100 - min * 100 / max;
            return t;
        }
        private int ToV(int R, int G, int B)
        {
            int t = Math.Max(R, G);
            t = Math.Max(t, B) * 100 / 255;
            return t;
        }

        //HSV -> RGB
        private int ToR(int H, int S, int V)
        {
            int Hi = (H / 60) % 6;
            int Vmin = (100 - S) * V / 100;
            int a = (V - Vmin) * (H % 60) / 60;
            int Vinc = Vmin + a;
            int Vdec = V - a;
            int t = 0;
            switch (Hi)
            {
                case 0:
                    t = V;
                    break;
                case 1:
                    t = Vdec;
                    break;
                case 2:
                    t = Vmin;
                    break;
                case 3:
                    t = Vmin;
                    break;
                case 4:
                    t = Vinc;
                    break;
                case 5:
                    t = V;
                    break;
                default:
                    break;
            }
            t = t * 255 / 100;
            if ((t<0)||(t>255))
            {
                t = 100;
            }
            return t;
        }
        private int ToG(int H, int S, int V)
        {
            int Hi = (H / 60) % 6;
            int Vmin = (100 - S) * V / 100;
            int a = (V - Vmin) * (H % 60) / 60;
            int Vinc = Vmin + a;
            int Vdec = V - a;
            int t = 0;
            switch (Hi)
            {
            case 0:
                t = Vinc;
                break;
            case 1:
                t = V;
                break;
            case 2:
                t = V;
                break;
            case 3:
                t = Vdec;
                break;
            case 4:
                t = Vmin;
                break;
            case 5:
                t = Vmin;
                break;
            default:
                break;
            }
            t = t * 255 / 100;
            if ((t < 0) || (t > 255))
            {
                t = 100;
            }
            return t;
        }
        private int ToB(int H, int S, int V)
        {
            int Hi = (H / 60) % 6;
            int Vmin = (100 - S) * V / 100;
            int a = (V - Vmin) * (H % 60) / 60;
            int Vinc = Vmin + a;
            int Vdec = V - a;
            int t = 0;
            switch (Hi)
            {
                case 0:
                    t = Vmin;
                    break;
                case 1:
                    t = Vmin;
                    break;
                case 2:
                    t = Vinc;
                    break;
                case 3:
                    t = V;
                    break;
                case 4:
                    t = V;
                    break;
                case 5:
                    t = Vdec;
                    break;
                default:
                    break;
            }
            t = t * 255 / 100;
            if ((t < 0) || (t > 255))
            {
                t = 100;
            }
            return t;
        }
    }
}
