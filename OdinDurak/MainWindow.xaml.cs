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
            StartStakes();
        }

        private void YesBtn_Click(object sender, RoutedEventArgs e) {
            media.Visibility = Visibility.Visible;
            media.Play();
        }

        private void StartStakes()
        {
            Stakes stakes = new Stakes();
            stakes.Show();
            this.Close();
        }



        private void NoBtn_MouseEnter(object sender, MouseEventArgs e) {
            StackPanel panel = sender as StackPanel;
            Vector diff = Point.Subtract(curPos, prevPos);
            double distance = diff.Length > 0 ? diff.Length : 0.01;
            double sin = diff.Y / distance;
            double cos = diff.X / distance;

            //btn.Margin = new Thickness(0, btn.Margin.Top + (TRANSFORM_SCALAR + distance) * sin, btn.Margin.Right - (TRANSFORM_SCALAR + distance) * cos, 0);

            transformX += (TRANSFORM_SCALAR + distance) * cos;
            transformY += (TRANSFORM_SCALAR + distance) * sin;
            TranslateTransform transform = new TranslateTransform(transformX, transformY);
            panel.RenderTransform = transform;

            Point btnCoord = panel.TransformToAncestor(this).Transform(new Point(0, 0));
            if (btnCoord.X + panel.ActualWidth / 3 < 0 || btnCoord.X >= this.ActualWidth - panel.ActualWidth)
            {
                StartStakes();
            }
            if (btnCoord.Y + panel.ActualHeight / 3 < 0 || btnCoord.Y >= this.ActualHeight - panel.ActualHeight)
            {
                StartStakes();
            }
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e) {
            prevPos = curPos;
            curPos = e.GetPosition(this);
        }

        private void NoText_MouseEnter(object sender, MouseEventArgs e) {
            MessageBox.Show("OhShit");
        }
    }
}
