using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie8
{
    class Stats
    {
        public int Total;
        public int Missed;
        public int Correct;
        public int Accuracy;
       
        public Stats()
        {
            Total = 0;
            Missed = 0;
            Correct = 0;
            Accuracy = 0;
        }

        public void Update(bool correctKey)
        {
            Total++;

            if(!correctKey)
            {
                Missed++;
            }
            else
            {
                Correct++;
            }

            Accuracy = 100 * Correct / Total;
        }
    }
}
