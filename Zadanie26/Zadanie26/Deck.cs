using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie26
{
    internal class Deck
    {
        private List<Card> cards;
        private Random random = new Random();

        public Deck()
        {
            cards = new List<Card>();
            for(int suit = 0; suit < 4; suit++) for(int value = 1; value <= 13; value++) cards.Add(new Card(suit, value));
        }

        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }

        public int Count
        {
            get
            {
                return cards.Count;
            }
        }

        public void Add(Card card)
        {
            cards.Add(card);
        }

        public Card Deal(int index)
        {
            Card CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal;
        }

        public void Shuffle() {
            for(int i = 0; i< cards.Count; i++)
            {
                Card card = cards[i];
                int a = cards.IndexOf(card);
                int b = random.Next(0, cards.Count);

                swap(cards, a, b);
            }
        }

        private void swap(List<Card> list, int a, int b)
        {
            Card tmp = cards[a];
            cards[a] = cards[b];
            cards[b] = tmp;
        }

        public IEnumerable<string> GetCardNames()
        {
            List<string> tmp = new List<string>();
            foreach(Card card in cards) tmp.Add(card.Name);
            return tmp;
        }

        public void Sort()
        {
            cards.Sort(new CardComparer_bySuit());
        }

        public Card Get(int index)
        {
            if(index >= 0 && index < cards.Count) return cards[index];
            else return null;
        }
    }
}
