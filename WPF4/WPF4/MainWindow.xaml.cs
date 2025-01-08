using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.WebSockets;
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

namespace WPF4
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void clone1_Click(object sender, RoutedEventArgs e)
        {
            using (Clone clone1 = new Clone(1))
            {
                // Nico
            }
        }

        private void clone2_Click(object sender, RoutedEventArgs e)
        {
            Clone clone2 = new Clone(2);
            clone2 = null;
        }

        private void gc_Click(object sender, RoutedEventArgs e)
        {
            GC.Collect();
        }
    }
}
