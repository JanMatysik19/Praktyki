using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie22
{
    public partial class Form1 : Form
    {
        Random random;

        public Form1()
        {
            InitializeComponent();

            random = new Random();
            

            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numverBetween0and3 = random.Next(4);
            int numberBetween1and13 = random.Next(1, 14);
            int anyRandomInteger = random.Next();

            Card card = new Card(numverBetween0and3, numberBetween1and13);
            MessageBox.Show(card.Name);
        }
    }
}
