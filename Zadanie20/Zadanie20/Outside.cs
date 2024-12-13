using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie20
{
    internal class Outside : Location
    {
        private bool hot;

        public Outside(string name, bool hot) : base(name)
        {
            this.hot = hot;
        }

        public override string Descritpion
        {
            get
            {
                string desc = base.Descritpion;
                if (hot) desc += " Tutaj jest bardzo gorąco.";
                return desc;
            }
        }
    }
}
