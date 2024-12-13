using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie24
{
    internal class CardComparer_byValue : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            // Według wartości
            if(x.Value < y.Value) return -1;
            else if(x.Value > y.Value) return 1;
            else
            {
                // Według rodzaju
                if(x.Suit < y.Suit) return -1;
                else if(x.Suit > y.Suit) return 1;
                else return 0;
            }
        }
    }
}
