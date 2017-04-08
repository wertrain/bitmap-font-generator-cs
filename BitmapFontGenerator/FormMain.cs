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
            }
            skipGenerateFontBitmap = false;

            runGenerateFontBitmap();
            //fontBitmap.Save("font.png", System.Drawing.Imaging.ImageFormat.Png);
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
        }

        private void buttonSelectFont_Click(object sender, EventArgs e)
        {
            if (openFileDialogSelectFont.ShowDialog() == DialogResult.OK)
            {
                textBoxUserFont.Text = openFileDialogSelectFont.FileName;

                using (var pfc = new System.Drawing.Text.PrivateFontCollection())
                {
                    pfc.AddFontFile(openFileDialogSelectFont.FileName);
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
            return new CheckBox[] {
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
            for (int i = 0; i < checkboxs.Length; ++i)
            {
                if (checkboxs[i] == sender)
                {
                    // 画像サイズが変更されるのでスクロール値はリセットする
                    panelPreview.VerticalScroll.Value = 0;
                    panelPreview.HorizontalScroll.Value = 0;

                    generatorSettings.IsDrawList[i] = checkboxs[i].Checked;
                    runGenerateFontBitmap();
                    return;
                }
            }
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
    }
}
