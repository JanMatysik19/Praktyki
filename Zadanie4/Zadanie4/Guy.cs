using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie4
{
    class Guy
    {
        private string _name;
        private int _cash;

        public Guy(string Name, int Cash = 0)
        {
            _name = Name;
            _cash = Cash;
        }

        public string Name
        {
            set
            {
                this._name = value;
            }
            get
            {
                return this._name;
            }
        }

        public int Cash
        {
            set
            {
                this._cash = value;
            }
            get
            {
                return this._cash;
            }
        }

        public int GiveCash(int amount)
        {
            if(amount <= _cash && amount > 0)
            {
                _cash -= amount;
                
                return amount;
            } 
            else
            {
                MessageBox.Show("Nie mam wystarczającej ilości pieniędzy, aby Ci dać " + amount, _name + " powiedział...");
                return 0;
            }
        }

        public int ReciveCash(int amount) {
            if(amount > 0)
            {
                _cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + " to nie jest ilość pieniędzy jaką mogę wziąć ", _name + " powiedział...");
                return 0;
            }
        }
    }
}
