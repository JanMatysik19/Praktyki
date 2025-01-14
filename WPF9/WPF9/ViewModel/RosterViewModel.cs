using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF9.Model;

namespace WPF9.ViewModel
{
    internal class RosterViewModel
    {
        public string TeamName { get; private set; }
        public ObservableCollection<PlayerViewModel> Starters { get; private set; }
        public ObservableCollection<PlayerViewModel> Bench { get; private set; }


        private Roster _roster { get; set; }


        public RosterViewModel(Roster roster)
        {
            _roster = roster;
            TeamName = roster.TeamName;
            Starters = new ObservableCollection<PlayerViewModel>();
            Bench = new ObservableCollection<PlayerViewModel>();



            UpdateRosters();
        }


        private void UpdateRosters()
        {
            Starters.Clear();
            Bench.Clear();

            foreach (Player player in _roster.Players)
                if (player.Starter) Starters.Add(new PlayerViewModel(player.Name, player.Number));
                else Bench.Add(new PlayerViewModel(player.Name, player.Number));


            List<PlayerViewModel> tmp = Starters.ToList();
            tmp.AddRange(Bench.ToList());

            var names = from player in tmp
                        select player.Name;

            Console.WriteLine(names.ToString());
        }
    }
}
