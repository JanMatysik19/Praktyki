using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie18
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        public string ScaryThingIHave {
            get
            {
                return numberOfScaryThings + " pająków";
            }
        }

        private int numberOfScaryThings;

        public ScaryScary(string FunnyThingIHave, int numberOfScaryThings) : base(FunnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }


        public void ScareLittleChildren()
        {
            Console.WriteLine("Buu! Mam cię!");
        }
    }
}
