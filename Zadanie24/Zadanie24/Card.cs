using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie24
{
    internal class Card
    {
        public Suits Suit;
        public Values Value;

        public string Name
        {
            get
            {
                return Value.ToString() + " of " + Suit.ToString();
            }
        }

        public Card(Suits suit, Values value)
        {
            Suit = suit;
            Value = value;
        }
        public Card(int suit, int value)
        {
            Suit = (Suits)suit;
            Value = (Values)value;
        }
    }
}
