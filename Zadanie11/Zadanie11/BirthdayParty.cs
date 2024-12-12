using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11
{
    class BirthdayParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations {  get; set; }
        public string CakeWriting { get; set; }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }


        private int ActualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength()) return MaxWritingLength();
                else return CakeWriting.Length;
            }
        }

        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength()) return true;
                else return false;
            }
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations) costOfDecorations = (NumberOfPeople * 15.0M) + 50.0M;
            else costOfDecorations = (NumberOfPeople * 7.5M) + 30.0M;
            return costOfDecorations;
        }

        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                decimal cakeCost;
                if (CakeSize() == 20) cakeCost = 40M + ActualLength * 0.25M;
                else cakeCost = 75M + ActualLength * 0.25M;

                if (NumberOfPeople > 12) totalCost += 100M;

                return totalCost + cakeCost;
            }
        }

        private int CakeSize()
        {
            if (NumberOfPeople <= 4) return 20;
            else return 40;
        }

        private int MaxWritingLength()
        {
            if (CakeSize() == 8) return 16;
            else return 40;
        }
    }
}
