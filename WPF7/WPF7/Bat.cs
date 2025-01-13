using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF7
{
    delegate void BatCallback(BallEventArgs e);


    internal class Bat
    {
        private BatCallback hitBallCallback;

        public Bat(BatCallback callbackDelegate)
        {
            this.hitBallCallback = callbackDelegate;
        }

        public void HitTheBall(BallEventArgs e)
        {
            if (hitBallCallback != null) hitBallCallback(e);
        }


        
    }
}
