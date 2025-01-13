using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF7
{
    internal class Ball
    {
        public event EventHandler BallInPlay;
        public void OnBallInPlay(BallEventArgs e)
        {
            EventHandler ballInPlay = BallInPlay;
            if(BallInPlay != null) ballInPlay(this, e);
        }
    }

    internal class BallEventArgs : EventArgs
    {
        public int Trajectory {  get; private set; }
        public int Distance { get; private set; }
        public int Tur { get; private set; }

        public BallEventArgs(int trajectory, int distance, int tur)
        {
            this.Trajectory = trajectory;
            this.Distance = distance;
            this.Tur = tur;
        }
    }
}
