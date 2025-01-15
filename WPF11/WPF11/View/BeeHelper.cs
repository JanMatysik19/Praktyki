using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using System.Windows;
using System.Windows.Controls;

namespace WPF11.View
{
    internal static class BeeHelper
    {
        public static AnimatedImage BeeFactory(double width, double height, TimeSpan flapInterval)
        {
            List<string> imageNames = new List<string>()
            {
                "bee1.png",
                "bee2.png",
                "bee3.png",
                "bee4.png"
            };

            AnimatedImage bee = new AnimatedImage(imageNames, flapInterval);
            bee.Width = width;
            bee.Height = height;
            return bee;
        }

        public static void SetBeeLocation(AnimatedImage bee, double x, double y)
        {
            Canvas.SetLeft(bee, x);
            Canvas.SetTop(bee, y);
        }


        public static void MakeBeeMove(AnimatedImage bee, double fromX, double toX, double y)
        {
            Canvas.SetTop(bee, y);

            Storyboard storyboard = new Storyboard();
            DoubleAnimation animation = new DoubleAnimation();
            Storyboard.SetTarget(animation, bee);
            Storyboard.SetTargetProperty(animation, new PropertyPath("(Canvas.Left)"));
            animation.From = fromX;
            animation.To = toX;
            animation.Duration = TimeSpan.FromSeconds(3);
            animation.RepeatBehavior = RepeatBehavior.Forever;
            animation.AutoReverse = true;
            storyboard.Children.Add(animation);
            storyboard.Begin();
        }
    }
}
