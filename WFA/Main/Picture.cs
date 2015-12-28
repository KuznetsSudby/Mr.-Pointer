using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Main
{
    class Picture
    {

        int Height_px = 840;
        int Width_px = 592;

        public int h;
        public int w;

        int[] pixelsFromBitmap;
        int[] curPixelsFromBitmap;

        public Bitmap bitmap;
        public Image image;

        public Picture(OpenFileDialog dlg)
        {
            dlg.FileName = "Image for printing";
            dlg.Filter = "Image | *.jpg;*.jpeg;*.png;";

            DialogResult result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filename = dlg.FileName;
                image = Image.FromFile(filename);
            }
        }

        private void Resize(int step, int height, int width)
        {
            if (1.0 * image.Height / image.Width > 1.0 * Height_px / Width_px)
            {
                h = height * 4 / step;
                w = (int)(1.0 * image.Width / image.Height * height * 4 / step);

            }
            else
            {
                w = width * 4 / step;
                h = (int)(1.0 * image.Height / image.Width * width * 4 / step);
            }

            bitmap = new Bitmap(image, new Size(w, h));
        }

        public void StepLevels(int step, int height, int width, bool negative)
        {
            Resize(step, height, width);

            h = bitmap.Height;
            w = bitmap.Width;

            int SH = h;
            int SW = w;
            pixelsFromBitmap = new int[SH * SW];
            int i = 0;


            PixelFormat pxf = PixelFormat.Format24bppRgb;
            Rectangle rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            BitmapData bmpData = bitmap.LockBits(rect, ImageLockMode.ReadWrite, pxf);
            IntPtr ptr = bmpData.Scan0;
            int numBytes = bmpData.Stride * bitmap.Height;
            int widthBytes = bmpData.Stride;
            byte[] rgbValues = new byte[numBytes];
            Marshal.Copy(ptr, rgbValues, 0, numBytes);
            try
            {
                int[] pixels = new int[numBytes / 3];
                int counter;
                for (int k = 0; k < SH; k++)
                {
                    for (int j = 0; j < SW ; j++)
                    {
                        counter = k * bmpData.Stride + j * 3; 
                        int value = rgbValues[counter] + rgbValues[counter + 1] + rgbValues[counter + 2];
                        byte color_b = 0;
                        color_b = Convert.ToByte(value / 3);
                        if (negative)
                            color_b = (byte)(255 - color_b);
                        pixels[i] = color_b;
                        rgbValues[counter] = color_b;
                        rgbValues[counter + 1] = color_b;
                        rgbValues[counter + 2] = color_b;
                        pixelsFromBitmap[i] = pixels[i];
                        i++;
                    }
                }
            }catch(IndexOutOfRangeException){

            }

            Marshal.Copy(rgbValues, 0, ptr, 3 * SH * SW);
            bitmap.UnlockBits(bmpData);

            curPixelsFromBitmap = new int[SH * SW];
            pixelsFromBitmap.CopyTo(curPixelsFromBitmap, 0);
        }

        public int[] getCurrentPixels()
        {
            return curPixelsFromBitmap;
        }

        public void Draw(PictureBox box, int h, int w)
        {
            box.Image = Resize((Image)bitmap, h, w);
        }

        private Bitmap Resize(Image image, int H, int W)
        {
            int w;
            int h;

            if (1.0 * image.Height / image.Width > 1.0 * H / W)
            {
                h = H;
                w = (int)(1.0 * image.Width / image.Height * H);
            }
            else
            {
                w = W;
                h = (int)(1.0 * image.Height / image.Width * W);
            }
            return new Bitmap(image, new Size(w, h));
        }

        internal int[] getMassForLevels()
        {
            int[] forLevels = new int[256];
            int max=0;
            for (int i = 0; i < h * w; i++)
            {
                forLevels[curPixelsFromBitmap[i]]++;
            }

            for (int i = 0; i < 256; i++)
                if (forLevels[i] > max)
                    max = forLevels[i];

            for (int i = 0; i < 256; i++)
                forLevels[i] = (int)(forLevels[i] * 1.0*100/max);

            return forLevels;
        }

        public void ChangePictureByLevels(int a, int b)
        {
            PixelFormat pxf = PixelFormat.Format24bppRgb;
            Rectangle rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            BitmapData bmpData = bitmap.LockBits(rect, ImageLockMode.ReadWrite, pxf);
            IntPtr ptr = bmpData.Scan0;

            pixelsFromBitmap.CopyTo(curPixelsFromBitmap, 0);
            for (int i = 0; i < w * h; i++)
            {
                if (curPixelsFromBitmap[i] <= a)
                    curPixelsFromBitmap[i] = 0;
                else
                    if (curPixelsFromBitmap[i] >= b)
                        curPixelsFromBitmap[i] = 255;
                    else
                        curPixelsFromBitmap[i] = (int)((curPixelsFromBitmap[i] - a) * 255.0 / (b - a));
            }
            byte[] rgbValues = new byte[bmpData.Stride * h];

            int counter;
            for (int k = 0; k < h; k++)
            {
                for (int j = 0; j < w; j++)
                {
                    counter = k * bmpData.Stride + j * 3;
                    rgbValues[counter] = (byte)curPixelsFromBitmap[k * w + j];
                    rgbValues[counter + 1] = (byte)curPixelsFromBitmap[k * w + j];
                    rgbValues[counter + 2] = (byte)curPixelsFromBitmap[k * w + j];
                }
            }
            
            Marshal.Copy(rgbValues, 0, ptr, bmpData.Stride * h);
            bitmap.UnlockBits(bmpData);
        }

        internal void Negative()
        {
            PixelFormat pxf = PixelFormat.Format24bppRgb;
            Rectangle rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            BitmapData bmpData = bitmap.LockBits(rect, ImageLockMode.ReadWrite, pxf);
            IntPtr ptr = bmpData.Scan0;

            pixelsFromBitmap.CopyTo(curPixelsFromBitmap, 0);
            for (int i = 0; i < w * h; i++)
            {
                curPixelsFromBitmap[i] = (int)(255-curPixelsFromBitmap[i]);
            }
            curPixelsFromBitmap.CopyTo(pixelsFromBitmap, 0);
            byte[] rgbValues = new byte[bmpData.Stride * h];

            int counter;
            for (int k = 0; k < h; k++)
            {
                for (int j = 0; j < w; j++)
                {
                    counter = k * bmpData.Stride + j * 3;
                    rgbValues[counter] = (byte)curPixelsFromBitmap[k * w + j];
                    rgbValues[counter + 1] = (byte)curPixelsFromBitmap[k * w + j];
                    rgbValues[counter + 2] = (byte)curPixelsFromBitmap[k * w + j];
                }
            }

            Marshal.Copy(rgbValues, 0, ptr, bmpData.Stride * h);
            bitmap.UnlockBits(bmpData);
        }
    }
}
