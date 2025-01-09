using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF4
{
    [Serializable]
    internal class Clone : IDisposable
    {
        public int Id { get; private set; }

        public Clone(int Id)
        {
            this.Id = Id;
        }

        public void Dispose()
        {
            //MessageBox.Show("Zostałem usunięty!", "Klon " + Id + " mówi...", MessageBoxButton.OK, MessageBoxImage.Information);

            string filename = @"C:\Temp\Klon.dat";
            string dirname = @"C:\Temp";
            if(File.Exists(filename) == false)
            {
                Directory.CreateDirectory(dirname);
            }

            BinaryFormatter bf = new BinaryFormatter();
            using(Stream output = File.OpenWrite(filename))
            {
                bf.Serialize(output, this);
            }

            MessageBox.Show("Tu " + this.Id + ", muszę... zserializować... obiekt.");
        }

        ~Clone()
        {
            MessageBox.Show("Aaaaaaaa!", "Klon " + Id + " mówi...", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
