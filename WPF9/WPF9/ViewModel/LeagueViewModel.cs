using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF9.Model;

namespace WPF9.ViewModel
{
    internal class LeagueViewModel
    {
        public RosterViewModel JimmysTeam { get; private set; }
        public RosterViewModel BriansTeam { get; private set; }


        public LeagueViewModel()
        {
            var roster1 = new Roster("Wspaniali", (List<Player>) GetAmazingPlayers());
            JimmysTeam = new RosterViewModel(roster1);
            

            var roster2 = new Roster("Bombiarze", (List<Player>) GetBomberPlayers());
            BriansTeam = new RosterViewModel(roster2);
        }



        private IEnumerable<Player> GetBomberPlayers()
        {
            return new List<Player>(){
                new Player("Kuba", 42, true),
                new Player("Henryk", 11, true),
                new Player("Jakub", 4, true),
                new Player("Lidia", 18, true),
                new Player("Kim", 16, true),
                new Player("Bernadeta", 23, false),
                new Player("Edek", 21, false)
            };
        }


        private IEnumerable<Player> GetAmazingPlayers()
        {
            return new List<Player>(){
                new Player("Damian", 31, true),
                new Player("Leszek",23, true),
                new Player("Krystyna", 6, true),
                new Player("Maciek", 0, true),
                new Player("Jurek", 42, true),
                new Player("Heniek", 32, false),
                new Player("Franek", 8, false)
            };
        }
    }
}
