﻿using System;
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
using WPF12.Properties;

namespace WPF12.View
{
    /// <summary>
    /// Logika interakcji dla klasy StarControl.xaml
    /// </summary>
    public partial class StarControl : UserControl
    {

        public StarControl()
        {
            InitializeComponent();
        }




        public void FadeIn()
        {
            (this.Resources["fadeInStoryboard"] as Storyboard).Begin();
            //Opacity = 1;
        }



        public void FadeOut()
        {
            (this.Resources["fadeOutStoryboard"] as Storyboard).Begin();
            //Opacity = 0;
        }
    }
}
