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
using System.Windows.Threading;

namespace Sem2Lab6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        private int counter = 0;

        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(FlashingText);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();

        }

        private void FlashingText(object sender, EventArgs e)
        {
            if (counter <= 14)
            {
                if(counter % 2 == 0)
                {
                    base.Title = "Натисніть кнопку 'Ок'!!!";
                }
                else
                {
                    base.Title = "";
                }
                counter++;
            }
            else
            {
                base.Title = "Натисніть кнопку 'Ок'!!!";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кнопка 'Ок' була натиснута");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (button1.Margin.Left <= 5)
            {
                button1.Margin = new Thickness(button1.Margin.Left + 100, button1.Margin.Top, 0, 0);
            }
            if (button1.Margin.Left >= base.Width - button1.Width - 20)
            {
                button1.Margin = new Thickness(base.Width - 100 - button1.Width, button1.Margin.Top, 0, 0);
            }
            if (button1.Margin.Top <= 5)
            {
                button1.Margin = new Thickness(button1.Margin.Left, button1.Margin.Top + 100, 0, 0);
            }
            if (button1.Margin.Top >= base.Height - button1.Height - 45)
            {
                button1.Margin = new Thickness(button1.Margin.Left, base.Height - 100 - button1.Height, 0, 0);
            }


            if (e.GetPosition(c).X > button1.Margin.Left - 20 && e.GetPosition(c).Y > button1.Margin.Top - 20 &&
                e.GetPosition(c).X < button1.Margin.Left + button1.Width / 2 && e.GetPosition(c).Y < button1.Margin.Top + button1.Height / 2)
            {
                button1.Margin = new Thickness(button1.Margin.Left + 5, button1.Margin.Top + 5, 0, 0);
                ChangeButtonSize();
            }
            if (e.GetPosition(c).X > button1.Margin.Left - 20 && e.GetPosition(c).Y < button1.Margin.Top + button1.Height + 20 &&
                e.GetPosition(c).X < button1.Margin.Left + button1.Width / 2 && e.GetPosition(c).Y > button1.Margin.Top + button1.Height / 2)
            {
                button1.Margin = new Thickness(button1.Margin.Left + 5, button1.Margin.Top - 5, 0, 0);
                ChangeButtonSize();
            }
            if (e.GetPosition(c).X < button1.Margin.Left + button1.Width + 20 && e.GetPosition(c).Y < button1.Margin.Top + button1.Height + 20 &&
                e.GetPosition(c).X > button1.Margin.Left + button1.Width / 2 && e.GetPosition(c).Y > button1.Margin.Top + button1.Height / 2)
            {
                button1.Margin = new Thickness(button1.Margin.Left - 5, button1.Margin.Top - 5, 0, 0);
                ChangeButtonSize();
            }
            if (e.GetPosition(c).X < button1.Margin.Left + button1.Width + 20 && e.GetPosition(c).Y > button1.Margin.Top - 20 &&
                e.GetPosition(c).X > button1.Margin.Left + button1.Width / 2 && e.GetPosition(c).Y < button1.Margin.Top + button1.Height / 2)
            {
                button1.Margin = new Thickness(button1.Margin.Left - 5, button1.Margin.Top + 5, 0, 0);
                ChangeButtonSize();
            }
        }

        private void ChangeButtonSize()
        {
            button1.Height = button1.Height - 0.1;

            if (button1.Width <= 0 || button1.Height <= 0)
            {
                base.Title = "Кнопка 'Ок' не може бути натиснута";
                counter = 0;
            }
        }
    }
}
