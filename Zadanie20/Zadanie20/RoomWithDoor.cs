using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie20
{
    internal class RoomWithDoor : Room, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decortion, string doorDescription) : base(name, decortion)
        {
            DoorDescription = doorDescription;
        }

        public string DoorDescription { get; private set; }
        public Location DoorLocation { get; set; }
    }
}
