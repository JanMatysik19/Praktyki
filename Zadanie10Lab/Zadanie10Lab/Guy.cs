using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie10Lab
{
    class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadiobutton;
        public Label MyLabel;

        public Guy(string name, RadioButton radioButton, Label label, int cash = 0)
        {
            Name = name;
            Cash = cash;
            MyRadiobutton = radioButton;
            MyLabel = label;

            UpdateLabels();
        }

        public void UpdateLabels()
        {
            MyRadiobutton.Text = Name + " ma " + Cash + " zł";
            
            if(MyBet != null)
            {
                MyLabel.Text = MyBet.GetDescription();
            }
            else
            {
                MyLabel.Text = Name + " nie zawarł zakładu";
            }
        }

        public void ClearBet()
        {
            if(MyBet != null)
            {
                MyBet = null;
            }
        }

        public bool PlaceBet(int Amount, int DogToWin)
        {
            if(Amount <= Cash)
            {
                MyBet = new Bet(Amount, DogToWin, this);

                UpdateLabels();

                return true;
            }
            return false;
        }

        public void Collect(int Winner)
        {
            if(MyBet != null)
            {
                Cash += MyBet.PayOut(Winner);
            }

            ClearBet();
            UpdateLabels();
        }
    }
}
