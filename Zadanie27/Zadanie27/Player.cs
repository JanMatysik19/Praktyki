using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadanie26;

namespace Zadanie27
{
    internal class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;

        public Player(String name, Random random, TextBox textBoxOnForm)
        {
            this.name = name;
            this.random = random;
            this.textBoxOnForm = textBoxOnForm;

            this.textBoxOnForm.Text += name + " dołączył do gry\r\n";

            cards = new Deck(new List<Card>{ });
        }

        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books = new List<Values>();

            for(int i = 1; i <= 13; i++)
            {
                Values value = (Values)i;
                int howMany = 0;
                for(int card = 0; card < cards.Count; card++) if(cards.Peek(card) != null) if (cards.Peek(card).Value == value)
                {
                    howMany++;
                }
                if (howMany == 4)
                {
                    books.Add(value);
                    for(int card = cards.Count - 1; card >= 0; card--) cards.Deal(card);
                }
            }

            return books;
        }

        public Values GetRandomValue()
        {
            Random random = new Random();
            return cards.Peek(random.Next(0, cards.Count)).Value;
        }

        public Deck DoYouHaveAny(Values value)
        {
            if (cards.Count >= 1)
            {
                int count = 0;

                for (int i = 0; i < cards.Count; i++) if(cards.Peek(i) != null) if (cards.Peek(i).Value == value) count++;

                textBoxOnForm.Text += Name + " ma " + count + " " + Card.Plural(value, count) + Environment.NewLine;

                return cards.PullOutValues(value);
            }
            else return null;
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            if(cards.Count >= 1) AskForACard(players, myIndex, stock, GetRandomValue());
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            textBoxOnForm.Text += Name + " pyta, czy ktoś ma " + Card.Plural(value, 1) + "." + Environment.NewLine;


            int n = 0;
            foreach(Player player in players)
            {
                if(player != this)
                {
                    Deck tmp = player.DoYouHaveAny(value);
                    n += tmp.Count;

                    for (int i = 1; i <= tmp.Count; i++) cards.Add(tmp.Deal());
                }
            }
            if(n == 0)
            {
                cards.Add(stock.Deal());
                textBoxOnForm.Text += Name + " pobrał kartę z kupki" + Environment.NewLine;
            }
        }


        public int CardCount { get { return cards.Count; } }
        
        public void TakeCard(Card card)
        {
            cards.Add(card);
        }

        public IEnumerable<string> GetCardNames()
        {
            return cards.GetCardNames();
        }

        public Card Peek(int cardNumber)
        {
            return cards.Peek(cardNumber);
        }

        public void SortHand()
        {
            if(cards.Count >= 2) cards.SortByValue();
        }
    }
}
