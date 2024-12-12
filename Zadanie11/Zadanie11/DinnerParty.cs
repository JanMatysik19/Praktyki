using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie11
{

    class DinnerParty
    {
        private bool healtyOption;
        public bool HealtyhOption
        {
            set
            {
                healtyOption = value;
            }
        }
        
        private bool fancyOption;
        public bool FancyOption
        {
            set
            {
                fancyOption = value;
            }
        }


        private int numberOfPeople;
        public int NumerOfPeople
        {
            get
            {
                return numberOfPeople;
            }
            set
            {
                numberOfPeople = value;
            }
        }
        public decimal Cost
        {
            get
            {
                return CalculateCost();
            }
        }


        private decimal CostOfBeveragesPerPerson
        {
            get
            {
                return SetHealthyOption(healtyOption);
            }
        }
        private decimal CostOfDecorations
        {
            get
            {
                return CalculateCostOfDecorations(fancyOption);
            }
        }
        
        



        public DinnerParty(int NumerOfPeople = 10, bool healthyOption = false, bool fancyOption = true)
        {
            this.NumerOfPeople = NumerOfPeople;
            this.fancyOption = fancyOption;
            this.healtyOption = healthyOption;

            SetHealthyOption(healthyOption);
            CalculateCostOfDecorations(fancyOption);

        }

        private decimal SetHealthyOption(bool value)
        {
            decimal costOfBeveragesPerPerson;

            if(value) costOfBeveragesPerPerson = 5.0M;
            else costOfBeveragesPerPerson = 20.0M;

            return costOfBeveragesPerPerson;
        }

        private decimal CalculateCostOfDecorations(bool value)
        {
            decimal costOfDecorations;
            if(value) costOfDecorations = 15.0M * numberOfPeople + 50.0M;
            else costOfDecorations = 7.5M * numberOfPeople + 30.0M;

            return costOfDecorations;
        }

        private decimal CalculateCost()
        {
            decimal cost = numberOfPeople * (25.0M + CostOfBeveragesPerPerson) + CostOfDecorations;

            if (CostOfBeveragesPerPerson == 5.0M) cost *= 0.95M;

            return cost;
        }
    }
}
