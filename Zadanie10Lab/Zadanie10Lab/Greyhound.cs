using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie10Lab
{
    class Greyhound
    {
        public int StartingPosition;
        public int RaceTrackLength;
        public PictureBox MyPictureBox;
        public int Location = 0;
        public Random MyRandom;

        public Greyhound(Random random, PictureBox pictureBox, int startingPostion, PictureBox raceTrackPictureBox)
        {
            MyRandom = random;
            MyPictureBox = pictureBox;
            StartingPosition = startingPostion;
            RaceTrackLength = raceTrackPictureBox.Width - pictureBox.Width;
        }


        public bool Run()
        {
            Location += (int) MyRandom.Next(1, 4);
            MyPictureBox.Left = StartingPosition + Location;

            if(MyPictureBox.Left >= RaceTrackLength - 75)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeStartingPosition()
        {
            Location = 0;

            MyPictureBox.Left = StartingPosition + Location;
        }

    }
}
