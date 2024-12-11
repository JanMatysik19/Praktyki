using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie6
{
    public partial class Form1 : Form
    {
        Elephant lloyd;
        Elephant lucinda;
        
        public Form1()
        {
            InitializeComponent();
            lloyd = new Elephant("Lloyd", 33);
            lucinda = new Elephant("Lucinda", 40);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant tmp = lloyd;
            lloyd = lucinda;
            lucinda = tmp;

            //Update();

            MessageBox.Show("Obiekty zamienione");
        }

        private void Update()
        {
            button1.Text = lloyd.Name; 
            button2.Text = lucinda.Name;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lloyd = lucinda;
            lloyd.EarSize = 4321;
            lloyd.WhoAmI();
        }
    }
}
