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

namespace WPF13Lab.View
{
    /// <summary>
    /// Logika interakcji dla klasy GameView.xaml
    /// </summary>
    public partial class GameView : Page
    {
        public GameView()
        {
            InitializeComponent();
        }



        public Window window;
        private void loaded(object sender, RoutedEventArgs e)
        {

            window = Window.GetWindow(this);
            window.KeyDown += game_KeyDown;
        }

        private void game_KeyDown(object sender, KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if(e.Key == Key.Escape)
                if (menu.Visibility == Visibility.Visible) menu.Visibility = Visibility.Hidden;
                else menu.Visibility = Visibility.Visible;
        }



        private void canvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Hidden;
        }

        private void exitToMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null) NavigationService.Navigate(new Uri("pack://application:,,,/View/MenuView.xaml"));
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(0);
        }
    }
}
