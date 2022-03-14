using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySimulation
{
    public partial class FrmMain : Form
    {
        #region Draggable Form
        private bool mouseDown;
        private Point lastLocation;

        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void DragForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void DragForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion
        #region Re-Coloring
        private void Coloring(PictureBox sender, Color color)
        {
            Bitmap bmp = new Bitmap (sender.Image);

            int width = bmp.Width;
            int height = bmp.Height;

            Bitmap coloredBmp = new Bitmap(bmp);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);

                    int a = p.A; // A (alpha) değeri şeffaflık durumunu tutar.
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    coloredBmp.SetPixel(x, y, Color.FromArgb(a, color));
                }
            }

            sender.Image = coloredBmp;
        }
        private void Coloring(Button sender, Color color)
        {
            Bitmap bmp = new Bitmap(sender.Image);

            int width = bmp.Width;
            int height = bmp.Height;

            Bitmap coloredBmp = new Bitmap(bmp);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);

                    int a = p.A; // A (alpha) değeri şeffaflık durumunu tutar.
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    coloredBmp.SetPixel(x, y, Color.FromArgb(a, color));
                }
            }

            sender.Image = coloredBmp;
        }
        #endregion
        #region Exit and Minimize Button
        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picExit_MouseHover(object sender, EventArgs e)
        {
            Coloring(picExit, Color.Red);
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picMinimize_MouseHover(object sender, EventArgs e)
        {
            Coloring(picMinimize, Color.LightSeaGreen);
        }

        private void pic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            Coloring(pictureBox, Color.White);
        }
        #endregion
        #region Form and Buttons

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Coloring(btnInfo, Color.Gold);
        }

        #endregion

        public FrmMain()
        {
            InitializeComponent();
        }

        
    }
}
