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
    /// Logika interakcji dla klasy AnalogStopWatch.xaml
    /// </summary>
    public partial class AnalogStopWatch : UserControl
    {
        StopwatchViewModel viewModel;

        public AnalogStopWatch()
        {
            InitializeComponent();
            viewModel = this.Resources["viewModel"] as StopwatchViewModel;

            AddMarking();
        }


        private void AddMarking()
        {
            for(int i = 0; i < 360; i +=3)
            {
                Rectangle rectangle = new Rectangle();
                rectangle.Width = (i % 30 == 0) ? 3 : 1;
                rectangle.Height = 15;
                rectangle.Fill = new SolidColorBrush(Colors.Black);
                rectangle.RenderTransformOrigin = new Point(0.5, 0.5);

                TransformGroup transforms = new TransformGroup();
                transforms.Children.Add(new TranslateTransform() { Y = -140 });
                transforms.Children.Add(new RotateTransform() { Angle = i });
                rectangle.RenderTransform = transforms;

                baseGrid.Children.Add(rectangle);
            }
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Start();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Stop();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Reset();
        }

        private void LapButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Lap();
        }
    }
}
