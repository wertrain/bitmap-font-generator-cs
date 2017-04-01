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

        public FormMain()
        {
            InitializeComponent();

            bitmapFontGenerator = new BitmapFontGenerator();
            BitmapFontGenerator.Settings settings = BitmapFontGenerator.CreateDefaultSettings();
            pictureBoxPreview.Image = bitmapFontGenerator.Generate(settings);
        }
    }
}
