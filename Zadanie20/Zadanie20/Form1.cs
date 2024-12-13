using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie20
{
    public partial class Form1 : Form
    {
        RoomWithDoor livingRoom;
        Room dinningRoom;
        RoomWithDoor kitchen;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        Outside garden;

        Location currentLocation;
        public Form1()
        {
            InitializeComponent();

            CreateObjects();
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Salon", "antyczny dywan", "dębowe drzwi z mosiężną klamką");
            dinningRoom = new Room("Jadalnia", "kryształowy żyrandol");
            kitchen = new RoomWithDoor("Kuchnia", "nierdzewne, stalowe sztućce", "rozsuwane drzwi");

            frontYard = new OutsideWithDoor("Podwórko przed domem", false, "dębowe drzwi z mosiężną klamką");
            backYard = new OutsideWithDoor("Podwórko za domem", true, "rozsuwane drzwi");
            garden = new Outside("Ogród", false);

            livingRoom.Exits = new Location[] { dinningRoom, frontYard };
            dinningRoom.Exits = new Location[] { kitchen, livingRoom };
            kitchen.Exits = new Location[] { dinningRoom, backYard };

            frontYard.Exits = new Location[] { livingRoom, garden };
            garden.Exits = new Location[] { frontYard, backYard };
            backYard.Exits = new Location[] { garden, kitchen };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;

            MoveToANewLocation(garden);
        }

        private void MoveToANewLocation(Location location)
        {
            currentLocation = location;
            exits.Items.Clear();
            foreach (Location exit in currentLocation.Exits)
            {
                exits.Items.Add(exit.Name);
            }
            exits.SelectedIndex = 0;

            if(currentLocation is IHasExteriorDoor) goThroughTheDoor.Visible = true;
            else goThroughTheDoor.Visible = false;

            description.Text = currentLocation.Descritpion;
        }

        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor tmp = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(tmp.DoorLocation);
        }
    }
}
