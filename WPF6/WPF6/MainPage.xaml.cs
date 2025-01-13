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
    /// Logika interakcji dla klasy MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            ComicQueryManager cqm = new ComicQueryManager();
            InitializeComponent();
            list.ItemsSource = cqm.AvailableQueries;
        }

        private async void list_selection(object sender, SelectionChangedEventArgs e)
        {
            MainWindow.currQuery = list.SelectedItem as ComicQuery;

            SuspensionManager.CurrentQuery = MainWindow.currQuery.Title;

            if (MainWindow.currQuery != null && NavigationService != null)
            {
                Console.WriteLine(MainWindow.currQuery.Title);
                NavigationService.Navigate(new Uri("/QueryDetail.xaml", UriKind.Relative));
            }
        }
    }
}
