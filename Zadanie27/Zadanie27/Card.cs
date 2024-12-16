using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie26
{
    internal class Card
    {
        public Suits Suit;
        public Values Value;


        private static string[] suits = new string[]
        {
            "pik", "trefl", "karo", "kier"
        };

        private static string[] names = new string[]
        {
            "", "As", "Dwójka", "Trójka", "Czwórka", "Piątka", "Szóstka", "Siódemka", "Ósemka", "Dziewiątka", "Dziesiątka", "Walet", "Dama", "Król"
        };
        public string Name {
            get
            {
                return names[(int)Value] + " " + suits[(int)Suit];
            }
        }

        public Card(Suits suit, Values value)
        {
            Suit = suit;
            Value = value;
        }
        public Card(int suit, int value)
        {
            Suit = (Suits)suit;
            Value = (Values)value;
        }

        public static bool DoesCardMatch(Card CardToCheck, Suits Suit)
        {
            if(CardToCheck.Suit == Suit) return true;
            else return false;
        }

        public static bool DoesCardMatch(Card CardToCheck, Values Value)
        {
            if(CardToCheck.Value == Value) return true;
            else return false;
        }

        private static string[] names0 = new string[]
        {
            "", "asów", "dwójek", "trójek", "czwórek", "piątek", "szóstek", "siódemek", "ósemek", "dziewiątek", "dziesątek", "waletów", "dam", "króli"
        };

        private static string[] names1 = new string[]
        {
            "", "asa", "dwójkę", "trókę", "czwórkę", "piątkę", "szóstkę", "siódemkę", "ósemkę", "dziewiątkę", "dziesiątkę", "waleta", "damę", "króla" 
        };

        private static string[] names2AndMore = new string[]
        {
            "", "asy", "dwójki", "trójki", "czwórki", "piątki", "szóstki", "siódemki", "ósemki", "dziewiątki", "dziesiątki", "walety", "damy", "króle"
        };

        public static string Plural(Values value, int count)
        {
            if (count == 0) return names0[(int)value];
            else if (count == 1) return names1[(int)value];
            else return names2AndMore[(int)value];
        }
    }
}
