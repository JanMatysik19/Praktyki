﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie9
{
    public partial class Form1 : Form
    {
        LabelBouncer[] bouncers = new LabelBouncer[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void ToggleBouncing(int index, Label labelToBounce)
        {
            if(bouncers[index] == null)
            {
                bouncers[index] = new LabelBouncer(labelToBounce);
            }
            else
            {
                bouncers[index] = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToggleBouncing(2, label3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToggleBouncing(1, label2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToggleBouncing(0, label1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < 3; i++)
            {
                if (bouncers[i] != null)
                {
                    bouncers[i].Move();
                }
            }
        }
    }
}
