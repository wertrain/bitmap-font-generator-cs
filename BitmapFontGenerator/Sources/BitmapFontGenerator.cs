using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BitmapFontGenerator
{
    class BitmapFontGenerator
    {
        private const string defaultFontName = "Meiryo";

        public class Settings
        {
            private Font textFont;
            private int textFontSize;
            private int textMarginSize;
            private Color textColor;
            private Color backGroundColor;
            private string textFontName;
            private bool[] drawListFlag;
            private int borderLineWidth;

            public Settings()
            {
                this.textColor = Color.Black;
                this.backGroundColor = Color.White;
                this.textFontSize = 16;
                this.textMarginSize = (this.TextFontSize / 2);
                this.textFontName = defaultFontName;
                this.textFont = new Font(this.textFontName, this.TextFontSize);
                this.drawListFlag = new bool[ShiftJisStringList.GetAllList().Length];
                for (int i = 0; i < this.drawListFlag.Length; ++i) this.drawListFlag[i] = true;
                this.drawListFlag[this.drawListFlag.Length - 1] = false;
                this.borderLineWidth = 0;
            }

            public int TextFontSize
            {
                get { return textFontSize; }
                set
                {
                    this.textFontSize = value;
                    this.textMarginSize = value / 2;
                    this.textFont.Dispose();
                    this.textFont = new Font(this.textFontName, this.textFontSize);
                }
            }
            public int TextMarginSize
            {
                get { return this.textMarginSize; }
            }
            public int TextSizeWithMargin
            {
                get { return (this.TextFontSize + this.TextMarginSize); }
            }
            public Color TextColor
            {
                get { return this.textColor; }
                set { this.textColor = value; }
            }
            public string TextFontName
            {
                set
                {
                    this.textFontName = value;
                    this.textFont.Dispose();
                    this.textFont = new Font(this.textFontName, this.TextFontSize);
                }
            }
            public Font TextFont
            {
                get { return this.textFont; }
            }
            public Color BackGroundColor
            {
                get { return this.backGroundColor; }
                set { this.backGroundColor = value; }
            }
            public bool[] IsDrawList
            {
                get { return this.drawListFlag; }
            }
            public int BorderLineWidth
            {
                get { return this.borderLineWidth; }
                set { this.borderLineWidth = value; }
            }
        };

        public Bitmap Generate(Settings settings)
        {
            string[][] stringList = ShiftJisStringList.GetAllList();
            int[] ylengthList = ShiftJisStringList.GetYLengthList();

            int heightLength = 0;
            int heightListCount = 0;
            for (int j = 0; j < stringList.Length; ++j)
            {
                if (!settings.IsDrawList[j]) continue;
                heightLength += ylengthList[j];
                ++heightListCount;
            }
            
            // 描画範囲が 0 なら最小のビットマップを渡す
            // null のほうがいいかも
            if (heightListCount == 0)
            {
                return new Bitmap(1, 1);
            }

            bool withBorder = (settings.BorderLineWidth != 0); // true にすると区切り線を入れる
            int borderLineWidth = settings.BorderLineWidth;
            int borderLineWidthHalf = (borderLineWidth > 1) ? borderLineWidth / 2 : 0;
            bool areaMargin = false; // true にするとリストごとに一行空白を作る
            Size charAreaSize = new Size(
                (int)System.Math.Ceiling(settings.TextFontSize * 1.5f) + borderLineWidth, 
                (int)System.Math.Ceiling(settings.TextFontSize * 1.8f) + borderLineWidth
            );
            int bitmapWidth = charAreaSize.Width * 16 + borderLineWidth;
            int bitmapHeight = charAreaSize.Height * (heightLength + (areaMargin ? (heightListCount-1): 0)) + borderLineWidth;
            Bitmap bitmap = new Bitmap(bitmapWidth, bitmapHeight);

            Graphics graphics = Graphics.FromImage(bitmap);
            //graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            //graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            graphics.Clear(settings.BackGroundColor);

            using (StringFormat sf = new StringFormat(StringFormat.GenericTypographic))
            {
                int pointY = 0;
                for (int j = 0; j < stringList.Length; ++j)
                {
                    if (!settings.IsDrawList[j]) continue;

                    int x = 0;
                    for (int i = 0; i < stringList[j].Length; ++i)
                    {
                        SizeF drawnSize = graphics.MeasureString(stringList[j][i], settings.TextFont, charAreaSize.Width, sf);
                        int marginWidth = (charAreaSize.Width - (int)drawnSize.Width) / 2;
                        int marginHeight = (charAreaSize.Height - (int)(drawnSize.Height * 0.95f)) / 2; // 0.95 をかけているのは、MeasureString から大きめの高さが返ってきてしまうので苦肉の策
                        graphics.DrawString(
                            stringList[j][i], settings.TextFont,
                            new SolidBrush(settings.TextColor),
                            (x * charAreaSize.Width) + marginWidth + borderLineWidthHalf,
                            pointY + marginHeight + borderLineWidthHalf, sf
                        );
                        if (++x >= 16)
                        {
                            x = 0;
                            pointY += charAreaSize.Height;
                        }
                    }
                    if (areaMargin) pointY += charAreaSize.Height;
                }
            }

            if (withBorder)
            {
                Pen borderLinePen = new Pen(new SolidBrush(Color.Black), borderLineWidth);
                int borderHeightCount = heightLength + stringList.Length + (areaMargin ? 4 : 0);
                
                for (int j = 0; j < borderHeightCount; ++j)
                {
                    graphics.DrawLine(
                        borderLinePen,
                        0, borderLineWidthHalf + (j * charAreaSize.Height),
                        bitmapWidth, borderLineWidthHalf + (j * charAreaSize.Height)
                    );
                    for (int i = 0; i < 16 + 1; ++i)
                    {
                        graphics.DrawLine(
                            borderLinePen,
                            borderLineWidthHalf + (i * charAreaSize.Width), 0,
                            borderLineWidthHalf + (i * charAreaSize.Width), bitmapHeight
                        );
                    }
                }
            }

            return bitmap;
        }
    }
}
