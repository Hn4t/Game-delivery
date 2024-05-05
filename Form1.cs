using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Доставим_за_15_минут_
{
    public partial class Form1 : Form
    {

        private Point pos;
        private bool dragging;
        public Form1()
        {
            InitializeComponent();

            bg1.MouseDown += MouseClickDowm;
            bg1.MouseUp += MouseClickUp;
            bg1.MouseMove += MouseClickMove;
            bg2.MouseDown += MouseClickDowm;
            bg2.MouseUp += MouseClickUp;
            bg2.MouseMove += MouseClickMove;
            labelLose.Visible = false;
            btnRestart.Visible = false;
            KeyPreview = true;

        }

        private void MouseClickDowm(object sender, MouseEventArgs e)
        {
            dragging = true;
            pos.X = e.X;
            pos.Y = e.Y;
        }
        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if(dragging)
            {
                Point currPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(currPoint.X - pos.X, currPoint.Y - pos.Y + bg1.Top);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int speed = 10;
            bg1.Top += speed;
            bg2.Top += speed;

            int grandmaSpeed = 7;
            grandma1.Top += grandmaSpeed;
            grandma2.Top += grandmaSpeed;

            if (bg1.Top >= 650)
            {
                bg1.Top = 0;
                bg2.Top = -650;
            }

            if (grandma1.Top >= 650)
            {
                grandma1.Top = -160;
                Random rand = new Random();
                grandma1.Left = rand.Next(150, 700);
            }
            if (grandma2.Top >= 650)
            {
                grandma1.Top = -400;
                Random rand = new Random();
                grandma2.Left = rand.Next(150, 700);
            }

            if (player.Bounds.IntersectsWith(grandma1.Bounds) || (player.Bounds.IntersectsWith(grandma2.Bounds)))
                {
                timer1.Enabled = false;
                labelLose.Visible = true;
                btnRestart.Visible = true;
            }
            }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int speed = 20;
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && player.Left > 150)
                player.Left -= speed;
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && player.Right <700)
                player.Left += speed;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            player.Left = 300;
            labelLose.Visible = false;
            btnRestart.Visible = false;
            grandma1.Top = -160;
            grandma2.Top = -400;
            timer1.Enabled = true;
        }
    }
}
