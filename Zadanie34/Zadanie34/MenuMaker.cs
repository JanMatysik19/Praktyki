using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Zadanie34
{
    internal class MenuMaker
    {
        private Random random = new Random();
        private List<String> meats = new List<String>() { "Pieczona wołowina", "Salami", "Indyk", "Szynka", "Karkówka" };
        private List<String> condiments = new List<String>() { "żółta musztarda", "brązowa musztarda", "musztarda miodowa", "majonez", "przyprawa", "sos francuski" };
        private List<String> breads = new List<String>() { "chleb ryżowy", "chleb biały", "chleb zbożowy", "pumpernikiel", "chleb włoski", "bułka" };

        public ObservableCollection<MenuItem> Menu { get; private set; }
        public DateTime GeneratedDate { get; private set; }
        public int NumberOfItems { get; set; }

        public MenuMaker()
        {
            Menu = new ObservableCollection<MenuItem>();
            NumberOfItems = 10;
            UpdateMenu();
        }

        private MenuItem CreateMenuItem()
        {
            string randomMeat = meats[random.Next(meats.Count)];
            string randomCondiments = condiments[random.Next(condiments.Count)];
            string randomBread = breads[random.Next(breads.Count)];
            return new MenuItem(randomMeat, randomCondiments, randomBread);
        }

        public void UpdateMenu()
        {
            Menu.Clear();
            for(int i = 0; i < NumberOfItems; i++)
            {
                Menu.Add(CreateMenuItem());
            }
            GeneratedDate = DateTime.Now;
        }
    }
}