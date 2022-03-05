using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fotoğraf_Düzenleyici
{
    class bitmap_algorithms
    { 
        // Pale Effect .
        public Image pale(Image img)
        {
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][]
            {
                    new float[] {1, 0, 0, 0, 0},
                    new float[] {0, 1, 0, 0, 0},
                    new float[] {0, 0, 1, 0, 0},
                    new float[] {0, 0, 0, 0.6f, 0},
                    new float[] {0, 0, 0, 0, 1}
            });
            ia.SetColorMatrix(cmPicture);
            Graphics g = Graphics.FromImage(bmpInverted);


            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

            g.Dispose();
            Image image = bmpInverted;
            return image;
        }

        // Blue Effect .
        public Image Blue(Image img)
        {
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][]
            {
                    new float[]{1, 0, 0, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 0},
                    new float[]{0, 1, 0, 0, 1},
                    new float[]{0, 0, 1, 0, 1}
            });
            ia.SetColorMatrix(cmPicture);
            Graphics g = Graphics.FromImage(bmpInverted);


            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

            g.Dispose();
            Image image = bmpInverted;
            return image;
        }

        // Grey Effect .
        public Image Grey(Image img)
        {
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][]
            {
                    new float[]{0.333f, 0.333f, 0.333f, 0, 0},
                    new float[]{0.333f, 0.333f, 0.333f, 0, 0},
                    new float[]{0.333f, 0.333f, 0.333f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
            });
            ia.SetColorMatrix(cmPicture);
            Graphics g = Graphics.FromImage(bmpInverted);


            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

            g.Dispose();
            Image image = bmpInverted;
            return image;
        }

        // Invert Effect .
        public Image Invert(Image img)
        {
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][]
            {
                    new float[]{-1, 0, 0, 0, 0},
                    new float[]{0, -1, 0, 0, 0},
                    new float[]{0, 0, -1, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{1, 1, 1, 0, 1}
            });
            ia.SetColorMatrix(cmPicture);
            Graphics g = Graphics.FromImage(bmpInverted);


            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

            g.Dispose();
            Image image = bmpInverted;
            return image;
        }

         // Invert 2 Effect .
        public Image Invert_2(Image img)
        {
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][]
            {
                    new float[]{0.5f, 0, 0, 0.2f, 0},
                    new float[]{0, 0, 0.5f, 0, 0},
                    new float[]{0, 1, 0, 0, 0},
                    new float[]{0.3f, 0, 0, 0.5f, 0},
                    new float[]{0, 0.1f, 0, 0, 0}
            });
            ia.SetColorMatrix(cmPicture);
            Graphics g = Graphics.FromImage(bmpInverted);


            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

            g.Dispose();
            Image image = bmpInverted;
            return image;
        }

        // Live Effect .
        public Image live(Image img)
        {
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][]
            {
                    new float[] {1.438f, -0.062f, -0.062f, 0, 0},
                    new float[] {-0.122f, 1.378f, -0.122f, 0, 0},
                    new float[] {-0.016f, -0.016f, 1.483f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {-0.03f, 0.05f, -0.02f, 0, 1}
            });
            ia.SetColorMatrix(cmPicture);
            Graphics g = Graphics.FromImage(bmpInverted);


            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

            g.Dispose();
            Image image = bmpInverted;
            return image;
        }

        // Red Effect .
        public Image red(Image img)
        {
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][]
            {
                    new float[] { 400 / 255.0f, 0, 0, 0, 0 },
                    new float[] { 0, 200 / 255.0f, 0, 0, 0 },
                    new float[] { 0, 0, 160 / 255.0f, 0, 0 },
                    new float[] { 0, 0, 0, 1.5f, 0 },
                    new float[] { 0, 0, 0, 0, -1}
            });
            ia.SetColorMatrix(cmPicture);
            Graphics g = Graphics.FromImage(bmpInverted);


            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

            g.Dispose();
            Image image = bmpInverted;
            return image;
        }
    }
}
