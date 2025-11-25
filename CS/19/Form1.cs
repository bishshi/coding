using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1= new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:/";
            openFileDialog1.Filter = "rtf files (*.rtf) | *.rtf";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1= new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:/";
            saveFileDialog1.Filter = "rtf files (*.rtf) | *.rtf";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(saveFileDialog1.FileName);
            }
        }

        private void buttonFonts_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1= new FontDialog();
            fontDialog1.ShowColor = true;
            fontDialog1.Font=richTextBox1.SelectionFont;
            fontDialog1.Color = richTextBox1.SelectionColor;
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
                richTextBox1.SelectionColor = fontDialog1.Color;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
