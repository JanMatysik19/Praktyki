using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zdanie16
{
    public partial class Form1 : Form
    {
        Worker[] workers;
        Queen queen;
        public Form1()
        {
            InitializeComponent();

            workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu" });
            workers[1] = new Worker(new string[] { "Pielęgnacja jaj", "Nauczanie pszczółek" });
            workers[2] = new Worker(new string[] { "Utrzymanie ula", "Patrol z żądłami" });
            workers[3] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu", "Pielęgnacja jaj", "Nauczanie pszczółek", "Utrzymanie ula", "Patrol z żądłami" });

            queen = new Queen(workers);
        }

        private void nextShift_Click(object sender, EventArgs e)
        {
            report.Text += queen.WorkTheNextShift();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            queen.AssignWork(workerBeeJob.GetItemText(workerBeeJob.SelectedItem), (int)shifts.Value);
        }
    }
}
