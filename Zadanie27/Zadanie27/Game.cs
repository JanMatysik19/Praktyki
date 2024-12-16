using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadanie26;

namespace Zadanie27
{
    internal class Game
    {
        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;
        private TextBox textBoxOnForm;

        public Game(string playerName, IEnumerable<string> opponentNames, TextBox textBoxOnForm)
        {
            Random random = new Random();
            this.textBoxOnForm = textBoxOnForm;
            players = new List<Player>();
            players.Add(new Player(playerName, random, textBoxOnForm));

            foreach (string player in opponentNames) players.Add(new Player(player, random, textBoxOnForm));
            books = new Dictionary<Values, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }

        private void Deal()
        {
            stock.Shuffle();

            foreach(Player player in players)
            {
                for(int i = 1; i <= 5; i++) player.TakeCard(stock.Deal());
                player.PullOutBooks();
            }
        }

        public bool PlayOneRound(int selectedPlayerCard)
        {
            Values cardToAskFor = players[0].Peek(selectedPlayerCard).Value;
            foreach(Player player in players)
            {
                if (players.IndexOf(player) == 0) player.AskForACard(players, 0, stock, cardToAskFor);
                else player.AskForACard(players, players.IndexOf(player), stock);

                if(PullOutBooks(player))
                {
                    textBoxOnForm.Text += player.Name + " ciągnie karty" + Environment.NewLine;
                    int card = 1;
                    while(card <= 5 && stock.Count > 0)
                    {
                        player.TakeCard(stock.Deal(card));
                        card++;
                    }
                }

                if (players[0].CardCount >= 2) players[0].SortHand();

                if(stock.Count == 0)
                {
                    textBoxOnForm.Text = "Na kupce nie ma żadnych kart. Gra skończona!" +Environment.NewLine;
                    return true;
                }
            }
            return false;
        }

        public bool PullOutBooks(Player player)
        {
            IEnumerable<Values> booksPulled = player.PullOutBooks();

            foreach (Values value in booksPulled) books.Add(value, player);

            if (player.CardCount == 0) return true;
            else return false;
        }

        public string DescribeBooks()
        {
            string whoHasWhichBooks = "";
            foreach(Values value in books.Keys) whoHasWhichBooks += books[value].Name + " ma grupę " + Card.Plural(value, 0) + Environment.NewLine;
            
            return whoHasWhichBooks;
        }

        public string GetWinnerName()
        {
            Dictionary<string, int> winners = new Dictionary<string, int>();
            foreach(Values value in books.Keys)
            {
                string name = books[value].Name;
                if (winners.ContainsKey(name)) winners[name]++;
                else winners.Add(name, 1);
            }

            int mostBooks = 0;
            foreach(string name in winners.Keys) if (winners[name] > mostBooks) mostBooks = winners[name];

            bool tie = false;
            string winnerList = "";
            foreach(string name in winners.Keys )
            {
                if (winners[name] > mostBooks)
                    if(!String.IsNullOrEmpty(winnerList))
                    {
                        winnerList += " i ";
                        tie = true;
                    }
                winnerList += name;
            }

            winnerList += ": " + mostBooks + " grupy ";
            if (tie) return "Remis pomiędzy " + winnerList;
            else return winnerList;
        }

        public IEnumerable<string> GetPlayerCardNames()
        {
            return players[0].GetCardNames();
        }

        public string DescribePlayerHands()
        {
            string description = "";
            for (int i = 0; i < players.Count; i++)
            {
                description += players[i].Name + " ma " + players[i].CardCount;
                if (players[i].CardCount == 1) description += " kartę.\r\n";
                else if (players[i].CardCount == 2 || players[i].CardCount == 3 || players[i].CardCount == 4) description += " kart.\r\n";
                else description += " kart.\r\n";
            }
            description += "Na kupce zostało kart: " + stock.Count + "\r\n";
            return description;
        }
    }
}
