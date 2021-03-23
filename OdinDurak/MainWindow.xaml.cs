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

namespace OdinDurak {
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        private Point prevPos = new Point(0, 0);
        private Point curPos = new Point(0, 0);
        private double transformX = 0;
        private double transformY = 0;
        private const int TRANSFORM_SCALAR = 40;

        public MainWindow() {
            InitializeComponent();
        }

        private void NoBtn_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("NoBtn");
        }

        private void YesBtn_Click(object sender, RoutedEventArgs e) {
            media.Visibility = Visibility.Visible;
            media.Play();
            MessageBox.Show("YesBtn");
        }



        private void NoBtn_MouseEnter(object sender, MouseEventArgs e) {
            Console.WriteLine("Enter");
            Button btn = sender as Button;

            Vector diff = Point.Subtract(curPos, prevPos);
            double distance = diff.Length > 0 ? diff.Length : 0.01;
            double sin = diff.Y / distance;
            double cos = diff.X / distance;

            transformX += (TRANSFORM_SCALAR + distance) * cos;
            transformY += (TRANSFORM_SCALAR + distance) * sin;
            TranslateTransform transform = new TranslateTransform(transformX, transformY);
            btn.RenderTransform = transform;

            Point btnCoord = btn.TransformToAncestor(this).Transform(new Point(0, 0));
            Console.WriteLine($"({btnCoord.X}, {btnCoord.Y})");
            if (btnCoord.X < 0 || btnCoord.X >= this.ActualWidth - btn.ActualWidth)
            {
                MessageBox.Show("X out");
            }
            if (btnCoord.Y < 0 || btnCoord.Y >= this.ActualHeight - btn.ActualHeight)
            {
                MessageBox.Show("Y out");
            }

        }

        private void Grid_MouseMove(object sender, MouseEventArgs e) {
            prevPos = curPos;
            curPos = e.GetPosition(this);
            Vector diff = Point.Subtract(curPos, prevPos);
            double distance = diff.Length > 0 ? diff.Length : 0.01;
            double sin = diff.Y / distance;
            double cos = diff.X / distance;
            //Console.WriteLine(diff.X + "   " + diff.Y + ":::" + distance + "; cos:" + cos + "; sin:" + sin);
        }

        private void NoText_MouseEnter(object sender, MouseEventArgs e) {
            MessageBox.Show("OhShit");
        }
    }
}
