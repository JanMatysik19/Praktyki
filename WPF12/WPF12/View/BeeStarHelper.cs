using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows;

namespace WPF12.View
{
    internal static class BeeStarHelper
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

        public static void SetCanvasLocation(UIElement uIElement, double x, double y)
        {
            Canvas.SetLeft(uIElement, x);
            Canvas.SetTop(uIElement, y);
        }



        public static void MoveElementOnCanvas(UIElement uIElement, double toX, double toY)
        {
            double fromX = Canvas.GetLeft(uIElement);
            double fromY = Canvas.GetLeft(uIElement);
            
            Storyboard storyboard = new Storyboard();
            DoubleAnimation animationX = CreateDoubleAnimation(uIElement, fromX, toX, "(Canvas.Left)");
            DoubleAnimation animationY = CreateDoubleAnimation(uIElement, fromY, toY, "(Canvas.Top)");

            storyboard.Children.Add(animationX);
            storyboard.Children.Add(animationY);
            storyboard.Begin();
        }


        public static DoubleAnimation CreateDoubleAnimation(UIElement uIElement, double from, double to, string propertyToAnimate)
        {
            DoubleAnimation animation = new DoubleAnimation();
            Storyboard.SetTarget(animation, uIElement);
            Storyboard.SetTargetProperty(animation, new PropertyPath(propertyToAnimate));

            animation.From = from;
            animation.To = to;
            animation.Duration = TimeSpan.FromSeconds(3);

            return animation;
        }


        public static void SendToBack(StarControl newStar)
        {
            Canvas.SetZIndex(newStar, -1000);
        }
    }
}
