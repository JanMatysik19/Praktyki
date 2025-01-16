using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF12.Model
{
    internal class BeeStarModel
    {
        public static readonly Size StarSize = new Size(150, 100);

        private readonly Dictionary<Bee, Point> _bees = new Dictionary<Bee, Point>();
        private readonly Dictionary<Star, Point> _stars = new Dictionary<Star, Point>();

        private Size _playAreaSize;

        private Random _random = new Random();


        public BeeStarModel()
        {
            _playAreaSize = Size.Empty;
        }

        public void Update()
        {
            MoveOneBee();
            AddOrRemoveAStar();
        }

        private static bool RectsOverlap(Rect r1, Rect r2)
        {
            r1.Intersect(r2);
            if (r1.Width > 0 || r1.Height > 0) return true;

            return false;
        }

        public Size PlayAreaSize
        {
            get { return _playAreaSize; }
            set
            {
                _playAreaSize = value;
                CreateBees();
                CreateStars();
            }
        }


        private void CreateBees()
        {
            if (PlayAreaSize == Size.Empty) return;

            if(_bees.Count() > 0)
            {
                foreach(Bee be in _bees.Keys.ToList()) MoveOneBee(be);
            } else
            {
                int n = _random.Next(5, 16);

                for(int i = 0; i < n; i++)
                {
                    int s = _random.Next(40, 151);
                    Size size = new Size(s, s);
                    Point location = FindNonOverlappingPoint(size);

                    Bee bee = new Bee(location, size);
                    _bees[bee] = location;
                    OnBeeMoved(bee, location.X, location.Y);
                }
            }
        }

        private void CreateStars()
        {
            if (PlayAreaSize == Size.Empty) return;

            if (_stars.Count() > 0)
            {
                foreach (Star st in _stars.Keys.ToList())
                {
                    st.Location = FindNonOverlappingPoint(StarSize);
                    OnStarChanged(st, false);
                }
            }
            else
            {
                int n = _random.Next(5, 11);

                for (int i = 0; i < n; i++) CreateAStar();
            }
        }
        
        private void CreateAStar()
        {
            Point location = FindNonOverlappingPoint(StarSize);
            Star star = new Star(location);
            _stars[star] = new Point(location.X, location.Y);
            OnStarChanged(star, false);
        }

        private Point FindNonOverlappingPoint(Size size)
        {
            Rect rect;
            bool noOverlap = false;

            int count = 0;
            do
            {
                rect = new Rect(_random.Next((int)PlayAreaSize.Width - 150), _random.Next((int)PlayAreaSize.Height - 150), StarSize.Width, StarSize.Height);

                var overlappingBees = from bee in _bees.Keys
                                      where RectsOverlap(bee.Position, rect)
                                      select bee;

                var overlappingStars = from star in _stars.Keys
                                       where RectsOverlap(new Rect(star.Location.X, star.Location.Y, StarSize.Width, StarSize.Height), rect)
                                       select star;

                if ((overlappingBees.Count() + overlappingStars.Count()) > 0 || (count++ > 1000)) noOverlap = true;
            } while (!noOverlap);

            return new Point(rect.X, rect.Y);
        }

        private void MoveOneBee(Bee bee = null)
        {
            if (_bees.Keys.Count() == 0) return;
            if(bee == null)
            {
                List<Bee> bees = _bees.Keys.ToList();
                bee = bees[_random.Next(bees.Count)];
            }

            bee.Location = FindNonOverlappingPoint(bee.Size);
            _bees[bee] = bee.Location;
            OnBeeMoved(bee, bee.Location.X, bee.Location.Y);
        }

        private void AddOrRemoveAStar()
        {
            if (((_random.Next(2) == 0) || (_stars.Count() <= 5)) & (_stars.Count < 20)) CreateAStar();
            else
            {
                Star starToRemove = _stars.Keys.ToList()[_random.Next(_stars.Count)];
                _stars.Remove(starToRemove);
                OnStarChanged(starToRemove, true);
            }
        }


        public event EventHandler<BeeMovedEventArgs> BeeMoved;
        private void OnBeeMoved(Bee beeThatMoved, double x, double y)
        {
            EventHandler<BeeMovedEventArgs> beeMoved = BeeMoved;
            if(beeMoved != null)
            {
                beeMoved(this, new BeeMovedEventArgs(beeThatMoved, x, y));
            }
        }


        public event EventHandler<StarChangedEventArgs> StarChanged;
        private void OnStarChanged(Star starThatChanged, bool removed)
        {
            EventHandler<StarChangedEventArgs> starChanged = StarChanged;
            if(starChanged != null)
            {
                starChanged(this, new StarChangedEventArgs(starThatChanged, removed));
            }
        }
    }
}
