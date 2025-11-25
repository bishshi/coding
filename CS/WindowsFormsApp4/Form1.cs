using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Message.Text = "您计算机配置如下：";
            Message.Text += "\n CPU:" + comboBox1.Text; Message.Text += "\n 内存";
            if (listBox1.SelectedIndex > -1) Message.Text += listBox1.SelectedItem.ToString();
            else Message.Text += "没有选择内存！";
            if (Disk1.Checked) Message.Text += "\n 硬盘：" + Disk1.Text;
            else if (Disk2.Checked) Message.Text += "\n 硬盘：" + Disk2.Text;
            if (Player1.Checked) Message.Text += "\n 显示器：" + Player1.Text;
            else if (Player2.Checked) Message.Text += "\n 显示器：" + Player2.Text;
            else if (Player3.Checked) Message.Text += "\n 显示器：" + Player3.Text;
            Message.Text += "\n配件：";
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                for (int i = 0; i < checkedListBox1.CheckedItems.Count - 1; i++)
                {
                    Message.Text += checkedListBox1.CheckedItems[i].ToString() + " ";
                }
            }
            else Message.Text += "没有选择配件";
        }
    }
}
