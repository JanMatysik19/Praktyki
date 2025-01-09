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
                + " pożądanych komiksów", "/Assets/capitan_amazing_250x250.jpg")
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
                new Comic{ Name = "Revange of the New Wave Freak (uszkodzony)", issue = 60 },
                new Comic{ Name = "Black Monday", issue = 74 },
                new Comic{ Name = "Tribal Tatto Madness", issue = 83 },
                new Comic{ Name = "The Death of an Object", issue = 97 }
            };
        }


        private static Dictionary<int, decimal> GetPrices()
        {
            return new Dictionary<int, decimal>
            {
                { 6, 3600M }, { 19, 500M }, { 19, 500M }, { 36, 650M }, { 57, 13525M }, { 68, 250M }, { 74, 75M }, { 83, 25.75M }, { 97, 35.25M }
            };
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
    }
}
