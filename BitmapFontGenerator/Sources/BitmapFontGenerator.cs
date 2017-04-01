using System.Drawing;
using System.Text;

namespace BitmapFontGenerator
{
    class BitmapFontGenerator
    {
        public class Settings
        {
            private int textFontSize;
            private int textMarginSize;
            private Color textColor;
            private Font textFont;
            private Color backGroundColor;
            private int imageWidth, imageHeight;

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
            public Color TextColor
            {
                get { return this.textColor; }
                set { this.textColor = value; }
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
            public int ImageWidth
            {
                get { return this.imageWidth; }
                set { this.imageWidth = value; }
            }
            public int ImageHeight
            {
                get { return this.imageHeight; }
                set { this.imageHeight = value; }
            }
        };

        public static Settings CreateDefaultSettings()
        {
            Settings settings = new Settings();
            settings.TextColor = Color.White;
            settings.TextFontSize = 16;
            settings.TextMarginSize = (settings.TextFontSize / 2);
            settings.TextFont = new Font("Meiryo", settings.TextFontSize);
            settings.ImageWidth = 1024;
            settings.ImageHeight = 7942;
            settings.BackGroundColor = Color.Black;
            return settings;
        }

        public Bitmap Generate(Settings settings)
        {
            bool areaMargin = false;
            int textSizeWithMargin = settings.TextFontSize + settings.TextMarginSize;
            Bitmap bitmap = new Bitmap(
                textSizeWithMargin * 16 + settings.TextMarginSize / 2,
                textSizeWithMargin * (331 + (areaMargin ? 3 : 0)) +
                settings.TextMarginSize / 2);

            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(settings.BackGroundColor);

            int pointY = 0;
            // 半角文字エリア
            for (int y = 0; y < 14; ++y)
            {
                for (int x = 0; x < 16; ++x)
                {
                    byte[] b = { (byte)((y << 4) | x) };
                    string str = Encoding.GetEncoding(932).GetString(b);
                    graphics.DrawString(str, 
                        settings.TextFont, 
                        new SolidBrush(settings.TextColor),
                        x * textSizeWithMargin,
                        pointY);
                }
                pointY += textSizeWithMargin;
            }

            if (areaMargin) pointY += textSizeWithMargin;

            // 全角文字エリア
            int code = 0x8140;
            for (int y = 0; y < 56; ++y)
            {
                for (int x = 0; x < 16; ++x)
                {
                    byte[] b = { (byte)(code >> 8), (byte)code };
                    string str = Encoding.GetEncoding(932).GetString(b);
                    graphics.DrawString(str,
                        settings.TextFont,
                        new SolidBrush(settings.TextColor),
                        x * textSizeWithMargin,
                        pointY);
                    ++code;
                }
                pointY += textSizeWithMargin;
            }

            if (areaMargin) pointY += textSizeWithMargin;

            // 機種依存文字エリア
            code = 0x8740;
            for (int y = 0; y < 6; ++y)
            {
                for (int x = 0; x < 16; ++x)
                {
                    byte[] b = { (byte)(code >> 8), (byte)code };
                    string str = Encoding.GetEncoding(932).GetString(b);
                    graphics.DrawString(str,
                        settings.TextFont,
                        new SolidBrush(settings.TextColor),
                        x * textSizeWithMargin,
                        pointY);
                    ++code;
                }
                pointY += textSizeWithMargin;
            }

            if (areaMargin) pointY += textSizeWithMargin;

            // 第一水準漢字
            code = 0x8890;
            for (int y = 0; y < 255; ++y)
            {
                for (int x = 0; x < 16; ++x)
                {
                    byte[] b = { (byte)(code >> 8), (byte)code };
                    string str = Encoding.GetEncoding(932).GetString(b);
                    graphics.DrawString(str,
                        settings.TextFont,
                        new SolidBrush(settings.TextColor),
                        x * textSizeWithMargin,
                        pointY);
                    ++code;
                }
                pointY += textSizeWithMargin;
            }

            return bitmap;
        }
    }
}
