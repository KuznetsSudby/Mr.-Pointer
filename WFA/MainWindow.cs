using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Arduino;
using WindowsFormsApplication1.Main;

namespace WindowsFormsApplication1
{
    public partial class MainWindow : Form
    {

        const int H = 315;
        const int W = 222;

        Servo servo;
        Picture main;
        Pointer pointer;
        Graphics GRAPHIS;

        public MainWindow()
        {
            InitializeComponent();
            servo = new Servo();
            GRAPHIS = this.CreateGraphics();

            reDrawButton.Enabled = false;
            reGAnerateBurtton.Enabled = false;
            LineButton.Enabled = false;
            MakePointsButton.Enabled = false;
            MakePreviewButton.Enabled = false;
            reDrawPreviewButton.Enabled = false;

            buttonBlack.Enabled = false;
            buttonWhite.Enabled = false;
            buttonClear.Enabled = false;
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            main = new Picture(openFileDialog1);
            main.StepLevels(int.Parse(textH.Text), int.Parse(textHeight.Text), int.Parse(textWidth.Text), checkBoxInverse.Checked);
            DrawLevels(main.getMassForLevels());

            reDrawButton.Enabled = true;
            reGAnerateBurtton.Enabled = true;
            LineButton.Enabled = false;
            MakePointsButton.Enabled = false;
            MakePreviewButton.Enabled = true;
            reDrawPreviewButton.Enabled = false;

            buttonBlack.Enabled = false;
            buttonWhite.Enabled = false;
            buttonClear.Enabled = false;
        }

        private void DrawLevels(int[] num)
        {
            main.Draw(picturePreview, H, W);

            int X0 = 15;
            int Y0 = 41;
            
            SolidBrush brush = new SolidBrush(Color.White);
            GRAPHIS.FillRectangle(brush, new Rectangle(X0, Y0, 256, 100));
            brush.Color = Color.Black;
            for (int i = 0; i < 256; i++)
                GRAPHIS.FillRectangle(brush, X0 + i, (Y0 + 100 - num[i]), 1, num[i]);
            brush.Dispose();
        }

        private void reDrawButton_Click(object sender, EventArgs e)
        {
            main.ChangePictureByLevels(int.Parse(textA.Text), int.Parse(textB.Text));
            DrawLevels(main.getMassForLevels());

            reDrawButton.Enabled = true;
            reGAnerateBurtton.Enabled = true;
            LineButton.Enabled = false;
            MakePointsButton.Enabled = false;
            MakePreviewButton.Enabled = true;
            reDrawPreviewButton.Enabled = false;

            buttonBlack.Enabled = false;
            buttonWhite.Enabled = false;
            buttonClear.Enabled = false;
        }

        private void MakePreviewButton_Click(object sender, EventArgs e)
        {
            int D = int.Parse(textD.Text);
            int H = int.Parse(textH.Text);
            int f = RadioIndex(groupBox1);
            int N = int.Parse(textPoints.Text);

            pointer = new Pointer(f, N, main.getCurrentPixels(), main.h, main.w);
            pointer.PrepairForDraw();
            pointer.Draw(GRAPHIS, TextBoxForAll, int.Parse(textD.Text), int.Parse(textH.Text));

            reDrawButton.Enabled = true;
            reGAnerateBurtton.Enabled = true;
            LineButton.Enabled = true;
            MakePointsButton.Enabled = true;
            MakePreviewButton.Enabled = true;
            reDrawPreviewButton.Enabled = true;

            buttonBlack.Enabled = true;
            buttonWhite.Enabled = true;
            buttonClear.Enabled = true;
        }

        int RadioIndex(GroupBox group)
        {
            foreach (RadioButton rb in group.Controls.OfType<RadioButton>())
                if (rb.Checked)
                    return rb.TabIndex;
            return 0;
        }

