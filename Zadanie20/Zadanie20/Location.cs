using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie20
{
    internal abstract class Location
    {
        public string Name { get; protected set; }
        public Location[] Exits;

        public Location(string name)
        {
            Name = name;
        }

        public virtual string Descritpion
        {
            get
            {
                string desc = "Stoisz w: " + Name + ". Widzisz wyjścia do następujących lokalizacji: ";
                for(int i = 0; i < Exits.Length; i++)
                {
                    desc += " " + Exits[i].Name;
                    if(i != Exits.Length - 1) desc += ", ";
                }
                desc += ".";
                return desc;
            }
        }
    }
}
