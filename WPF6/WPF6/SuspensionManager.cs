using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WPF6
{
    public class SuspensionManager
    {
        public static string CurrentQuery { get; set; }

        private const string filename = "_sessionState.txt";


        static async public Task SaveAsync()
        {
            Console.WriteLine("Zapisywanie!!!");
            if (String.IsNullOrEmpty(CurrentQuery)) CurrentQuery = String.Empty;
            Console.WriteLine(CurrentQuery);

            using (StreamWriter writer = new StreamWriter(filename))
            {
                 writer.WriteLineAsync(CurrentQuery);
            }
        }

        static async public Task RestoreAsync()
        {
            Console.WriteLine("Przywracanie!!!");
            if (String.IsNullOrEmpty(CurrentQuery)) CurrentQuery = String.Empty;

            using (StreamReader reader = new StreamReader(filename))
            {
                CurrentQuery = reader.ReadLine();
                Console.WriteLine(CurrentQuery);
            }
        }
    }
}
