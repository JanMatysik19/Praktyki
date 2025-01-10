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
    /// Logika interakcji dla klasy QueryDetail.xaml
    /// </summary>
    public partial class QueryDetail : Page
    {
        ComicQueryManager cmq;
        public QueryDetail()
        {
            cmq = new ComicQueryManager();
            InitializeComponent();
            list.ItemsSource = cmq.CurrentQueryResults;


            if (MainWindow.currQuery != null)
            {
                Console.WriteLine(MainWindow.currQuery.Title);
                cmq.UpdateQueryResults(MainWindow.currQuery);
                pageTitle.Text = MainWindow.currQuery.Title;
            }
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}
