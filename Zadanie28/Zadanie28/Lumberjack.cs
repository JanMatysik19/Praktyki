using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie28
{
    class Lumberjack
    {
        private string name;
        public string Name { get { return name; } }
        private Stack<Flapjack> meal;

        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }

        public int FlapjackCount { get { return meal.Count; } }
        public void TakeFlapjacks(Flapjack food, int HowMany)
        {
            if(HowMany > 0) for(int i = 0; i < HowMany; i++) meal.Push(food);
        }

        public void EatFlapjacks()
        {
            Console.Write(name + " je naleśniki");
            for(int i = 1; i <= meal.Count; i++) Console.Write(name + " zdjadł " + meal.Pop().ToString() + " naleśnika");
        }
    }

    public enum Flapjack
    {
        Chrupkiego,
        Wilgotnego,
        Rumianego,
        Bananowego
    }
}
