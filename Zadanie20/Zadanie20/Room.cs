using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie20
{
    internal class Room : Location
    {
        private string decoration;

        public Room(string name, string decoration) : base(name)
        {
            this.decoration = decoration;
        }

        public override string Descritpion
        {
            get
            {
                string desc = base.Descritpion;
                desc += " Widzisz tutaj " + decoration + ".";
                return desc;
            }
        }
    }
}
