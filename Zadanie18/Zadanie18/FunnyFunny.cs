using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie18
{
    class FunnyFunny : IClown
    {
        public string FunnyThingIHave { get; set; }

        public void Honk()
        {
            Console.WriteLine("Cześć dzieciaki! Mam " + FunnyThingIHave);
        }

        public FunnyFunny(string FunnyThingIHave)
        {
            this.FunnyThingIHave = FunnyThingIHave;
        }
    }
}
