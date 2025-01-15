using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using System.Windows;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using WPF11.View;

namespace WPF11.ViewModel
{
    internal class BeeViewModel
    {
        private readonly ObservableCollection<UIElement> _sprites = new ObservableCollection<UIElement>();

        public INotifyCollectionChanged Sprites { get { return _sprites; } }


        public BeeViewModel()
        {
            AnimatedImage firstBee = BeeHelper.BeeFactory(50D, 50D, TimeSpan.FromMilliseconds(50));
            _sprites.Add(firstBee);

            AnimatedImage secondBee = BeeHelper.BeeFactory(200D, 200D, TimeSpan.FromMilliseconds(10));
            _sprites.Add(secondBee);

            AnimatedImage thirdBee = BeeHelper.BeeFactory(300D, 125D, TimeSpan.FromMilliseconds(100));
            _sprites.Add(thirdBee);

            BeeHelper.MakeBeeMove(firstBee, 50, 450, 40);
            BeeHelper.SetBeeLocation(secondBee, 80, 260);
            BeeHelper.SetBeeLocation(thirdBee, 230, 100);
        }
    }
}
