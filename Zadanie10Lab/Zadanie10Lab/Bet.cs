using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie10Lab
{
    class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public Bet(int Amount, int Dog, Guy Bettor)
        {
            this.Amount = Amount;
            this.Dog = Dog;
            this.Bettor = Bettor;
        }

        public string GetDescription()
        {
            return Bettor.Name + " stawia " + Amount + " zł na charta numer " + Dog;
        }

        public int PayOut(int Winner)
        {
            if(Dog == Winner)
            {
                return Amount * 2;
            }
            else
            {
                return -1 * Amount;
            }
        }
    }
}
