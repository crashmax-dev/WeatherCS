using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WeatherCS
{
    public static class Helpers
    {
        public static Bitmap AdjustImageContrast(Image image, float contrast)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ImageAttributes attributes = new ImageAttributes();
                float t = 0.5f * (1 - contrast);

                float[][] colorMatrixElements =
                {
                new float[] { contrast, 0, 0, 0, 0 },
                new float[] { 0, contrast, 0, 0, 0 },
                new float[] { 0, 0, contrast, 0, 0 },
                new float[] { 0, 0, 0, 1, 0 },
                new float[] { t, t, t, 0, 1 }
            };

                ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
                attributes.SetColorMatrix(colorMatrix);
                g.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height),
                            0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }

        public static void RegExpLocationInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                (e.KeyChar != ' ' && e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
