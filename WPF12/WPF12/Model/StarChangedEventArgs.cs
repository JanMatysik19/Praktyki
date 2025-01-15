using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF12.View;

namespace WPF12.Model
{
    internal class StarChangedEventArgs : EventArgs
    {
        public Star StarThatChanged { get; set; }

        public bool Removed { get; private set; }
        
        public StarChangedEventArgs(Star starThatChanged, bool removed)
        {
            StarThatChanged = starThatChanged;
            Removed = removed;
        }
    }
}
