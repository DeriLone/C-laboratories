using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem2Lab8
{
    public partial class Form1 : Form
    {
        public string path = @"C:\Users\Никита\source\repos\Sem2Lab8\text.txt";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine($"TextBox1.Text = {textBox1.Text}");
                sw.WriteLine($"CheckBox1.Checked = {checkBox1.Checked}");
                sw.WriteLine($"CheckBox2.Checked = {checkBox2.Checked}");
                sw.WriteLine($"Form1.Width = {this.Size.Width}");
                sw.WriteLine($"Form1.Height = {this.Size.Height}");
            }
        }
    }
}
