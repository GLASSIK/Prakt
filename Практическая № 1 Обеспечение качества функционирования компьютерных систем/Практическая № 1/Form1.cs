using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая___1
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(X.Text);
            int y = Convert.ToInt32(H.Text);
            int h = Convert.ToInt32(Y.Text);
            Pen p = new Pen(Color.Red);
            p.Width = 5;
            g.DrawRectangle(p, x, y, h, h);
            Point p1 = new Point(x, y);
            Point p2 = new Point(x + h, y);
            Point p3 = new Point(x + h, y + h);
            Point p4 = new Point(x, y + h);
            g.DrawLine(p, p1, p3);
            g.DrawLine(p, p2, p4);
            SolidBrush SB = new SolidBrush(Color.Green);
            int h2 = h / 4;
            int k = h / 8;
            g.FillEllipse(SB, x + k + k + k, y + k, h2, h2);
            g.FillEllipse(SB, x + k + h / 2 - k - k, y + k + h / 2, h2, h2);
            pictureBox1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            pictureBox1.BackColor = Color.LightSkyBlue;

        }
    }
}
