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
            TallGuy tallGuy = new TallGuy("Adam", 74);
            tallGuy.TalkAboutYourself();
            tallGuy.Honk();
        }
    }
}