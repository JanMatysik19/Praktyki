using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF7
{
    internal class Pitcher
    {
        public ObservableCollection<string> pitcherSays {  get; private set; }

        public Pitcher(Ball ball)
        {
            pitcherSays = new ObservableCollection<string>();

            ball.BallInPlay += ball_BallInPlay;
        }

        void ball_BallInPlay(object sender, EventArgs e)
        {
            if(e is BallEventArgs ev)
            {
                if ((ev.Distance < 29) && (ev.Trajectory < 60)) CatchBall(ev.Tur);
                else CoverFirstBase(ev.Tur);
            }
        }



        private void CatchBall(int tur)
        {
            pitcherSays.Add(String.Format("Rzut {0}: Złapałem piłkę.", tur));
        }

        private void CoverFirstBase(int tur)
        {
            pitcherSays.Add(String.Format("Rzut {0}: Pokryłem pierwszą bazę!", tur));
        }
    }
}
