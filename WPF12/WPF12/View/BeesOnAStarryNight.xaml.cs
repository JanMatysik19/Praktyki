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
using WPF12.ViewModel;

namespace WPF12.View
{
    /// <summary>
    /// Logika interakcji dla klasy BeesOnAStarryNight.xaml
    /// </summary>
    public partial class BeesOnAStarryNight : Page
    {
        BeeStarViewModel viewModel;

        public BeesOnAStarryNight()
        {
            InitializeComponent();
        }

        private void SizeChangedHandler(object sender, SizeChangedEventArgs e)
        {
            viewModel = this.Resources["viewModel"] as BeeStarViewModel;
            viewModel.PlayAreaSize = new Size(e.NewSize.Width, e.NewSize.Height);
        }
    }
}
