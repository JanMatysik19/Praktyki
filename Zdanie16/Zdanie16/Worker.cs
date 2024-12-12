using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdanie16
{
    class Worker : Bee
    {
        public string CurrentJob
        {
            get;
            private set;
        }

        public int ShiftsLeft {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }

        private string[] jobsICanDo { get; set; }
        private int shiftsToWork;
        private int shiftsWorked;

        const double honeyUnitsPerShiftWorked = 0.65D;

        public override double HoneyConsumptionRate()
        {
            double consumption = base.HoneyConsumptionRate();
            consumption += shiftsWorked * honeyUnitsPerShiftWorked;
            return consumption;
        }

        public Worker(string[] jobsICanDo = null, double mg = 3) : base(mg)
        {
            this.jobsICanDo = jobsICanDo;
            shiftsToWork = 0;
            shiftsWorked = 0;
            CurrentJob = "";
        }


        public bool DoThisJob(string job, int shifts)
        {
            if (jobsICanDo.Contains(job) && shiftsToWork <= 0 || String.IsNullOrEmpty(CurrentJob) && jobsICanDo.Contains(job))
            {
                shiftsToWork = shifts;
                shiftsWorked = 0;
                CurrentJob = job;

                return true;
            }
            else return false;
        }

        public bool DidYouFinish()
        {
            if (String.IsNullOrEmpty(CurrentJob)) return true;

            shiftsWorked++;

            if(shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                CurrentJob = "";
                return true;
            }
            else return false;
        }


    }
}
