using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie4
{
    public partial class Form1 : Form
    {

        Guy joe;
        Guy bob;
        int bank = 100;

        public Form1()
        {
            InitializeComponent();

            joe = new Guy("Joe");
            bob = new Guy("Bob", 20);

            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(bank >= 10)
            {
                bank -= joe.ReciveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bank nie posiada takiej ilości peniędzy");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(bob.Cash >= 5)
            {
                bank += bob.GiveCash(5);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bob nie posiada takiej ilości pieniędzy");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(joe.Cash >= 10)
            {
                bob.ReciveCash(joe.GiveCash(10));
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Joe nie posiada takiej ilości pieniędzy");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(bob.Cash >= 5)
            {
                joe.ReciveCash(bob.GiveCash(5));
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bob nie posiada takiej ilości pieniędzy");
            }
        }

        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " ma " + joe.Cash + " zł";
            bobsCashLabel.Text = bob.Name + " ma " + bob.Cash + " zł";
            bankCashLabel.Text = "Bank ma " + bank + " zł";
        }
    }
}
