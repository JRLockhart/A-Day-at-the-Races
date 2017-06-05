using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_at_the_Races
{
    class Guy
    {

        public string name;
        public Bet myBet;
        public int cash;

        public RadioButton myRadioButton;
        public Label myLabel;

        public void updateLabels()
        {
            myLabel.Text = name + " hasn't placed a bet!";
            myRadioButton.Text = name + " has " + cash + " bucks";
        }

        public void clearBet()
        {
            myBet = new Bet();
            myBet.amount = 0;
        }

        public bool placeBet(int betAmount, int dogToWin)
        {
            if (betAmount > cash)
            {
                return false;
            }
            else
            {
                myBet = new Bet();
                myBet.amount = betAmount;
                myBet.dog = dogToWin;
                return true;
            }
            
        }

        public void collect(int winner)
        {
            cash += myBet.payout(winner);
            this.updateLabels();
        }
    }
}