        private void reDrawPreviewButton_Click(object sender, EventArgs e)
        {
            pointer.PrepairForDraw();
            pointer.Draw(GRAPHIS, TextBoxForAll, int.Parse(textD.Text), int.Parse(textH.Text));

            reDrawButton.Enabled = true;
            reGAnerateBurtton.Enabled = true;
            LineButton.Enabled = true;
            MakePointsButton.Enabled = true;
            MakePreviewButton.Enabled = true;
            reDrawPreviewButton.Enabled = true;

            buttonBlack.Enabled = true;
            buttonWhite.Enabled = true;
            buttonClear.Enabled = true;
        }

        private void reGAnerateBurtton_Click(object sender, EventArgs e)
        {
            main.StepLevels(int.Parse(textH.Text), int.Parse(textHeight.Text), int.Parse(textWidth.Text), checkBoxInverse.Checked); 
            main.ChangePictureByLevels(int.Parse(textA.Text), int.Parse(textB.Text));
            DrawLevels(main.getMassForLevels());

            reDrawButton.Enabled = true;
            reGAnerateBurtton.Enabled = true;
            LineButton.Enabled = false;
            MakePointsButton.Enabled = false;
            MakePreviewButton.Enabled = true;
            reDrawPreviewButton.Enabled = false;

            buttonBlack.Enabled = false;
            buttonWhite.Enabled = false;
            buttonClear.Enabled = false;
        }

        private void MakePointsButton_Click(object sender, EventArgs e)
        {

            TextBoxForAll.AppendText("\n " + DateTime.Now);
            reDrawButton.Enabled = true;
            reGAnerateBurtton.Enabled = true;
            LineButton.Enabled = true;
            MakePointsButton.Enabled = true;
            MakePreviewButton.Enabled = true;
            reDrawPreviewButton.Enabled = true;
            int y = 0;
            bool inverse = false;
            int k = int.Parse(textD.Text) * 2;
            MyPair[] list = pointer.getSortArray();
            servo.SendDelta(k);
            for (int i = 0; i < list.Length;)
            {
                if (list[i].y != y)
                {
                    y = list[i].y;
                    inverse = !inverse;
                }
                int j = i;
                while ((j<list.Length-1)&&(list[j + 1].y == y))
                    j++;
                if (inverse)
                {
                    for (int l = j; l >= i; l--)
                    {
                        servo.SendPosition(list[l].x * k, list[l].y * k);
                    }
                }
                else
                {
                    for (int l = i; l <= j; l++)
                    {
                        servo.SendPosition(list[l].x * k, list[l].y * k);
                    }
                }
                i = j + 1;
            }
            servo.SendStop();
            TextBoxForAll.AppendText("\n " + DateTime.Now);
            buttonBlack.Enabled = true;
            buttonWhite.Enabled = true;
            buttonClear.Enabled = true;
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.Black);
            pointer.GenerateLine(int.Parse(textDelta.Text), int.Parse(textBlock.Text),
                GRAPHIS, brush, int.Parse(textD.Text), int.Parse(textH.Text), TextBoxForAll);
            brush.Dispose();
        }

        private void buttonBlack_Click(object sender, EventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.Black);
            pointer.GenerateBlack(int.Parse(textBlack.Text), GRAPHIS, brush, int.Parse(textD.Text), int.Parse(textH.Text), TextBoxForAll);
            brush.Dispose();
        }

        private void buttonWhite_Click(object sender, EventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.White);
            pointer.GenerateWhite(int.Parse(textWhite.Text), GRAPHIS, brush, int.Parse(textD.Text), int.Parse(textH.Text), TextBoxForAll);
            brush.Dispose();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.White);
            pointer.Clear(GRAPHIS, brush);
            brush.Dispose();
        }

        private void negativeButton_Click(object sender, EventArgs e)
        {
            main.Negative();
            DrawLevels(main.getMassForLevels());

            reDrawButton.Enabled = true;
            reGAnerateBurtton.Enabled = true;
            LineButton.Enabled = false;
            MakePointsButton.Enabled = false;
            MakePreviewButton.Enabled = true;
            reDrawPreviewButton.Enabled = false;

            buttonBlack.Enabled = false;
            buttonWhite.Enabled = false;
            buttonClear.Enabled = false;
        }

    }
}
