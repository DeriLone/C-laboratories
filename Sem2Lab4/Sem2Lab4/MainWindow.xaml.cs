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

namespace Sem2Lab4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double a = 0, b = 0, c = 0;
        char symbol = '+';

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == "0")
                TextBox.Clear();
            TextBox.Text += (sender as Button).Content;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox.Text = "0";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (!TextBox.Text.Contains('.'))
            {
                TextBox.Text += (sender as Button).Content;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(TextBox.Text);
            symbol = Convert.ToString((sender as Button).Content)[0];
            TextBox.Clear();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            b = Convert.ToDouble(TextBox.Text);
            switch (symbol)
            {
                case '+':
                    c = a + b;
                    break;
                case '-':
                    c = a - b;
                    break;
                case '*':
                    c = a * b;
                    break;
                case '/':
                    c = a / b;
                    break;
            }
            TextBox.Text = c.ToString();
        }
    }
}
