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
        private BitmapFontGenerator bitmapFontGenerator;
        private BitmapFontGenerator.Settings generatorSettings;
        private Bitmap fontBitmap;

        public FormMain()
        {
            InitializeComponent();

            foreach (FontFamily item in FontFamily.Families)
            {
                if (item.IsStyleAvailable(FontStyle.Regular))
                {
                    comboBoxInstalledFont.Items.Add(item.Name);
                }
            }

            bitmapFontGenerator = new BitmapFontGenerator();
            generatorSettings = BitmapFontGenerator.CreateDefaultSettings();
            generateFontBitmap();

            int index = comboBoxInstalledFont.FindStringExact(generatorSettings.TextFont.Name);
            comboBoxInstalledFont.SelectedIndex = index;

            //fontBitmap.Save("font.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private void generateFontBitmap()
        {
            fontBitmap = bitmapFontGenerator.Generate(generatorSettings);
            pictureBoxPreview.Image = fontBitmap;
        }

        private void comboBoxInstalledFont_TextChanged(object sender, EventArgs e)
        {
            generatorSettings.TextFontName = comboBoxInstalledFont.SelectedItem.ToString();
            generateFontBitmap();
        }
    }
}
