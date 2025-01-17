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
using WPF13Lab.ViewModel;

namespace WPF13Lab.View
{
    /// <summary>
    /// Logika interakcji dla klasy MenuView.xaml
    /// </summary>
    public partial class MenuView : Page
    {
        GameViewModel viewModel;

        public MenuView()
        {
            InitializeComponent();
        }

        


        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            if(NavigationService != null) NavigationService.Navigate(new Uri("pack://application:,,,/View/GameView.xaml"));
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(0);
        }

        private void SizeChangedHandler(object sender, SizeChangedEventArgs e)
        {
            viewModel = this.Resources["viewModel"] as GameViewModel;
            viewModel.PlayAreaSize = new Size(e.NewSize.Width, e.NewSize.Height);
        }
    }
}
