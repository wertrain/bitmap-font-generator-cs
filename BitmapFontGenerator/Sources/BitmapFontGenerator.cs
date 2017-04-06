using System.Drawing;
using System.IO;
using System.Text;

namespace BitmapFontGenerator
{
    class BitmapFontGenerator
    {
        private const string defaultFontName = "Meiryo";

        public class Settings
        {
            private int textFontSize;
            private int textMarginSize;
            private Color textColor;
            private Font textFont;
            private Color backGroundColor;

            public int TextFontSize
            {
                get { return this.textFontSize; }
                set { this.textFontSize = value; }
            }
            public int TextMarginSize
            {
                get { return this.textMarginSize; }
                set { this.textMarginSize = value; }
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
                set { this.textFont = new Font(value, this.TextFontSize); }
            }
            public Font TextFont
            {
                get { return this.textFont; }
                set { this.textFont = value; }
            }
            public Color BackGroundColor
            {
                get { return this.backGroundColor; }
                set { this.backGroundColor = value; }
            }
        };

        public static Settings CreateDefaultSettings()
        {
            Settings settings = new Settings();
            settings.TextColor = Color.Black;
            settings.TextFontSize = 16;
            settings.TextMarginSize = (settings.TextFontSize / 2);
            settings.TextFont = new Font(defaultFontName, settings.TextFontSize);
            settings.BackGroundColor = Color.White;
            return settings;
        }

        public Bitmap Generate(Settings settings)
        {
            string[][] stringList = ShiftJisStringList.GetAllList();
            int[] ylengthList = ShiftJisStringList.GetYLengthList();

            int heightLength = 0;
            for (int j = 0; j < stringList.Length; ++j)
            {
                heightLength += ylengthList[j];
            }

            bool areaMargin = true; // true にするとリストごとに一行空白を作る
            int textSizeWithMargin = settings.TextSizeWithMargin;
            Bitmap bitmap = new Bitmap(
                textSizeWithMargin * 16 + settings.TextMarginSize / 2,
                textSizeWithMargin * (heightLength + (areaMargin ? 4 : 0)) +
                settings.TextMarginSize / 2);

            Graphics graphics = Graphics.FromImage(bitmap);
            //graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            //graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            graphics.Clear(settings.BackGroundColor);

            int pointY = 0;
            for (int j = 0; j < stringList.Length; ++j)
            {
                int x = 0;
                for (int i = 0; i < stringList[j].Length; ++i)
                {
                    graphics.DrawString(stringList[j][i],
                        settings.TextFont,
                        new SolidBrush(settings.TextColor),
                        x * textSizeWithMargin,
                        pointY);
                    if (++x >= 16)
                    {
                        x = 0;
                        pointY += textSizeWithMargin;
                    }
                }
                if (areaMargin) pointY += textSizeWithMargin;
            }

            return bitmap;
        }
    }
}
