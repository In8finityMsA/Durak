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

        Point prevPos = new Point(0, 0);
        Point curPos = new Point(0, 0);
        double transformX = 0;
        double transformY = 0;

        public MainWindow() {
            InitializeComponent();
        }

        private void NoBtn_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("NoBtn");
        }

        private void YesBtn_Click(object sender, RoutedEventArgs e) {
            media.Visibility = Visibility.Visible;
            media.Play();
            //MessageBox.Show("YesBtn");
        }



        private void NoBtn_MouseEnter(object sender, MouseEventArgs e) {
            Console.WriteLine("Enter");
            Button btn = sender as Button;
            Random rnd = new Random();
            Vector diff = Point.Subtract(prevPos, curPos);
            double distance = diff.Length;
            double sin = diff.Y / (distance + 1);
            double cos = diff.X / (distance + 1);
            int transdormScalar = 40;
            //Point btnCoord = btn.TransformToAncestor(this).Transform(new Point(0, 0));
            transformX -= (transdormScalar + distance) * cos;
            transformY -= (transdormScalar + distance) * sin;
            TranslateTransform transform = new TranslateTransform(transformX, transformY);
            //TranslateTransform transform = new TranslateTransform(transdormScalar + distance * cos, transdormScalar + distance * sin);
            btn.RenderTransform = transform;
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e) {
            prevPos = curPos;
            curPos = e.GetPosition(this);
            Vector diff = Point.Subtract(prevPos, curPos);
            double distance = diff.Length;
            double sin = diff.Y / distance;
            double cos = diff.X / distance;
            Console.WriteLine(prevPos + "   " + curPos + ":::" + distance);
        }

        private void NoText_MouseEnter(object sender, MouseEventArgs e) {
            MessageBox.Show("OhShit");
        }
    }
}
