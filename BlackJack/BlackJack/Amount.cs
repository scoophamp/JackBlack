using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Amount
    {
        public int MyAmount { get; set; }

        Player DaPlayer = new Player();


        public void Win()
        {
            MyAmount = MyAmount * 2;
        }
        public void Loose()
        {
            MyAmount = MyAmount - DaPlayer.Bet;
            
        }
    }
}
