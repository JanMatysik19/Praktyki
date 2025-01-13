using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie36
{
    internal class Amy
    {
        public GetSecretIndegrient MySecretIndegrientMethod
        {
            get { return new GetSecretIndegrient(AmysSecretIndegrient); }
        }


        private string AmysSecretIndegrient(int amount)
        {
            if (amount < 10) return amount.ToString() + " puszek sardynek -- potrzepujesz więcej!";
            else return amount.ToString() + " puszek sardynek";
        }
    }
}
