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
    /// Logika interakcji dla klasy GameView.xaml
    /// </summary>
    public partial class GameView : Page
    {
        AGameViewModel viewModel = null;
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
            {
                if (menu.Visibility == Visibility.Visible)
                {
                    menu.Visibility = Visibility.Hidden;
                    viewModel.HandleGamePauseChange(false);
                }
                else
                {
                    menu.Visibility = Visibility.Visible;
                    viewModel.HandleGamePauseChange(true);
                }
            }


            if(viewModel != null)
            {
                switch(e.Key)
                {
                    case Key.A:
                        viewModel.HandleLeft();
                        break;
                    case Key.D:
                        viewModel.HandleRight();
                        break;
                    case Key.Space:
                    case Key.W:
                        viewModel.HandleShoot();
                        break;
                }
            }
        }



        private void canvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            menu.Visibility = Visibility.Hidden;
            viewModel.HandleGamePauseChange(false);
        }

        private void exitToMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null) NavigationService.Navigate(new Uri("pack://application:,,,/View/MenuView.xaml"));
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(0);
        }

        private void SizeChangedHandler(object sender, SizeChangedEventArgs e)
        {
            viewModel = this.Resources["viewModel"] as AGameViewModel;
            viewModel.PlayAreaSize = new Size(e.NewSize.Width, e.NewSize.Height);
        }
    }
}
