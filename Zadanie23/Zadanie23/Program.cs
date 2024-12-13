using System;

namespace Zadanie23
{
    class Duck : IComparable<Duck>
    {
        public int Size;
        public TypeOfDuck Kind;

        public Duck(int Size, TypeOfDuck Kind)
        {
            this.Size = Size;
            this.Kind = Kind;
        }

        public Duck(int Size, int Kind)
        {
            this.Size = Size;
            this.Kind = (TypeOfDuck)Kind;
        }

        public string GetString()
        {
            return "A " + Kind.ToString() + " duck that is " + Size + " cm long.";
        }

        public int CompareTo(Duck duckToCompare)
        {
            if (Size > duckToCompare.Size) return 1;
            else if (Size < duckToCompare.Size) return -1;
            else return 0;
        }

        public static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck(17, TypeOfDuck.Mallard),
                new Duck(18, TypeOfDuck.Muscovy),
                new Duck(14, TypeOfDuck.Decoy),
                new Duck(11, TypeOfDuck.Muscovy),
                new Duck(14, TypeOfDuck.Mallard),
                new Duck(13, TypeOfDuck.Decoy)
            };

            ducks.Sort();

            foreach(Duck duck in ducks) Console.WriteLine(duck.GetString());
        }
    }

    public enum TypeOfDuck
    {
        Mallard,
        Muscovy,
        Decoy
    }
}