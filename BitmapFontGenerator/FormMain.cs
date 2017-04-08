﻿using System;
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
            generatorSettings = new BitmapFontGenerator.Settings();
            generatorSettings.TextFontSize = Decimal.ToInt32(numericUpDownFontSize.Value);
            generateFontBitmap();

            int index = comboBoxInstalledFont.FindStringExact(generatorSettings.TextFont.Name);
            comboBoxInstalledFont.SelectedIndex = index;

            //fontBitmap.Save("font.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private void generateFontBitmap()
        {
            if (fontBitmap != null) fontBitmap.Dispose();
            fontBitmap = bitmapFontGenerator.Generate(generatorSettings);
            pictureBoxPreview.Image = fontBitmap;
        }

        private void comboBoxInstalledFont_TextChanged(object sender, EventArgs e)
        {
            generatorSettings.TextFontName = comboBoxInstalledFont.SelectedItem.ToString();
            generateFontBitmap();
        }

        private void buttonSelectFont_Click(object sender, EventArgs e)
        {
            if (openFileDialogSelectFont.ShowDialog() == DialogResult.OK)
            {
                textBoxUserFont.Text = openFileDialogSelectFont.FileName;
            }
        }

        private void numericUpDownFontSize_ValueChanged(object sender, EventArgs e)
        {
            generatorSettings.TextFontSize = Decimal.ToInt32(numericUpDownFontSize.Value);
            generateFontBitmap();
        }
    }
}
