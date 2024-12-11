using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie5
{
    public partial class Form1 : Form
    {
        int startingMileage, endingMileage;
        double milesTraveled, reimburseRate, amountOwed;

        private void button1_Click_1(object sender, EventArgs e)
        {
            startingMileage = (int)numericUpDown1.Value;
            endingMileage = (int)numericUpDown2.Value;

            if (startingMileage > endingMileage)
            {
                MessageBox.Show("Początkowy stan licznika musi być mniejszy nić końcowy");
                this.Text = "Nie mogę obliczyć odległości";
            }
            else
            {
                this.Text = "Kalkulator odległości";
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled *= reimburseRate;
                label4.Text = amountOwed.ToString() + " zł";
            }
        }

        public Form1()
        {
            InitializeComponent();

            reimburseRate = 0.39;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
