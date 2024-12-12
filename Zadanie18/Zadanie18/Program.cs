namespace Zadanie18
{
    public class TallGuy : IClown
    {
        public string Name;
        public int Height;
        public void TalkAboutYourself()
        {
            Console.WriteLine("Nazywam się " + Name + " i mam " + Height + " centymetrów wzrostu.");
        }

        public string FunnyThingIHave { get { return "Duże buty"; } }

        public void Honk()
        {
            Console.WriteLine("Tut tuut!");
        }

        public TallGuy(string Name, int Height)
        {
            this.Name = Name;
            this.Height = Height;
        }

        static void Main(string[] args)
        {
            ScaryScary fingersTheClown = new ScaryScary("duże buty", 35);
            FunnyFunny someFunnyClown = fingersTheClown;
            IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
            someOtherScaryClown.Honk();
            
        }
    }
}