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
            InitializeComponent();
            list.ItemsSource = new ComicQueryManager().AvailableQueries;
        }

        private void list_selection(object sender, SelectionChangedEventArgs e)
        {
            ComicQuery query = list.SelectedItem as ComicQuery;

            if (query != null && NavigationService != null)
            {
                Console.WriteLine(query.Title);
                ComicQueryManager.currQuery = query;
                NavigationService.Navigate(new Uri("/QueryDetail.xaml", UriKind.Relative));
            }
        }
    }
}
