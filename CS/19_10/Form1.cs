using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; Pen pen = new Pen(Color.Red, 3);
            SolidBrush brush = new SolidBrush(Color.Blue);
            Font font = new Font("宋体", 12);
            g.DrawLine(pen, 5, 5, 215, 5);
            g.DrawString("Line", font, brush, 210, 0);
            g.DrawRectangle(pen, 5, 10, 100, 15);
            g.FillRectangle(brush, 110, 10, 100, 15);
            g.DrawString("Rectangle", font, brush, 210, 15);
            g.DrawEllipse(pen, 5, 30, 100, 15);
            g.FillEllipse(brush, 110, 30, 100, 15);
            g.DrawString("Ellipse", font, brush, 210, 30);
            Point[] pts1 = { new Point(50, 50), new Point(25, 75), new Point(75, 75) };
            g.DrawPolygon(pen, pts1);
            Point[] pts2 = { new Point(150, 50), new Point(125, 75), new Point(175, 75) };
            g.FillPolygon(brush, pts2);
            g.DrawString("Polygon", font, brush, 210, 50);
            for (int i= 0; i < 360; i += 60)
            {
                g.DrawArc(pen, 5, 100, 80, 80, i, 30);
            }
            g.DrawString("Arc", font, brush, 5, 190);
            Rectangle rec2 = new Rectangle(100, 90, 100, 100);
        }
    }
}
