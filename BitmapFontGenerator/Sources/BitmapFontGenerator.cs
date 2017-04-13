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
            private FontFamily fontFamily;
            private int textFontSize;
            private int textMarginSize;
            private Color textColor;
            private Color backGroundColor;
            private string textFontName;
            private bool[] drawListFlag;
            private int borderLineWidth;
            private bool textStyleBold;
            private bool textStyleItalic;
            private bool textStyleUnderline;
            private bool textStyleStrikeout;

            public Settings()
            {
                this.textColor = Color.Black;
                this.backGroundColor = Color.White;
                this.textFontSize = 16;
                this.textMarginSize = (this.TextFontSize / 2);
                this.textFontName = defaultFontName;
                this.textStyleBold = false;
                this.textStyleItalic = false;
                this.textStyleUnderline = false;
                this.textStyleStrikeout = false;
                this.textFont = new Font(this.textFontName, this.TextFontSize, this.Style);
                this.fontFamily = null;
                this.drawListFlag = new bool[ShiftJisStringList.GetAllList().Length];
                for (int i = 0; i < this.drawListFlag.Length; ++i) this.drawListFlag[i] = true;
                this.drawListFlag[this.drawListFlag.Length - 1] = false;
                this.borderLineWidth = 0;
            }

            private void createNewFontInstance()
            {
                if (this.fontFamily != null) this.textFont = new Font(this.fontFamily, this.textFontSize, this.Style);
                else if (this.textFontName.Length != 0) this.textFont = new Font(this.textFontName, this.textFontSize, this.Style);
            }

            public int TextFontSize
            {
                get { return textFontSize; }
                set
                {
                    this.textFontSize = value;
                    this.textMarginSize = value / 2;
                    this.textFont.Dispose();
                    createNewFontInstance();
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
                    this.textFont = new Font(this.textFontName, this.TextFontSize, this.Style);
                    if (this.fontFamily != null)
                    {
                        this.fontFamily.Dispose();
                        this.fontFamily = null;
                    }
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
            public FontFamily PrivateFont
            {
                set
                {
                    if (this.fontFamily != null)
                        this.fontFamily.Dispose();
                    this.fontFamily = value;
                    this.textFont = new Font(this.fontFamily, this.TextFontSize, this.Style);
                    this.textFontName = string.Empty;
                }
            }
            public bool TextStyleBold
            {
                get { return this.textStyleBold; }
                set
                {
                    this.textStyleBold = value;
                    createNewFontInstance();
                }
            }
            public bool TextStyleItalic
            {
                get { return this.textStyleItalic; }
                set
                {
                    this.textStyleItalic = value;
                    createNewFontInstance();
                }
            }
            public bool TextStyleUnderline
            {
                get { return this.textStyleUnderline; }
                set
                {
                    this.textStyleUnderline = value;
                    createNewFontInstance();
                }
            }
            public bool TextStyleStrikeout
            {
                get { return this.textStyleStrikeout; }
                set
                {
                    this.textStyleStrikeout = value;
                    createNewFontInstance();
                }
            }
            private FontStyle Style
            {
                get
                {
                    FontStyle style = FontStyle.Regular;
                    if (this.textStyleBold) style |= FontStyle.Bold;
                    if (this.textStyleItalic) style |= FontStyle.Italic;
                    if (this.textStyleUnderline) style |= FontStyle.Underline;
                    if (this.textStyleStrikeout) style |= FontStyle.Strikeout;
                    return style;
                }
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
            Bitmap bitmap = new Bitmap(bitmapWidth, bitmapHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            Graphics graphics = Graphics.FromImage(bitmap);
            //graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            //graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            if (settings.BackGroundColor == Color.Transparent)
            {
                // AntiAliasGridFit にしておくと透過背景にした場合でもきれいに表示される
                // しかし、外部読み込みのファイルで表示が汚くなるファイルが存在した
                // 詳しくは調べる必要があるが、とりあえず今は背景色が透過の時だけ適用することにする
                graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            }
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
                        int marginHeight = (charAreaSize.Height - (int)(drawnSize.Height * 0.95)) / 2; // 0.95 をかけているのは、MeasureString から大きめの高さが返ってきてしまうので苦肉の策
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
