using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF13Lab.View
{
    /// <summary>
    /// Logika interakcji dla klasy StarControl.xaml
    /// </summary>
    public partial class StarControl : UserControl
    {

        private int _id;
        public StarControl(int id)
        {
            InitializeComponent();

            _id = id;
        }


        public async void set()
        {

            if(_id >= 0 && _id <= 2) starPolygon.Fill = Brushes.White;
            else if(_id >= 3 && _id <= 5) starPolygon.Fill = Brushes.Yellow;
            else if(_id >= 6 && _id <= 7) starPolygon.Fill = Brushes.Blue;
            else starPolygon.Fill = Brushes.Red;

            var random = new Random();
            await setDelay(random.Next(0, 1601));
            (this.Resources["sparkle"] as Storyboard).Begin();
        }

        private async Task setDelay(int ms)
        {
            await Task.Delay(ms);

            Storyboard storyboard = new Storyboard();
            DoubleAnimation animation = new DoubleAnimation();
            Storyboard.SetTarget(animation, this);
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));
            animation.From = 0.6;
            animation.To = 1;
            animation.Duration = TimeSpan.FromSeconds(2);
            animation.RepeatBehavior = RepeatBehavior.Forever;
            animation.AutoReverse = true;
            storyboard.Children.Add(animation);
            storyboard.Begin();

            //(this.Resources["sparkle"] as Storyboard).Begin();
        }
    }
}
