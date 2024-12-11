using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie10Lab
{
    public partial class Form1 : Form
    {
        Guy janek, bartek, arek;
        Guy[] guys = new Guy[3];

        Guy curr;

        Greyhound[] greyhounds = new Greyhound[4];

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            guys[0] = new Guy("Janek", radioButton1, label5, 50);
            guys[1] = new Guy("Bartek", radioButton2, label6, 75);
            guys[2] = new Guy("Arek", radioButton3, label7, 45);

            curr = guys[0];

            greyhounds[0] = new Greyhound(random, pictureBox2, 0, pictureBox1);
            greyhounds[1] = new Greyhound(random, pictureBox3, 0, pictureBox1);
            greyhounds[2] = new Greyhound(random, pictureBox4, 0, pictureBox1);
            greyhounds[3] = new Greyhound(random, pictureBox5, 0, pictureBox1);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if(!curr.PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value))
            {
                MessageBox.Show(curr.Name + " nie posiada wystarczającej ilości pieniędzy by obstawić ten zakład");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < greyhounds.Length; i++)
            {
                if(greyhounds[i].Run())
                {
                    timer1.Stop();
                    timer1.Enabled = false;

                    MessageBox.Show("Chart numer " + (i + 1) + " wygrał wyścig!");

                    for (int j = 0; j < guys.Length; j++)
                    {
                        guys[j].Collect(i + 1);
                    }

                    for (int j = 0; j < greyhounds.Length; j++)
                    {
                        greyhounds[j].TakeStartingPosition();
                    }

                    button1.Enabled = true;

                    break;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            curr = guys[0];
            curr.UpdateLabels();
            label2.Text = curr.Name;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            curr = guys[1];
            curr.UpdateLabels();
            label2.Text = curr.Name;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            curr = guys[2];
            curr.UpdateLabels();
            label2.Text = curr.Name;
        }
    }
}
