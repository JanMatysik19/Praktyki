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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF11.View
{
    /// <summary>
    /// Logika interakcji dla klasy AnimatedImage.xaml
    /// </summary>
    public partial class AnimatedImage : UserControl
    {
        public AnimatedImage()
        {
            InitializeComponent();
        }

        public AnimatedImage(IEnumerable<string> imageNames, TimeSpan interval) : this()
        {
            StartAnimation(imageNames, interval);
        }

        public void StartAnimation(IEnumerable<string> imageNames, TimeSpan interval)
        {
            Storyboard storyboard = new Storyboard();
            ObjectAnimationUsingKeyFrames animation = new ObjectAnimationUsingKeyFrames();

            Storyboard.SetTarget(animation, image);
            Storyboard.SetTargetProperty(animation, new PropertyPath("Source"));

            TimeSpan currInterval = TimeSpan.FromMilliseconds(0);

            foreach(string imageName in imageNames)
            {
                ObjectKeyFrame keyFrame = new DiscreteObjectKeyFrame();

                keyFrame.Value = CreateImageFromAssets(imageName);
                keyFrame.KeyTime = currInterval;
                animation.KeyFrames.Add(keyFrame);
                currInterval = currInterval.Add(interval);
            }

            storyboard.RepeatBehavior = RepeatBehavior.Forever;
            storyboard.AutoReverse = true;
            storyboard.Children.Add(animation);
            storyboard.Begin();
        }


        private static BitmapImage CreateImageFromAssets(string imageFilename)
        {
            return new BitmapImage(new Uri("pack://application:,,,/Assets/" + imageFilename));
        }
    }
}
