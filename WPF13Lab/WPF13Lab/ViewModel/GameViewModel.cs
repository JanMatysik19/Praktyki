using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WPF13Lab.Model;
using WPF13Lab.View;

namespace WPF13Lab.ViewModel
{
    internal class GameViewModel
    {

        private readonly ObservableCollection<UIElement> _sprites = new ObservableCollection<UIElement>();
        public INotifyCollectionChanged Sprites { get { return _sprites; } }

        private readonly Dictionary<Star, StarControl> _stars = new Dictionary<Star, StarControl>();

        private readonly StarModel _model = new StarModel();

        public Size PlayAreaSize
        {
            get { return _model.PlayAreaSize; }
            set {
                _model.PlayAreaSize = value;
                Update();
            }
        }


        private void Update()
        {
            _sprites.Clear();
            _stars.Clear();

            int i = 0;
            foreach (Star star in _model.Stars.Keys)
            {
                StarControl newStar = new StarControl(i);
                newStar.set();

                _stars.Add(star, newStar);
                _sprites.Add(newStar);

                StarHelper.SetCanvasLocation(newStar, star.Location.X, star.Location.Y);
                i++;
            }
        }
    }
}
