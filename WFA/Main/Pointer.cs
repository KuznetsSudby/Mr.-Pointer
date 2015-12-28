using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Main
{
    class Pointer
    {
        static public int HEIGHT = 210 * 4;
        static public int WIDTH = 148 * 4;
        static public int X0 = 276;
        static public int Y0 = 12;

        int f;
        int N;
        int[] pixels;
        int height;
        int width;

        int[] progress;

        int[][] forDraw;

        LinkedList<MyPair> list  = new LinkedList<MyPair>();

        public Pointer(int f, int N, int[] pixels, int height, int width)
        {
            this.f = f;
            this.N = N;
            this.pixels = pixels;
            this.height = height;
            this.width = width;
        }

        public void PrepairForDraw()
        {
            MakeProgress();
            ModificateProgress();
        }

        public void Draw(Graphics gr, TextBox TextBoxForAll, int D, int H)
        {
            SolidBrush brush = new SolidBrush(Color.White);
            gr.FillRectangle(brush, new Rectangle(X0, Y0, WIDTH + 3, HEIGHT + 3));
            brush.Color = Color.Black;

            int[] i =  GeneratePoint(gr, brush, D, H);
            TextBoxForAll.Text += Environment.NewLine + " Точек = " + i[1];
            TextBoxForAll.Text += Environment.NewLine + " Время ~ " + (int)(i[1] * 100.0 / 1000 / 60 * 4) + " мин";
            brush.Dispose();
            
        }

        internal int[] GeneratePoint(Graphics gr, SolidBrush brush, int D, int H)
        {
            Random random = new Random();

            forDraw = new int[height][];
            for (int k = 0; k < height; k++)
                forDraw[k] = new int[width];

            int i = 0;
            int j = 0;
            int x, y, Num;
            while (isRun())
            {
                y = random.Next(height);
                x = random.Next(width);
                Num = pixels[x + y * width];
                if (progress[Num] > 0)
                {
                    i++;
                    if (forDraw[y][x] == 0)
                    {
                        forDraw[y][x] = 1;
                        j++;
                        list.AddLast(new MyPair(x, y));
                    }
                    progress[Num]--;
                    DrawPixel(x*H, y*H, gr, brush, D, H);
                }
            }
            int[] t = {i,j};
            return t;
        }

        private void DrawPixel(int x, int y, Graphics gr, SolidBrush brush, int D, int H)
        {
            gr.FillRectangle(brush, new Rectangle(x + X0 + H/2 + D/2, y + Y0 + H/2 - D/2, D, D));
        }

        private void ModificateProgress()
        {
            for (int i = 0; i < 256; i++)
            {
                progress[i] = (int)(progress[i] * getK(i));
            }
        }

        private double getK(int i)
        {
            switch (f)
            {
                case 0:
                    return 1.0 * Math.Pow((255 - i) / 256.0, 1) * N / 100;
                case 1:
                    return 1.0 * Math.Pow((255 - i) / 256.0, 2) * N / 100;
                case 2:
                    return 1.0 * Math.Pow((255 - i) / 256.0, 3) * N / 100;
                case 3:
                    return 1.0 * Math.Pow((255 - i) / 256.0, 4) * N / 100;
            }
            return 0;
        }

        private void MakeProgress()
        {
            progress = new int[256];
            for (int i = 0; i < height * width; i++)
            {
                progress[pixels[i]]++;
            }
        }

        private Boolean isRun()
        {
            for (int i = 0; i < 256; i++)
            {
                if (progress[i] > 0) return true;
            }
            return false;
        }

        public void GenerateLine(int delta, int block, Graphics gr, SolidBrush brush, int D, int H, TextBox TextBoxForAll)
        {
            int k = 0;
            for (int i = 1; i < height - 1; i++)
            {
                for (int j = 1; j < width - 1; j++)
                {
                    if (HowManyLowPixels(pixels[j + i * width], pixels[j + i * width + 1], pixels[j + i * width - 1],
                        pixels[j + (i + 1) * width], pixels[j + (i - 1) * width],delta) > 0)
                        if (HowManyLowPixels(pixels[j + i * width], pixels[j + i * width + 1], pixels[j + i * width - 1], 
                            pixels[j + (i + 1) * width], pixels[j + (i - 1) * width],delta) < 3)
                            if (pixels[j + i * width] < block)
                            {
                                if (forDraw[i][j] == 0)
                                {
                                    k++;
                                    forDraw[i][j] = 1;
                                    DrawPixel(j * H, i * H, gr, brush, D, H);
                                }
                            }
                }
            }
            TextBoxForAll.Text += Environment.NewLine + " Точек доб. = " + k;
            TextBoxForAll.Text += Environment.NewLine + " Время ~ +" + (int)(k * 100.0 / 1000 / 60) + " мин";
        }

        private int HowManyLowPixels(int p1, int p2, int p3, int p4, int p5, int delta)
        {
            int i = 0;
            if (p1 >= p2 + delta) i++;
            if (p1 >= p3 + delta) i++;
            if (p1 >= p4 + delta) i++;
            if (p1 >= p5 + delta) i++;
            return i;
        }

        internal void GenerateBlack(int black, Graphics gr, SolidBrush brush, int D, int H, TextBox TextBoxForAll)
        {
            int j = 0;
            for (int i = 0; i < width * height; i++)
            {
                if (pixels[i] <= black)
                    if (forDraw[i % height][i / height] == 0)
                    {
                        DrawPixel(i % width * H, i / width * H, gr, brush, D, H);
                        forDraw[i % height][i / height] = 1;
                        j++;
                    }
            }

            TextBoxForAll.Text += Environment.NewLine + " Точек доб. = " + j;
            TextBoxForAll.Text += Environment.NewLine + " Время ~ +" + (int)(j * 100.0 / 1000 / 60) + " мин";
        }

        internal void GenerateWhite(int white, Graphics gr, SolidBrush brush, int D, int H, TextBox TextBoxForAll)
        {                                                                                           
            int j=0;
            for (int i = 0; i < width * height; i++)
            {
                if (pixels[i] >= white)
                    if (forDraw[i % height][i / height] == 1)
                    {
                        DrawPixel(i % width * H, i / width * H, gr, brush, D, H);
                        forDraw[i % height][i / height] = 0;
                        j++;
                    }
            }

            TextBoxForAll.Text += Environment.NewLine + " Точек убр. = " + j;
            TextBoxForAll.Text += Environment.NewLine + " Время ~ -" + (int)(j * 100.0 / 1000 / 60) + " мин";

        }

        internal void Clear(Graphics gr, SolidBrush brush)
        {
            gr.FillRectangle(brush, new Rectangle(X0, Y0, WIDTH + 3, HEIGHT + 3));
        }

        internal MyPair[] getSortArray()
        {
            MyPair[] array = list.ToArray<MyPair>();
            Array.Sort<MyPair>(array);
            return array;
        }
    }
}
