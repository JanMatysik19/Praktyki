using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie28
{
    public partial class Form1 : Form
    {
        Queue<Lumberjack> queue;

        public Form1()
        {
            InitializeComponent();

            queue = new Queue<Lumberjack>();
            RedrawList();
        }

        private void RedrawList()
        {
            line.Items.Clear();

            foreach (Lumberjack l in queue) line.Items.Add(l.Name);

            if (queue.Count <= 0)
            {
                nextLumberjack.Enabled = false;
                addFlapjacks.Enabled = false;
            }
            else
            {
                nextLumberjack.Enabled = true;
                addFlapjacks.Enabled = true;
            }
        }

        private void addLumberjack_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(name.Text))
            {
                MessageBox.Show("Podaj imię drawala, jeżeli chcesz jakiegoś dodać");
                return;
            }
            else
            {
                queue.Enqueue(new Lumberjack(name.Text));
                name.Text = "";

                RedrawList();
            }
        }

        private void addFlapjacks_Click(object sender, EventArgs e)
        {
            Flapjack food;
            if (crispy.Checked) food = Flapjack.Chrupkiego;
            else if (soggy.Checked) food = Flapjack.Wilgotnego;
            else if (browned.Checked) food = Flapjack.Rumianego;
            else food = Flapjack.Bananowego;

            Lumberjack currLumberjack = queue.Peek();

            currLumberjack.TakeFlapjacks(food, (int)howMany.Value);

            RedrawList();

            lumberjackOrder.Text = currLumberjack.Name + " ma " + currLumberjack.FlapjackCount + " naleśników";
        }

        private void nextLumberjack_Click(object sender, EventArgs e)
        {
            queue.Dequeue();

            lumberjackOrder.Text = "";
            
            RedrawList();
        }
    }
}
