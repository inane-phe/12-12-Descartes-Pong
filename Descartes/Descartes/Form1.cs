using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Descartes
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new Size(800, 600);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.White);
            for (float t = -3 ; t < 40; t+=0.01f)   // t=a影響起點,-3以下才可能連起來; t<=m影響總點數; t+=n 影響點之間的間距
            {
                float x = ((3 * t) / (1 + t*t*t)) * 100;
                float y = ((3 * t *t) / (1 + t * t * t)) * -100;
                g.DrawEllipse(new Pen(Color.Orange), 300 + x, 300 + y, 10, 10);
                g.DrawEllipse(new Pen(Color.Red), 300 + x, 300 - y, 10, 10);
                g.DrawEllipse(new Pen(Color.Blue), 300 - x, 300 + y, 10, 10);
                g.DrawEllipse(new Pen(Color.Yellow), 300 - x, 300 - y, 10, 10);
            }
        }
    }
}
