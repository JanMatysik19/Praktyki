using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdanie16
{
    class Bee
    {
        public const double HoneyUnitConsumedPerMg = 0.25D;
        public double Mg {  get; private set; }

        public Bee(double mg)
        {
            Mg = mg;
        }

        virtual public double HoneyConsumptionRate()
        {
            return Mg * HoneyUnitConsumedPerMg;
        }
    }
}
