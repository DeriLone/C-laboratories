using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private int counter = 0;

        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 300;
            timer1.Tick += new EventHandler(FlashingText);
            timer1.Start();

            button1.BringToFront();
        }

        private void FlashingText(object sender, EventArgs e)
        {
            if(counter <= 14)
            {
                label1.Visible = !label1.Visible;
                counter++;
            }
            else
            {
                label1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Кнопка “Ок” була натиснута";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X > button1.Location.X - 20 && e.Y > button1.Location.Y - 20 &&
                e.X < button1.Location.X + button1.Size.Width / 2 && e.Y < button1.Location.Y + button1.Size.Height / 2)
            {
                button1.Location = new Point(button1.Location.X + 5, button1.Location.Y + 5);
                ChangeButtonSize();
            }
            if (e.X > button1.Location.X - 20 && e.Y < button1.Location.Y + button1.Size.Height + 20 &&
                e.X < button1.Location.X + button1.Size.Width / 2 && e.Y > button1.Location.Y + button1.Size.Height / 2)
            {
                button1.Location = new Point(button1.Location.X + 5, button1.Location.Y - 5);
                ChangeButtonSize();
            }
            if (e.X < button1.Location.X + button1.Size.Width + 20 && e.Y < button1.Location.Y + button1.Size.Height + 20 &&
                e.X > button1.Location.X + button1.Size.Width / 2 && e.Y > button1.Location.Y + button1.Size.Height / 2)
            {
                button1.Location = new Point(button1.Location.X - 5, button1.Location.Y - 5);
                ChangeButtonSize();
            }
            if (e.X < button1.Location.X + button1.Size.Width + 20 && e.Y > button1.Location.Y - 20 &&
                e.X > button1.Location.X + button1.Size.Width / 2 && e.Y < button1.Location.Y + button1.Size.Height / 2)
            {
                button1.Location = new Point(button1.Location.X - 5, button1.Location.Y + 5);
                ChangeButtonSize();
            }
        }

        private void button1_LocationChanged(object sender, EventArgs e)
        {
            if(button1.Location.X <= 5)
            {
                button1.Location = new Point(button1.Location.X + 100, button1.Location.Y);
            }
            if (button1.Location.X >= base.Size.Width - button1.Size.Width - 20)
            {
                button1.Location = new Point(base.Size.Width - 100 - button1.Size.Width, button1.Location.Y);
            }
            if (button1.Location.Y <= 5)
            {
                button1.Location = new Point(button1.Location.X, button1.Location.Y + 100);
            }
            if (button1.Location.Y >= base.Size.Height - button1.Size.Height - 45)
            {
                button1.Location = new Point(button1.Location.X, base.Size.Height - 100 - button1.Size.Height);
            }
        }

        private void ChangeButtonSize()
        {
            button1.Size = new Size(button1.Size.Width, (int)(button1.Size.Height - 0.1));

            if (button1.Size.Width <= 0 || button1.Size.Height <= 0)
            {
                label1.Text = "Кнопка “Ок” не може бути натиснута";
                counter = 0;
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Location = new Point(button1.Location.X + 100, button1.Location.Y + 100);
        }
    }
}