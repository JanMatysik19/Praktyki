using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie14
{
    class Locksmith
    {
        public void OpenSafe(Safe safe, Owner owner)
        {
            safe.PickLock(this);
            Jewels safeContents = safe.Open(writtenDownCombination);
            ReturnContents(safeContents, owner);
        }

        private string writtenDownCombination = null;
        public void WrtieDownCombination(string combination)
        {
            writtenDownCombination = combination;
        }

        public virtual void ReturnContents(Jewels safeContents, Owner owner)
        {
            owner.ReciveContents(safeContents);
        }
    }
}
