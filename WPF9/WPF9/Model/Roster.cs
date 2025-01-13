using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF9.Model
{
    internal class Roster
    {
        public string TeamName { get; private set; }


        private readonly List<Player> _players = new List<Player>();

        public IEnumerable<Player> Players
        {
            get { return new List<Player>(_players); }
        }

        public Roster(string teamName, List<Player> players)
        {
            TeamName = teamName;
            _players.AddRange(players);
        }
    }
}
