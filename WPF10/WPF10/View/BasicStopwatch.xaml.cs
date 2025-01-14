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
using WPF10.ViewModel;

namespace WPF10.View
{
    /// <summary>
    /// Logika interakcji dla klasy BasicStopwatch.xaml
    /// </summary>
    public partial class BasicStopwatch : UserControl
    {
        StopwatchViewModel viewModel;

        public BasicStopwatch()
        {
            InitializeComponent();

            viewModel = new StopwatchViewModel();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Start();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Stop();
        }

        private void ResetBtton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Reset();
        }

        private void LapBtton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Lap();
        }
    }
}
