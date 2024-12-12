using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie11
{

    class DinnerParty : Party
    {
        public bool HealthyOption {  get; set; }
        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;

                totalCost += NumberOfPeople * CostOfBeveragesPerPerson;


                if(HealthyOption)
                {
                    totalCost *= 0.95M;
                }
                return totalCost;
            }
        }

        private decimal CostOfBeveragesPerPerson
        {
            get
            {
                decimal costOfBeveragesPerPerson;

                if(HealthyOption) costOfBeveragesPerPerson = 5.0M;
                else costOfBeveragesPerPerson = 20.0M;

                return costOfBeveragesPerPerson;
            }
        }
        

        public DinnerParty(int numberOfPeople = 10, bool healthyOption = false, bool fancyOption = true)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyOption;
            HealthyOption = healthyOption;

        }
    }
}
