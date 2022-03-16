using LibrarySimulation.Data;
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
        private Bitmap ImageColoring (Image img, Color color)
        {
            Bitmap bmp = new Bitmap(img);

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

            return coloredBmp;
        }

        private void Coloring(Button sender, Color color)
        {
            sender.Image = ImageColoring(sender.Image, color);
        }
        #endregion
        #region Exit and Minimize Button
        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picExit_MouseHover(object sender, EventArgs e)
        {
            picExit.Image = ImageColoring(picExit.Image, Color.Red);
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picMinimize_MouseHover(object sender, EventArgs e)
        {
            picMinimize.Image = ImageColoring(picMinimize.Image, Color.LightSeaGreen);
        }

        private void pic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = ImageColoring(pictureBox.Image, Color.White);
        }
        #endregion
        #region Form and Buttons
        private void FrmMain_Load(object sender, EventArgs e)
        {
            Coloring(btnInfo, Color.Gold);

            BookDbContext bookDbContext = new BookDbContext();
            bookDbContext.Database.EnsureCreated();

            //MessageBox.Show(isCreated ? "Veritabanı kuruldu" : "Veritabanı başarısız");

            ucBook.dgvBookList.DataSource = bookDbContext.Books.ToList();
            ucAuthor.dgvAuthorList.DataSource = bookDbContext.Authors.ToList();
            ucCategory.dgvCategoryList.DataSource = bookDbContext.Categories.ToList();
            ucUser.dgvUserList.DataSource = bookDbContext.Users.ToList();
            
        }
        private void ColorOff()
        {
            Coloring(btnInfo, Color.White);
            Coloring(btnBook, Color.White);
            Coloring(btnAuthor, Color.White);
            Coloring(btnCategory, Color.White);
            Coloring(btnUser, Color.White);
            Coloring(btnTakeBook, Color.White);

            btnInfo.ForeColor = Color.White;
            btnBook.ForeColor = Color.White;
            btnAuthor.ForeColor = Color.White;
            btnCategory.ForeColor = Color.White;
            btnUser.ForeColor = Color.White;
            btnTakeBook.ForeColor = Color.White;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            ColorOff();
            Button button = (Button)sender;
            button.ForeColor = Color.Gold;
            Coloring(button, Color.Gold);

            switch (button.Name)
            {
                case "btnInfo":
                    ucInfo.BringToFront();

                    break;
                case "btnBook":
                    ucBook.BringToFront();
                    ucBook.UC_Load();
                    break;
                case "btnAuthor":
                    ucAuthor.BringToFront();
                    ucAuthor.UC_Load();
                    break;
                case "btnCategory":
                    ucCategory.BringToFront();
                    ucCategory.UC_Load();
                    break;
                case "btnUser":
                    ucUser.BringToFront();
                    ucUser.UC_Load();
                    break;
                case "btnTakeBook":
                    ucTakeBook.BringToFront();

                    break;
            }
        }
        #endregion

        public FrmMain()
        {
            InitializeComponent();
        }
    }
}
