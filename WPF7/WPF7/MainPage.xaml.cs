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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF7
{
    /// <summary>
    /// Logika interakcji dla klasy MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        BaseballSimulator baseball;
        private int Tur = 1;

        public MainPage()
        {
            InitializeComponent();
            baseball = new BaseballSimulator();

            pitcherSaysList.ItemsSource = baseball.PitcherSays;
            fanSaysList.ItemsSource = baseball.FanSays;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            baseball.PlayBall(Tur);
            Tur++;
        }
    }
}
