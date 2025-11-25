using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _19_5
{
    public partial class Form1 : Form
    {
        string[] imageURLs = Directory.GetFiles(@"C:\Users\BI\Pictures\Screenshots");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = imageURLs[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = imageURLs[button1.ImageIndex];
            if (button1.ImageIndex > 0)
            {
                --button1 .ImageIndex;
                button2 .ImageIndex = button1 .ImageIndex +1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = imageURLs[button2.ImageIndex];
            if (button1.ImageIndex < imageList1.Images.Count -1)
            {
                ++button2.ImageIndex;
                button1.ImageIndex = button2.ImageIndex - 1;
            }
        }
    }
}
