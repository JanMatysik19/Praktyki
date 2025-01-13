using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie36
{
    internal class Suzanne
    {
        public GetSecretIndegrient MySecretIndegrientMethod
        {
            get { return new GetSecretIndegrient(SuzannesSecretIndegrient); }
        }

        private string SuzannesSecretIndegrient(int amount)
        {
            return amount.ToString() + " dekagramów goździków";
        }
    }
}
