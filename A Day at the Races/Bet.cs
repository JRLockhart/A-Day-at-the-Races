using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_at_the_Races
{
    class Bet
    {

        public int amount;
        public int dog;
        public Guy better;

        public string getDescription()
        {
            better = new Guy();

            if (amount == 0)
	        {
                return better.name + " hasn't placed a bet!";
	        }

            return better.name + " bets $" + amount + " on dog #" + dog;
        }

        public int payout(int winner)
        {

            if (dog == winner)
            {
                return amount;
            }
            else
            {
                return - amount;
            }
          
        }
    }
}
