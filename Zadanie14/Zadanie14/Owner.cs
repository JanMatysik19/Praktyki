using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie14
{
    class Owner
    {
        private Jewels returnedContents;
        public void ReciveContents(Jewels safeContents)
        {
            returnedContents = safeContents;
            Console.WriteLine("Dziękuję za zwrócenie klejnotów! " + safeContents.Sparkle());
        }
    }
}
