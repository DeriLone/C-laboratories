using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаб1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            string[] ArrayOfSigns = { "7", "8", "9", "/", "4", "5", "6", "*", "1", "2", "3", "-", "0", ".", "=", "+" };

            int buttonSize = 65;
            int counter = 0;

            bool ActiveOperation = false;


            TextBox tBox = new TextBox
            {
                Size = new Size(205, 0),
                Location = new Point(75, 5),
                Font = new Font("Sans", 30),
                ReadOnly = true,
                Enabled = false,
                TextAlign = System.Windows.Forms.HorizontalAlignment.Right,
            };
            this.Controls.Add(tBox);

            Button ButtonDelete = new Button
            {
                Size = new Size(buttonSize, buttonSize - 13),
                Location = new Point(5, 5),
                Font = new Font("Sans", 16),
                FlatStyle = FlatStyle.Standard,
                Text = "CE",
            };

            ButtonDelete.Click += new EventHandler(ButtonDelete_Click);

            this.Controls.Add(ButtonDelete);

            for (int i = 0; i < ArrayOfSigns.Length / 4; i++)
            {
                for (int j = 0; j < ArrayOfSigns.Length / 4; j++)
                {
                    Button button = new Button
                    {
                        Location = new Point(5 + ((buttonSize + 5) * j), 65 + ((buttonSize + 5) * i)),
                        Font = new Font("Sans", 16),
                        Text = ArrayOfSigns[counter++],
                        FlatStyle = FlatStyle.Standard,
                        Size = new Size(buttonSize, buttonSize),
                    };
                    button.Click += new EventHandler(Button_Click);
                    this.Controls.Add(button);
                }
            }

            void Button_Click(object sender, EventArgs e)
            {
                var button = sender as Button;
                double number = 0;

                if (double.TryParse(button.Text, out number))
                {
                    if (ActiveOperation)
                    {
                        tBox.Clear();
                        ActiveOperation = false;
                    }
                    if (tBox.Text == "0" || tBox.Text == "∞" || tBox.Text == "-∞")
                        tBox.Text = button.Text;
                    else
                        tBox.Text += button.Text;
                    return;
                }

                switch (button.Text)
                {
                    case "+":
                        ActiveOperation = true;
                        IsNumberEmpty(Arithmetic.GetResult(button.Text, double.Parse(tBox.Text)));
                        break;
                    case "-":
                        ActiveOperation = true;
                        IsNumberEmpty(Arithmetic.GetResult(button.Text, double.Parse(tBox.Text)));
                        break;
                    case "*":
                        ActiveOperation = true;
                        IsNumberEmpty(Arithmetic.GetResult(button.Text, double.Parse(tBox.Text)));
                        break;
                    case "/":
                        ActiveOperation = true;
                        IsNumberEmpty(Arithmetic.GetResult(button.Text, double.Parse(tBox.Text)));
                        break;
                    case "=":
                        IsNumberEmpty(Arithmetic.GetResult(button.Text, double.Parse(tBox.Text)));
                        break;
                    case ".":
                        if (ActiveOperation || tBox.Text.Contains("."))
                        {
                            return;
                        }
                        tBox.Text += '.';
                        break;
                    default:
                        MessageBox.Show("Something went wrong");
                        break;
                }
            }
 

            void ButtonDelete_Click(object sender, EventArgs e)
            {
                tBox.Clear();
                Arithmetic.Reset();
                tBox.Text = "0";
            }

            void IsNumberEmpty(string result)
            {
                if (!string.IsNullOrEmpty(result))
                {
                    tBox.Text = result;
                }
            }
        }

    }


}
