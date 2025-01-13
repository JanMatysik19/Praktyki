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

namespace WPF6
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ComicQuery currQuery {  get; set; }

        public MainWindow()
        {
            ComicQueryManager cqm = new ComicQueryManager();

            SuspensionManager.RestoreAsync();


            InitializeComponent();

            if (!String.IsNullOrEmpty(SuspensionManager.CurrentQuery))
            {
                Console.WriteLine("Test: " + SuspensionManager.CurrentQuery);
                foreach (ComicQuery query in cqm.AvailableQueries)
                {
                    if (query.Title == SuspensionManager.CurrentQuery)
                    {
                        MainWindow.currQuery = query;
                        mainFrame.Source = new Uri("/QueryDetail.xaml", UriKind.Relative);
                    }
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SuspensionManager.SaveAsync();
        }
    }
}
