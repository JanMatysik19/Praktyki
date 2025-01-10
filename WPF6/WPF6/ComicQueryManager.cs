using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WPF6
{
    internal class ComicQueryManager
    {
        public ObservableCollection<ComicQuery> AvailableQueries { get; private set; }
        public ObservableCollection<object> CurrentQueryResults { get; private set; }
        public string Title { get; set; }


        public static ComicQuery currQuery;


        public ComicQueryManager() {
            UpdateAvailableQueries();
            CurrentQueryResults = new ObservableCollection<object>();
        }


        private void UpdateAvailableQueries()
        {
            AvailableQueries = new ObservableCollection<ComicQuery>()
            {
                new ComicQuery("LINQ ułatwia zapytania", "Proste zapytanie",
                "Pokażmy Jankowi jak elastyczna jest technologia LINQ", "/Assets/purple_250x250.jpg"),
                
                new ComicQuery("Drogie komiksy", "Komiksy powyżej 500 zł.", "Komiksy o wartości przekraczającej 500 zł"
                + " Janek, może użyć tych danych do wybrania najbardziej"
                + " pożądanych komiksów", "/Assets/capitan_amazing_250x250.jpg"),
                new ComicQuery("Grupuj komiksy według zakresu cen", "Pogrupuj komiksy Janka według cen",
                "Janek kupuje dużo tanich komiksów, trochę średniej wartości i pojedyncze sztuki drogich, jednak przed zakupem chciałby wiedzieć, jakie ma możliwości.",
                "/Assets/capitan_amazing_250x250.jpg"),
                new ComicQuery("Połącz zakupy z cenami", "Przekonajmy się, czy Janek ostro się targuje",
                "To zapytanie tworzy listę obiektów Purchase zawierających zakupy Janka i porównuje je z cenami z Listy Grzegorza",
                "/Assets/capitan_amazing_250x250.jpg"),
                new ComicQuery("LINQ jest wszechstronne 1", "Modyfikuje wszystkie zwracane dane",
                "Ten kod doda łańcuch znaków na końcu każdego tekstu przechowywanego w tablicy.",
                "/Assets/bluegray_250x250.jpg"),
                new ComicQuery("LINQ jest wszechstronne 2", "Wykonuje obliczenia na kolekcjach",
                "LINQ udostępnia metody rozszerzające dla kolekcji (oraz wszystkich inych typów implementujących" +
                " interfejs IEnumerable<T>)", "/Assets/purple_250x250.jpg"),
                new ComicQuery("LINQ jest wszechstronne 3", "Zapisuje całe wyniki lub ich część w nowej sekwencji",
                "Czasami będziesz chciał zachować wyniki zapytania, by ich użyć w przyszłości",
                "/Assets/bluegray_250x250.jpg")
            };
        }


        //private static BitmapImage CreateImageFromAssets(string imageFileName)
        //{
        //    return new BitmapImage(new Uri("Assets/" + imageFileName, UriKind.Relative));
        //}

        public void UpdateQueryResults(ComicQuery query)
        {
            Title = query.Title;
            switch (query.Title)
            {
                case "LINQ ułatwia zapytania": LinqMakesQueriesEasy(); break;
                case "Drogie komiksy": ExpensiveComics(); break;
                case "Grupuj komiksy według zakresu cen": GroupComicsByPriceRange(); break;
                case "Połącz zakupy z cenami": JoinPurchasesWithPrices(); break;
                case "LINQ jest wszechstronne 1": LinqIsVersatile1(); break;
                case "LINQ jest wszechstronne 2": LinqIsVersatile2(); break;
                case "LINQ jest wszechstronne 3": LinqIsVersatile3(); break;
            }
        }



        public static IEnumerable<Comic> BuildCatalog()
        {
            return new List<Comic>()
            {
                new Comic{ Name = "Johnny America vs. the Pinko", issue = 6 },
                new Comic{ Name = "Rock and ROll (edycja limitowana)", issue = 19 },
                new Comic{ Name = "Woman's Work", issue = 36 },
                new Comic{ Name = "Hippie Madness (Źle wydrukowany)", issue = 57 },
                new Comic{ Name = "Revange of the New Wave Freak (uszkodzony)", issue = 68 },
                new Comic{ Name = "Black Monday", issue = 74 },
                new Comic{ Name = "Tribal Tatto Madness", issue = 83 },
                new Comic{ Name = "The Death of an Object", issue = 97 }
            };
        }

        public static IEnumerable<Purchase> FindPurchases()
        {
            return new List<Purchase>()
            {
                new Purchase{ Price = 225M, Issue = 68 },
                new Purchase{ Price = 375M, Issue = 19 },
                new Purchase{ Price = 3600M, Issue = 6 },
                new Purchase{ Price = 13215M, Issue = 57 },
                new Purchase{ Price = 660M, Issue = 36 }
            };
        }


        private static Dictionary<int, decimal> GetPrices()
        {
            return new Dictionary<int, decimal>
            {
                { 6, 3600M }, { 19, 500M }, { 36, 650M }, { 57, 13525M }, 
                { 68, 250M }, { 74, 75M }, { 83, 25.75M }, { 97, 35.25M }
            };
        }
        public enum PriceRange { Cheap, Midrange, Expensive }
        public static PriceRange EvaluatePrice(decimal price)
        {
            if (price < 100M) return PriceRange.Cheap;
            else if (price <= 1000M) return PriceRange.Midrange;
            else return PriceRange.Expensive;
        }


        private void LinqMakesQueriesEasy()
        {
            int[] values = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };
            var result = from v in values
                         where v < 27
                         select v;

            foreach(int i in result)
            {
                CurrentQueryResults.Add(new
                {
                    Title = i.ToString(),
                    Image = "/Assets/purple_250x250.jpg"
                });
            }
        }

        private void ExpensiveComics()
        {
            IEnumerable<Comic> comics = BuildCatalog();
            Dictionary<int, decimal> values = GetPrices();
            IEnumerable<Purchase> purchases = FindPurchases();

            var mostExpensive = from comic in comics
                                where values[comic.issue] > 500
                                orderby values[comic.issue] descending
                                select comic;


            foreach(Comic comic in mostExpensive)
            {
                CurrentQueryResults.Add(new
                {
                    Title = String.Format("{0} jest warty {1:c}", comic.Name, values[comic.issue]),
                    Image = "/Assets/capitan_amazing_250x250.jpg"
                });
            }
        }

        private void GroupComicsByPriceRange()
        {
            Dictionary<int, decimal> values = GetPrices();

            var priceGroups = from pair in values
                              group pair.Key by EvaluatePrice(pair.Value)
                              into priceGroup
                              orderby priceGroup.Key descending
                              select priceGroup;



            int numberOfComics = 0;
            foreach (var group in priceGroups) numberOfComics += group.Count();

            CurrentQueryResults.Add(new
            {
                Title = "Ilość komiksów",
                Subtitle = "Ilość komiksów, które kupił Janek oraz znajdują się też w sklepie Grzegorza",
                Description = numberOfComics.ToString(),
                Image = "/Assets/purple_250x250.jpg"
            });



            foreach (var group in priceGroups)
            {
                string stringKey;
                string stringKeyComment = "Komiksy ";
                switch (group.Key)
                {
                    case PriceRange.Cheap:
                        stringKey = "tanie";
                        stringKeyComment = "poniżej 100 zł";
                        break;
                    case PriceRange.Midrange:
                        stringKey = "średnie";
                        stringKeyComment = "poniżej 1000 zł ale powyżej 100zł";
                        break;
                    default:
                        stringKey = "drogie";
                        stringKeyComment = "powyżej 1000 zł";
                        break;
                }

                string content = "";
                foreach (var issue in group) content += issue.ToString() + " ";

                CurrentQueryResults.Add(new
                {
                    Title = stringKey,
                    Subtitle = stringKeyComment,
                    Description = content,
                    Image = "/Assets/bluegray_250x250.jpg"
                });
            }
        }

        private void JoinPurchasesWithPrices()
        {
            IEnumerable<Comic> comics = BuildCatalog();
            IEnumerable<Purchase> purchases = FindPurchases();
            Dictionary<int, decimal> values = GetPrices();

            var results = from comic in comics
                          join purchase in purchases
                          on comic.issue equals purchase.Issue
                          orderby comic.issue ascending
                          select new { comic.Name, comic.issue, purchase.Price };


            decimal gregsListValue = 0;
            decimal totalSpent = 0;
            foreach (var result in results)
            {
                string choice;
                if (result.Price <= values[result.issue]) choice = "Ten zakup był rozsądny";
                else choice = "Ten zakup był nierozsądny";

                CurrentQueryResults.Add(new
                {
                    Title = "Numer " + result.issue,
                    Subtitle = choice,
                    Description = String.Format("Number {0}: ({1}) kupiony za {2:c}.", result.issue, result.Name, result.Price),
                    Image = "/Assets/capitan_amazing_250x250.jpg"
                });
                gregsListValue += values[result.issue];
                totalSpent += result.Price;
            }

            string endComment;
            if (totalSpent > gregsListValue) endComment = String.Format("Przez co niepotrzebnie wydał {0} zł.", totalSpent - gregsListValue);
            else if (totalSpent < gregsListValue) endComment = String.Format("Dzięki czemu zaoszczędził {0} zł.", gregsListValue - totalSpent);
            else endComment = String.Format("Dzięki czmu nic nie stracił.");

            CurrentQueryResults.Add(new
            {
                Title = "Podsumowanie",
                Subtitle = "Podsumowanie cen zakupu komiksów przez Janka z tymi w sklepie Grzegorza",
                Description = String.Format("Janek wydał {0:c} na komiksy warte {1:c}. {2}", totalSpent, gregsListValue, endComment),
                Image = "/Assets/purple_250x250.jpg"
            });
        }

        private void LinqIsVersatile1()
        {
            Random random = new Random();
            List<int> listOfNumbers = new List<int>();
            int length = random.Next(50, 150);

            for (int i = 0; i < length; i++) listOfNumbers.Add(random.Next(100));

            string[] sandwiches = { "szynka z serem", "salami z majonezem",
                "indyk z musztardą", "kotlet z kurczaka" };

            var sandwichesOnRye = from sandwich in sandwiches
                                  select sandwich + " na chlebie zbożowym";

            foreach(var sandwich in sandwichesOnRye)
                CurrentQueryResults.Add(new
                {
                    Title = String.Format(sandwich),
                    Image = "/Assets/capitan_amazing_250x250.jpg"
                });
        }

        private void LinqIsVersatile2()
        {
            Random random = new Random();
            List<int> listOfNumbers = new List<int>();
            int length = random.Next(50, 150);

            for (int i = 0; i < length; i++) listOfNumbers.Add(random.Next(100));

            CurrentQueryResults.Add(new
            {
                Title = String.Format("Na liście znajduje się {0} liczb", listOfNumbers.Count())
            });

            CurrentQueryResults.Add(new
            {
                Title = String.Format("Najmniejsza z nich to {0}", listOfNumbers.Min())
            });

            CurrentQueryResults.Add(new
            {
                Title = String.Format("Największa z nich to {0}", listOfNumbers.Max())
            });

            CurrentQueryResults.Add(new
            {
                Title = String.Format("Suma wynosi {0}", listOfNumbers.Sum())
            });

            CurrentQueryResults.Add(new
            {
                Title = String.Format("Suma wynosi {0:F2}", listOfNumbers.Average())
            });
        }

        private void LinqIsVersatile3()
        {
            List<int> listOfNumbers = new List<int>();
            for (int i = 0; i < 1000; i++) listOfNumbers.Add(i);

            var under50sotted = from number in listOfNumbers
                                where number < 50
                                orderby number descending
                                select number;

            var firstFive = under50sotted.Take(6);
            List<int> shortList = firstFive.ToList();

            foreach (int n in shortList)
                CurrentQueryResults.Add(new
                {
                    Title = n.ToString(),
                    Image = "/Assets/bluegray_250x250.jpg"
                });
        }
    }
}
