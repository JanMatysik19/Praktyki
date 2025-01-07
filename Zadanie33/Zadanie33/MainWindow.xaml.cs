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

namespace Zadanie33
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<String> arr;
        Random rnd;

        public MainWindow()
        {
            InitializeComponent();
            rnd = new Random();

            arr = new List<String>();
            arr.Add("Ala ma kota");
            arr.Add("Kot ma Alę");
            arr.Add("Kitku jest puszysty");
            arr.Add("Domek na drzewie");
            arr.Add("Programieren");
        }

        private void sayBtnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(arr[rnd.Next(0, arr.Count)], "Mówienie - wiadomość", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
