using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TrabajoPracticoTED
{
    public partial class SistemaNerviosoForm : Form
    {
        private bool btnDown;
        private int offsetX;
        private int offsetY;
        private int angulo = 0;
        private Bitmap image = new Bitmap(@"C:\Users\gasto\Source\TrabajoPracticoTED\Imagenes\Sin título.png");
        Bitmap img = null;

        public SistemaNerviosoForm()
        {
            InitializeComponent();
            this.Width = 1200;
            this.CenterToScreen();
            img = (Bitmap)image.Clone();
        }

        private void Form_closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();
            if (e.Button == MouseButtons.Left)
            {
                btnDown = true;
                offsetX = e.X;
                offsetY = e.Y;
            }
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (btnDown)
            {
                // mover el pictureBox con el raton               
                pictureBox1.Left += e.X - offsetX;
                pictureBox1.Top += e.Y - offsetY;
            }
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                btnDown = false;
            }
        }

        private void Rotar()
        {

            /*
            pictureBox1.Refresh();
            Graphics g = Graphics.FromImage(img);
            //Graphics g = pictureBox1.CreateGraphics();
            g.TranslateTransform((float)img.Width / 2, (float)img.Height / 2);
            g.RotateTransform(20);
            g.TranslateTransform(-(float)img.Width / 2, -(float)img.Height / 2);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bicubic;
            g.DrawImage(img, 0, 0);
            pictureBox1.Image = img;
            */
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.angulo += 10;
            Rotar();
        }
    }
}
