using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Race
{
    class Bet
    {
        public int Cash;
        public Guys Bett;
        public int Racer;

        public string Betmake()
        {
            return Bett.bettor + " Bet" + Cash + "$ on no #" + Racer;
        }

        public int Cashadd(int winer)
        {
            if (Racer == winer)
            {
                return Cash;
            }
            else
            {
                return -1 * Cash;
            }
        }
    }
}
