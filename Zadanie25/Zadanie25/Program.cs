using System;

namespace Zadanie25
{
    class Program
    {

        public static void Main(String[] args)
        {
            Random random = new Random();

            int numverBetween0and3 = random.Next(4);
            int numberBetween1and13 = random.Next(1, 14);
            int anyRandomInteger = random.Next();

            List<Card> cards = new List<Card>();

            Console.WriteLine("Pięć losowych kart:");
            for (int i = 0; i < 5; i++)
            {
                Card tmp = new Card(random.Next(4), random.Next(1, 14));
                cards.Add(tmp);
                Console.WriteLine(tmp.Name);
            }

            cards.Sort(new CardComparer_byValue());

            Console.WriteLine("\nTe same karty posortowane:");
            foreach (Card tmp in cards) Console.WriteLine(tmp.Name);

            Card cardToCheck = new Card(Suits.Clubs, Values.Three);
            bool doesItMatch = Card.DoesCardMatch(cardToCheck, Suits.Hearts);
            Console.WriteLine("\n" + doesItMatch);
        }
    }
}