using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie12
{
    public class Farmer
    {
        public int BagsOfFeed {
            get {
                return NumberOfCows * FeedMultiplier;
            }
        }

        
        private int feedMultiplier;
        public int FeedMultiplier {
            get {
                return feedMultiplier;
            }
        }


        private int numberOfCows;
        public int NumberOfCows
        {
            get {
                return numberOfCows;
            }
            set {
                numberOfCows = value;
            }
        }


        public Farmer(int NumberOfCows = 0, int feedMultiplier = 30)
        {
            this.feedMultiplier = feedMultiplier;
            numberOfCows = NumberOfCows;
        }
    }
}
