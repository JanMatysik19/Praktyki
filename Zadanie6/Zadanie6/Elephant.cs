using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie6
{
    class Elephant
    {
        string _name;
        int _earSize;
    
        public Elephant(string Name, int EarSize) {
            this._name = Name;
            this._earSize = EarSize;
        }

        public void WhoAmI()
        {
            MessageBox.Show("Moje uszy mają " + _earSize + " centymetrów szerokości.", _name + " mówi...");
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int EarSize
        {
            get { return _earSize; }
            set { _earSize = value; }
        }
    }
}
