using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sem2Lab5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int AMOUNT = 16;
        static int[] numbers = new int[AMOUNT];
        static Button[] buttons = new Button[AMOUNT];
        static int lastBtn = 0;
        Label congrats = new Label();
        Canvas c = new Canvas();

        public MainWindow()
        {
            InitializeComponent();

            numbersSet();
            congrats.Content = "Молодець!";
            congrats.Margin = new Thickness(210, 90, 0, 0);
            congrats.Visibility = Visibility.Hidden;
            c.Children.Add(congrats);

            buttonsInit();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text != "")
            {
                Box.Items.Add(textBox.Text);
                textBox.Clear();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBox.Text != "")
            {
                Box.Items.Remove(textBox.Text);
                textBox.Clear();
            }
        }

        static void numbersSet()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int temp;
                do
                {
                    temp = (int)(new Random()).Next(1, 17);

                    if (!numbers.Contains<int>(temp))
                    {
                        numbers[i] = temp;
                        break;
                    }
                } while (numbers.Contains<int>(temp));
            }
        }

        void resetBtns()
        {
            c.Children.Clear();
            lastBtn = 0;
            numbers = new int[AMOUNT];
            numbersSet();
            buttons = new Button[AMOUNT];
            buttonsInit();
            c.Children.Add(congrats);
        }

        void shuffleBtns()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    double x = buttons[i].Margin.Left;
                    double y = buttons[i].Margin.Top;

                    buttons[i].Margin = new Thickness(buttons[j].Margin.Left, buttons[j].Margin.Top, 0, 0);
                    buttons[j].Margin = new Thickness(x, y, 0, 0);
                }
            }
        }

        void buttonsInit()
        {
            for (int i = 0, j = 0, k = 0; i < buttons.Length; i++, j++)
            {
                if (j == 4)
                {
                    j = 0;
                    k++;
                }

                buttons[i] = new Button();
                buttons[i].Content = numbers[i].ToString();
                buttons[i].Width = 45;
                buttons[i].Height = 45;
                buttons[i].Margin = new Thickness(k * 45 + 5, j * 45 + 5, 0, 0);

                buttons[i].Click += (s, e) =>
                {
                    congrats.Visibility = Visibility.Hidden;
                    shuffleBtns();

                    Button temp = s as Button;
                    int num = Int16.Parse(temp.Content.ToString());

                    (temp).Visibility = Visibility.Hidden;

                    if (lastBtn != num - 1)
                    {
                        resetBtns();
                    }
                    else if (num == 16)
                    {
                        resetBtns();
                        congrats.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        lastBtn = num;
                    }
                };
                c.Children.Add(buttons[i]);
            }

            Page2.Content = c;
        }
    }
}
