using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie26
{
    public partial class Form1 : Form
    {
        Deck deck1;
        Deck deck2;

        public Form1()
        {
            InitializeComponent();
            
            deck1 = new Deck();
            ResetDeck(1);
            RedrawDeck(1);

            deck2 = new Deck();
            ResetDeck(1);
            RedrawDeck(2);
        }

        private void ResetDeck(int deck)
        {
            Random random = new Random();
            List<Card> cards = new List<Card>();

            if (deck == 1)
            {
                for (int i = 1; i <= 10; i++) cards.Add(new Card(random.Next(0, 4), random.Next(1, 14)));

                deck1 = new Deck(cards);
                deck1.Sort();
                RedrawDeck(1);
            }
            else if (deck == 2)
            {
                for (int suit = 0; suit < 4; suit++) for (int value = 1; value <= 13; value++) cards.Add(new Card(suit, value));

                deck2 = new Deck(cards);
                deck2.Sort();
                RedrawDeck(2);
            }
            else MessageBox.Show("Nieznany zestaw!");
        }

        private void RedrawDeck(int deck)
        {
            if (deck == 1)
            {
                listBox1.Items.Clear();
                foreach (string name in deck1.GetCardNames()) listBox1.Items.Add(name);

                label1.Text = "Zestaw 1. (" + deck1.Count + " kart)";
            }
            else if (deck == 2)
            {
                listBox2.Items.Clear();
                foreach (string name in deck2.GetCardNames()) listBox2.Items.Add(name);
                label2.Text = "Zestaw 2. (" + deck2.Count + " kart)";
            }
            else MessageBox.Show("Nieznany zestaw!");
        }

        private void reset1_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void reset2_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void shuffle1_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void shuffle2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }

        private void moveToDeck1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != null)
            {
                int index = listBox2.SelectedIndex;

                string name = (string)listBox2.Items[index];

                listBox1.Items.Add(deck2.Get(index).Name);
                listBox2.Items.Remove(index);

                deck1.Add(deck2.Get(index));
                deck2.Deal(index);

                RedrawDeck(1);
                RedrawDeck(2);
            }
        }

        private void moveToDeck2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != null)
            {
                int index = listBox1.SelectedIndex;

                string name = (string)listBox1.Items[index];

                listBox2.Items.Add(deck1.Get(index).Name);
                listBox1.Items.Remove(index);

                deck2.Add(deck1.Get(index));
                deck1.Deal(index);

                RedrawDeck(1);
                RedrawDeck(2);
            }
        }
    }
}
