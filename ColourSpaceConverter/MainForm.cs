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
    public partial class MainForm : Form
    {
        private bool formOpened = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void rgbToGrayScaleButton_Click(object sender, EventArgs e)
        {
            var rgbToGrayScaleForm = new RGBToGrayScaleForm();
            rgbToGrayScaleForm.ShowDialog();
        }

        private void rgbChannelsExtractionButton_Click(object sender, EventArgs e)
        {
            var rgbChannelsExtractionForm = new RGBChannelsExtractionForm();
            rgbChannelsExtractionForm.ShowDialog();
        }

        private void rgbToHsvButton_Click(object sender, EventArgs e)
        {
            var rgbToHsvForm = new RGBToHSVForm();
            rgbToHsvForm.ShowDialog();
        }
    }
}
