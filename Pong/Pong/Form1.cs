using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        public int speed_left = 4;
        public int speed_top = 4;
        public int point = 0;
        public Form1()
        {
            InitializeComponent();
            racket.Size = new Size(200, 20);
            racket.BackColor = Color.Black;

            ball.Size = new Size(30, 30);
            ball.BackColor = Color.Red;

            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            racket.Top = playground.Bottom - (playground.Bottom / 12);

            gameover.Text = "Game Over\n F1:Restart\n Esc:Exit";
            gameover.Font = new Font("Time New Roman", 30, FontStyle.Bold);
            gameover.Visible = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
            {
                this.Close();
            }
            if (e.KeyCode.Equals(Keys.F1))
            {
                ball.Top = 50;
                ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                timer1.Enabled = true;
                playground.BackColor = Color.White;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);
            ball.Left += speed_left;
            ball.Top += speed_top;
            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= (racket.Left - ball.Width) && ball.Right <= (racket.Right + ball.Width))
            {
                speed_top += 4;
                speed_left += 4;
                speed_top = -speed_top;

                point += 1;
                points.Text = point.ToString();
                racket.Width -= 10;

                Random rand = new Random();
                int r = rand.Next(0, 220);
                int g = rand.Next(0, 255);
                int b = rand.Next(0, 255);
                playground.BackColor = Color.FromArgb(r, g, b);
            }
            if (ball.Left <= playground.Left)
            {
                speed_left = -speed_left;
            }
            if (ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }
            if (ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }
            if (ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false;
            }
            if (point % 5 == 0 && point > 0)
            {
                PictureBox newBall = new PictureBox(); // 假設Ball是您的球的類別
                newBall.Size = new Size(30, 30);
                newBall.BackColor = Color.Red;
                newBall.Left = 50; // 設定初始位置，根據需要調整
                newBall.Top = 50;
                playground.Controls.Add(newBall);
            }

        }
    }
}
