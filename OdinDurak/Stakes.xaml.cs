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
using System.Windows.Shapes;

namespace OdinDurak
{
    /// <summary>
    /// Логика взаимодействия для stakes.xaml
    /// </summary>
    public partial class Stakes : Window
    {

        private readonly int correct;
        private const string CHEAT = "NOYOU";
        private StringBuilder input;
        private bool isCheat = false;
        public Stakes()
        {
            InitializeComponent();

            correct = Choice();
            input = new StringBuilder();
            foreach (UIElement button in GridRoot.Children)
            {
                if (button is Button)
                {
                    ((Button)button).Click += Button_Click;
                }
            }
        }

        private static int Choice()
        {
            Random _rand = new Random();
            return _rand.Next(1, 9);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = (string)((Button)e.OriginalSource).Tag;
            int input = Int32.Parse(s);
            
            if(correct == input)
            {
                MessageBox.Show("YOU WON!");
                this.Close();
            }
            else
            {
                MessageBox.Show("LOVI BDOS V EBALO MATHAFACKAR");
                System.Diagnostics.Process.Start("Assets\\notmyfault64.exe", "/crash");
            }
            
        }

        private void Stakes_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("Key DOwn");
            if (!isCheat)
            {
                Console.WriteLine(e.Key.ToString().ToUpper());
                if (e.Key.ToString().ToUpper().Equals(CHEAT[input.Length].ToString()))
                {
                    Console.WriteLine(input);
                    input.Append(e.Key.ToString());
                    if (input.Length == CHEAT.Length)
                    {
                        MessageBox.Show("It's a simple spell but quite unbreakable");
                        isCheat = true;
                        foreach (UIElement button in GridRoot.Children)
                        {
                            (button as Button).MouseEnter += Button_MouseEnter;
                            (button as Button).MouseLeave += Button_MouseLeave;
                        }
                    }
                }
                else
                {
                    Console.WriteLine(input);
                    input.Clear();
                }

            }
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            string s = (string)((Button)e.OriginalSource).Tag;
            btn.Content = s;
            btn.FontSize = 48;
            btn.Foreground = Brushes.Black;
            btn.Background = Brushes.LightGray;

        }

        private void Button_MouseEnter(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string s = (string)((Button)e.OriginalSource).Tag;
            int input = Int32.Parse(s);
            if (input != correct)
            {
                btn.Content = "BSOD";
                btn.FontSize = 24;
                btn.Foreground = Brushes.White;
                btn.Background = new SolidColorBrush(Color.FromRgb(0,0,130));
            }
            else
            {
                btn.Content = "WIN";
                btn.FontSize = 24;
                btn.Foreground = Brushes.Black;
                btn.Background = Brushes.Gold;
            }
        }
    }
}
