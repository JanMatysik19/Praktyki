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
        public int NumerOfPeople;
        public double CostOfBeveragesPerPerson;
        public double CostOfDecorations;
        Label CostLabel;



        public DinnerParty(Label CostLabel, int NumerOfPeople = 10, double CostOfBeveragesPerPerson = 20.0D, double CostOfDecorations = 15.0D)
        {
            this.NumerOfPeople = NumerOfPeople;
            this.CostOfBeveragesPerPerson = CostOfBeveragesPerPerson;
            
            CostOfDecorations = CostOfDecorations * NumerOfPeople;

            if (CostOfDecorations == 15.0D * NumerOfPeople) CostOfDecorations += 50;
            else CostOfDecorations += 30;

            this.CostOfDecorations = CostOfDecorations;

            this.CostLabel = CostLabel;
        }

        public void SetHealthyOption(bool value)
        {
            if(value)
            {
                CostOfBeveragesPerPerson = 5.0D;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.0D;
            }
        }

        public void CalculateCostOfDecorations(bool value)
        {
            if(value)
            {
                CostOfDecorations = 15.0D * NumerOfPeople + 50.0D;
            }
            else
            {
                CostOfDecorations = 7.5D * NumerOfPeople + 30.0D;
            }
        }

        public double CalculateCost()
        {
            double Cost = NumerOfPeople * (25.0D + CostOfBeveragesPerPerson) + CostOfDecorations;

            if (CostOfBeveragesPerPerson == 5.0D)
            {
                Cost *= 0.95;
            }

            return Cost;
        }

        public void DisplayDinnerPartyCost()
        {
            CostLabel.Text = CalculateCost() + " zł";
        }
    }
}
