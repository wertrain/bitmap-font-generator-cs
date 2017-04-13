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
        private bool skipGenerateFontBitmap;

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

            // UI に初期設定を行うとき、イベントが走ってしまうのでフラグで管理する
            // もっと良い方法がありそう......
            skipGenerateFontBitmap = true;
            {
                CheckBox[] checkboxs = getCheckBoxList();
                for (int i = 0; i < checkboxs.Length; ++i)
                    checkboxs[i].Checked = generatorSettings.IsDrawList[i];
                int index = comboBoxInstalledFont.FindStringExact(generatorSettings.TextFont.Name);
                comboBoxInstalledFont.SelectedIndex = index;
                pictureBoxTextColorPreview.BackColor = generatorSettings.TextColor;
                pictureBoxBackgroundColorPreview.BackColor = generatorSettings.BackGroundColor;
            }
            skipGenerateFontBitmap = false;

            runGenerateFontBitmap();
        }

        private void runGenerateFontBitmap()
        {
            if (skipGenerateFontBitmap || backgroundWorkerGenerateFontBitmap.IsBusy) return;
            backgroundWorkerGenerateFontBitmap.RunWorkerAsync();
            panelPreview.Enabled = false;
            panelFontSettings.Enabled = false;
        }

        private void comboBoxInstalledFont_TextChanged(object sender, EventArgs e)
        {
            generatorSettings.TextFontName = comboBoxInstalledFont.SelectedItem.ToString();
            runGenerateFontBitmap();
            textBoxUserFont.Text = string.Empty;
        }

        private void buttonSelectFont_Click(object sender, EventArgs e)
        {
            if (openFileDialogSelectFontFile.ShowDialog() == DialogResult.OK)
            {
                textBoxUserFont.Text = openFileDialogSelectFontFile.FileName;

                using (var pfc = new System.Drawing.Text.PrivateFontCollection())
                {
                    pfc.AddFontFile(openFileDialogSelectFontFile.FileName);
                    generatorSettings.PrivateFont = pfc.Families[0];
                    runGenerateFontBitmap();
                }
            }
        }

        private void numericUpDownFontSize_ValueChanged(object sender, EventArgs e)
        {
            generatorSettings.TextFontSize = Decimal.ToInt32(numericUpDownFontSize.Value);
            runGenerateFontBitmap();
        }

        private CheckBox[] getCheckBoxList()
        {
            return new CheckBox[]
            {
                checkBoxDrawHankaku,
                checkBoxDrawZenkaku,
                checkBoxDrawPlatformDependent,
                checkBoxDrawJIS1Kanji,
                checkBoxDrawJIS2Kanji
            };
        }

        private void checkBoxDrawFlag_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox[] checkboxs = getCheckBoxList();
            int index = Array.IndexOf(checkboxs, sender);
            generatorSettings.IsDrawList[index] = checkboxs[index].Checked;
            runGenerateFontBitmap();

            // 画像サイズが変更されるのでスクロール値はリセットする
            panelPreview.VerticalScroll.Value = 0;
            panelPreview.HorizontalScroll.Value = 0;
        }

        private void backgroundWorkerGenerateFontBitmap_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker backgroundWorker = (BackgroundWorker)sender;
            Bitmap bitmap = bitmapFontGenerator.Generate(generatorSettings);
            e.Result = bitmap;
        }

        private void backgroundWorkerGenerateFontBitmap_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (fontBitmap != null) fontBitmap.Dispose();
            fontBitmap = (Bitmap)e.Result;
            pictureBoxPreview.Image = fontBitmap;

            panelPreview.Enabled = true;
            panelFontSettings.Enabled = true;
        }

        private void exportFile()
        {
            if (saveFileDialogSelectExportFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialogSelectExportFile.FileName;
                System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Bmp;
                switch (System.IO.Path.GetExtension(filePath))
                {
                    case ".bmp": format = System.Drawing.Imaging.ImageFormat.Bmp; break;
                    case ".png": format = System.Drawing.Imaging.ImageFormat.Png; break;
                    case ".gif": format = System.Drawing.Imaging.ImageFormat.Gif; break;
                }
                // fontBitmap.MakeTransparent(); // 背景色に Color.Transparent を設定していると不要っぽい
                fontBitmap.Save(filePath, format);
            }
        }

        private void buttonExportFile_Click(object sender, EventArgs e)
        {
            exportFile();
        }

        private void toolStripMenuItemExportFile_Click(object sender, EventArgs e)
        {
            exportFile();
        }

        private void buttonSelectTextColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = generatorSettings.TextColor;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                generatorSettings.TextColor = cd.Color;
                pictureBoxTextColorPreview.BackColor = cd.Color;
                runGenerateFontBitmap();
            }
        }

        private void buttonSelectBackgroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = generatorSettings.BackGroundColor;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                generatorSettings.BackGroundColor = cd.Color;
                pictureBoxBackgroundColorPreview.BackColor = cd.Color;
                runGenerateFontBitmap();
            }
        }

        private void checkBoxEnableBackgroundTransparent_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            pictureBoxBackgroundColorPreview.Enabled = !checkbox.Checked;
            buttonSelectBackgroundColor.Enabled = !checkbox.Checked;
            generatorSettings.BackGroundColor = checkbox.Checked ? Color.Transparent : pictureBoxBackgroundColorPreview.BackColor;
            runGenerateFontBitmap();
        }

        private void checkBoxTextStyle_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox[] checkboxs = { checkBoxTextBold, checkBoxTextItalic, checkBoxTextUnderline, checkBoxStrikeout };
            for (int i = 0; i < checkboxs.Length; ++i)
            {
                if (checkboxs[i] == sender)
                {
                    switch(i)
                    {
                        case 0: generatorSettings.TextStyleBold = checkboxs[i].Checked; break;
                        case 1: generatorSettings.TextStyleItalic = checkboxs[i].Checked; break;
                        case 2: generatorSettings.TextStyleUnderline = checkboxs[i].Checked; break;
                        case 3 :generatorSettings.TextStyleStrikeout = checkboxs[i].Checked; break;
                    }
                    runGenerateFontBitmap();
                    break;
                }
            }
        }
    }
}
