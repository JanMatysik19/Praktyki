using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF7
{
    internal class BaseballSimulator
    {
        private Ball ball = new Ball();
        private Pitcher pitcher;
        private Fan fan;

        public ObservableCollection<string> FanSays {  get { return fan.fanSays; } }
        public ObservableCollection<string> PitcherSays { get { return pitcher.pitcherSays; } }

        public int Trajectory { get; set; }
        public int Distance { get; set; }

        public BaseballSimulator()
        {
            pitcher = new Pitcher(ball);

            fan = new Fan(ball);
        }

        public void PlayBall(int Tur)
        {
            BallEventArgs ballEventArgs = new BallEventArgs(Trajectory, Distance, Tur);
            ball.OnBallInPlay(ballEventArgs);
        }
    }
}
