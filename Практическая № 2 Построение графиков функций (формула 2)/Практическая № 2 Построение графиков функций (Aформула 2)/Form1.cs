using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая___2_Построение_графиков_функций__Aформула_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kx = 10;
            int ky = 10;
            int dy = pictureBox1.Height / 2;
            int dx = pictureBox1.Width / 2;
            Bitmap b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = b;
            Graphics g = Graphics.FromImage(b);
            SolidBrush solidBrush = new SolidBrush(Color.White);
            g.FillRectangle(solidBrush, 0, 0, pictureBox1.Width, pictureBox1.Height);
            Pen pen = new Pen(Color.Blue);
            pen.Width = 3;
            Point[] mas = new Point[0];
            int i = 0;
            for (double x = 0.1; x <= 10; x += 0.1) // x начинается от 0.1, чтобы избежать деления на 0
            {
                Array.Resize(ref mas, i + 1);
                double y = 5 / x; // a = 5 (вы можете изменить значение a по своему усмотрению)
                mas[i] = new Point(Convert.ToInt32(x * kx) + dx, Convert.ToInt32(-y * ky) + dy); // Инвертируем значение y для правильного отображения на графике
                i++;
            }
            Pen p3 = new Pen(Color.Black);
            p3.Width = 2;
            g.DrawLine(p3, 0, dy, pictureBox1.Width, dy);
            g.DrawLine(p3, dx, 0, dx, pictureBox1.Height);
            g.DrawLines(pen, mas);
            pictureBox1.Refresh();
        }
    }
}
