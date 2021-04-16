using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        const int NumberOFButton = 16;
        int CounterForButton = 1;
        int[] ArrayOfNumbers = new int[NumberOFButton];

        public Form1()
        {
            InitializeComponent();
            ButtonsCreate();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
            textBox1.Text = string.Empty;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(textBox1.Text);
            textBox1.Text = string.Empty;
        }

        private void RandomInp()
        {
            for(int i = 0; i < ArrayOfNumbers.Length; i++)
            {
                int temp;
                do
                {
                    temp = (int)(new Random()).Next(1, 17);

                    if (!ArrayOfNumbers.Contains<int>(temp))
                    {
                        ArrayOfNumbers[i] = temp;
                        break;
                    }
                } while (ArrayOfNumbers.Contains<int>(temp));
            }
        }

        private void ButtonsCreate()
        {
            RandomInp();
            int SizeOfButton = 30;
            int counter = 0;
            for (int i = 0; i < NumberOFButton / 4; i++)
            {
                for (int j = 0; j < NumberOFButton / 4; j++)
                {
                    Button button = new Button
                    {
                        Location = new Point(155 + ((SizeOfButton + 20) * i), 15 + ((SizeOfButton + 10) * j)),
                        Size = new Size(SizeOfButton, SizeOfButton),
                        Text = ArrayOfNumbers[counter].ToString(),
                    };
                    counter++;
                    button.Click += new EventHandler(ButtonClick);
                    tabPage2.Controls.Add(button);
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (CounterForButton == int.Parse(button.Text))
            {
                if (CounterForButton == 16)
                {
                    textBox2.Text = "Молодец!";
                    Reset();
                }
                button.Visible = false;
                NumberChange();
                CounterForButton++;
            }
        }

        private void NumberChange()
        {
            RandomInp();
            int newcounter = 0;
            foreach (var item in tabPage2.Controls)
            {
                Button button = item as Button;
                if (button != null && button.Visible)
                {
                    if (ArrayOfNumbers[newcounter] > CounterForButton)
                        button.Text = ArrayOfNumbers[newcounter].ToString();
                    newcounter++;
                }
            }
         }

            private void Reset()
            {
            CounterForButton = 1;
            tabPage2.Controls.Clear();
            ButtonsCreate();
            }
    }
}
