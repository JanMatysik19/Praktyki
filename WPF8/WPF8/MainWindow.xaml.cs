using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPF8
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> outputItems = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();

            output.ItemsSource = outputItems;
        }





        




        private void borderSetsHandled_Checked(object sender, RoutedEventArgs e)
        {
            if (borderSetsHandled.IsChecked == true) borderSetsHandledLbl.Content = "Włączone";
            else borderSetsHandledLbl.Content = "Wyłączone";
        }

        private void gridSetsHandled_Checked(object sender, RoutedEventArgs e)
        {
            if (gridSetsHandled.IsChecked == true) gridSetsHandledLbl.Content = "Włączone";
            else gridSetsHandledLbl.Content = "Wyłączone";
        }

        private void ellipseSetsHandled_Checked(object sender, RoutedEventArgs e)
        {
            if (ellipseSetsHandled.IsChecked == true) ellipseSetsHandledLbl.Content = "Włączone";
            else ellipseSetsHandledLbl.Content = "Wyłączone";
        }

        private void rectangleSetsHandled_Checked(object sender, RoutedEventArgs e)
        {
            if (rectangleSetsHandled.IsChecked == true) rectagleSetsHandledLbl.Content = "Włączone";
            else rectagleSetsHandledLbl.Content = "Wyłączone";
        }

        private void newHitTestVisibleValue_Checked(object sender, RoutedEventArgs e)
        {
            if (newHitTestVisibleValue.IsChecked == true) newHitTestVisibleValueLbl.Content = "Włączone";
            else newHitTestVisibleValueLbl.Content = "Wyłączone";
        }





        private void Border_PointerPressed(object sender, RoutedEventArgs e)
        {
            if (sender == e.OriginalSource) outputItems.Clear();
            outputItems.Add("Naciśnięto kontrolkę Border");
            if (borderSetsHandled.IsChecked == true) e.Handled = true;
        }

        private void Grid_PointerPressed(object sender, RoutedEventArgs e)
        {
            if (sender == e.OriginalSource) outputItems.Clear();
            outputItems.Add("Naciśnięto kontrolkę Grid");
            if (gridSetsHandled.IsChecked == true) e.Handled = true;
        }

        private void Ellipse_PointerPressed(object sender, RoutedEventArgs e)
        {
            if (sender == e.OriginalSource) outputItems.Clear();
            outputItems.Add("Naciśnięto kontrolkę Ellipse");
            if (ellipseSetsHandled.IsChecked == true) e.Handled = true;
        }

        private void Rectangle_PointerPressed(object sender, RoutedEventArgs e)
        {
            if (sender == e.OriginalSource) outputItems.Clear();
            outputItems.Add("Naciśnięto kontrolkę Rectangle");
            if (rectangleSetsHandled.IsChecked == true) e.Handled = true;
        }

        private void StackPanel_PointerPressed(object sender, RoutedEventArgs e)
        {
            if (sender == e.OriginalSource) outputItems.Clear();
            outputItems.Add("Naciśnięto kontrolkę StackPanel");
        }

        private void UpdateHitTestButton(object sender, RoutedEventArgs e)
        {
            grayRectangle.IsHitTestVisible = (bool) newHitTestVisibleValue.IsChecked;
        }
    }
}
