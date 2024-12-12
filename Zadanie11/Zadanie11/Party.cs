using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public virtual decimal Cost {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;

                if (NumberOfPeople > 12) totalCost += 100;

                return totalCost;
            }
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal cost;

            if (FancyDecorations) cost = (NumberOfPeople * 15.0M) + 50.0M;
            else cost = (NumberOfPeople * 7.5M) + 30.0M;

            return cost;
        }
    }
}
