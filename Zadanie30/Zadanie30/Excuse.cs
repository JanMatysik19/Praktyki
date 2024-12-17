using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie30
{
    internal class Excuse
    {
        public string Description {  get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }

        private Random Random { get; set; }


        public Excuse(string description, string results, DateTime lastUsed, string excusePath)
        {
            Description = description;
            Results = results;
            LastUsed = lastUsed;
            ExcusePath = excusePath;
        }

        public Excuse()
        {
            
        }

        public Excuse(Random random)
        {
            Random = random;
        }

        public void OpenFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length != 3)
            {
                MessageBox.Show("Plik tej wymówki jest uszkodzony!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Description = lines[0];
            Results = lines[1];
            LastUsed = Convert.ToDateTime(lines[2]);
        }

        public void OpenFile(string[] files)
        {
            if(files.Length <= 0) return;

            int i = 0;
            again:
            string filePath = files[Random.Next(0, files.Length)];

            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length != 3)
            {
                i++;
                if(i <= 3) goto again;
                else MessageBox.Show("Nie udało się otworzyć żadnego z plików wymówek", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Description = lines[0];
            Results = lines[1];
            LastUsed = Convert.ToDateTime(lines[2]);
        }

        public void Save(string filePath)
        {
            string content = Description + Environment.NewLine + Results + Environment.NewLine + LastUsed.ToString();
            File.WriteAllText(filePath, content);
        }

        public void Save(string filePath, string description, string results, DateTime lastUsed)
        {
            string content = description + Environment.NewLine + results + Environment.NewLine + lastUsed.ToString();
            File.WriteAllText(filePath, content);
        }
    }
}
