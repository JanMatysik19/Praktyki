using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF7
{
    internal class Fan
    {
        public ObservableCollection<string> fanSays { get; private set; }



        public Fan(Ball ball)
        {
            fanSays = new ObservableCollection<string>();

            ball.BallInPlay += ball_BallInPlay;
        }

        void ball_BallInPlay(object sender, EventArgs e)
        {
            if (e is BallEventArgs ev)
            {
                if ((ev.Distance > 120) && (ev.Trajectory > 30)) CatchBall(ev.Tur);
                else ShoutAndSing(ev.Tur);
            }
        }



        private void CatchBall(int tur)
        {
            fanSays.Add(String.Format("Rzut {0}: Home run! Idę po piłkę!", tur));
        }

        private void ShoutAndSing(int tur)
        {
            fanSays.Add(String.Format("Rzut {0}: Jee! Do boju!", tur));
        }
    }
}
