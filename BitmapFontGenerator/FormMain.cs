using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapFontGenerator
{
    public partial class FormMain : Form
    {
        BitmapFontGenerator bitmapFontGenerator;
        Bitmap fontBitmap;

        public FormMain()
        {
            InitializeComponent();

            bitmapFontGenerator = new BitmapFontGenerator();
            BitmapFontGenerator.Settings settings = BitmapFontGenerator.CreateDefaultSettings();
            fontBitmap = bitmapFontGenerator.Generate(settings);
            pictureBoxPreview.Image = fontBitmap;
            
            //fontBitmap.Save("font.png", System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
