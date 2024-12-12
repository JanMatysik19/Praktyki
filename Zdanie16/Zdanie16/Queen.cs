using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zdanie16
{
    class Queen : Bee
    {
        private Worker[] workers;
        private int shiftNumber;

        public Queen(Worker[] workers, double mg = 10) : base(mg)
        {
            this.workers = workers;
            shiftNumber = 0;
        }

        private void DefendTheHive(IStingPatrol patroller) { }

        public bool AssignWork(string work, int shifts)
        {
            foreach (Worker worker in workers)
            {
                if(worker.DoThisJob(work, shifts))
                {
                    MessageBox.Show("Zadanie '" + work + "' będzie ukończone za " + shifts + " zmiany");
                    return true;
                }
                
            }

            MessageBox.Show("Nie ma wolnych pszczół do wykonania tego zadania");
            return false;
        }

        public string WorkTheNextShift()
        {
            double honeyConsumed = HoneyConsumptionRate();

            shiftNumber++;
            string raport = "Raport zmiany numer " + shiftNumber.ToString();
            for (int i = 0; i < workers.Length; i++)
            {
                Worker worker = workers[i];
                honeyConsumed += worker.HoneyConsumptionRate();

                raport += "\r\nRobotnica numer " + (i + 1);

                if(worker.DidYouFinish()) raport += " nie pracjue";
                else
                {
                    if (worker.ShiftsLeft > 0) raport += " robi '" + worker.CurrentJob + "' jeszcze przez " + worker.ShiftsLeft + " zmiany";
                    else raport += " zkończy '" + worker.CurrentJob + "' po tej zmianie";
                }
            }
            raport += "\r\nCałkowite spożycie miodu: " + honeyConsumed + " jednostek\r\n";
            return raport;
        }
    }
}
