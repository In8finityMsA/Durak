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
        private const int TRANSFORM_SCALAR = 20;

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

        private void CheckBorders(StackPanel panel)
        {
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

        private void MovePanel(StackPanel panel, Point mousePos)
        {
            Point btnCoord = panel.TransformToAncestor(this).Transform(new Point(0, 0));
            Point btnCenter = new Point(btnCoord.X + panel.ActualWidth / 2, btnCoord.Y + panel.ActualHeight / 2);
            Vector diff = Point.Subtract(btnCenter, mousePos);
            double distance = diff.Length > 0 ? diff.Length : 0.01;
            double sin = diff.Y / distance;
            double cos = diff.X / distance;

            transformX += (TRANSFORM_SCALAR + panel.ActualWidth / 2 - distance) * cos;
            transformY += (TRANSFORM_SCALAR + panel.ActualHeight / 2 - distance) * sin;
            TranslateTransform transform = new TranslateTransform(transformX, transformY);
            panel.RenderTransform = transform;
        }

        private void CheckPanelOverlap(Point mousePos)
        {
            StackPanel panel = NoPanel;
            Point mouseCoord = this.TranslatePoint(mousePos, panel);

            if (mouseCoord.X > 0 && mouseCoord.X < panel.ActualWidth && mouseCoord.Y > 0 && mouseCoord.Y < panel.ActualHeight)
            {
                MovePanel(panel, mousePos);
                CheckBorders(panel);
            }
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e) {
            prevPos = curPos;
            curPos = e.GetPosition(this);

            CheckPanelOverlap(curPos);
        }
    }
}
