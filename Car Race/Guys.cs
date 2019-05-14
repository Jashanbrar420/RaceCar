using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Car_Race
{
    class Guys
    {
        public string bettor;
        public Bet bets;
        public RadioButton Racer_RB;
        public Label Racer_lb;
        public int Cash;
       

        public void Racer_lable()//this method is for the update lable
        {
            if (bets != null)
            {
                Racer_lb.Text = bets.Betmake();
            }
            else
            {
                Racer_lb.Text = bettor + " Please place a bet";
            }
            Racer_RB.Text = bettor + " has " + Cash + " $";
        }

        public void ClearBet()//this method clears the bet
        {
            bets = null;
        }

        public bool betMake(int Money, int Racer)//this method places the bet and check if the pet is alredy placed

        {
            if (Money <= Cash)
            {
                if (bets == null)
                {
                    bets = new Bet() {
                        Cash = Money, Racer = Racer, Bett = this
                    };
                    return true;
                }
                else
                {
                    MessageBox.Show("Sorry u Already placed a bet", "Message");//this is for the emssage popup
                    return false;
                }
            }
            else
            {
                MessageBox.Show("No Money ", "Message");
                return false;
            }
        }

        public void Winner(int beter)//this method add the money that is won 
        {
            if (bets != null)
            {
                Cash += bets.Cashadd(beter); 
            }
        }
    }
}
