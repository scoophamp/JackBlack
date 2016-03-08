using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
   public class Cards
    {
        public List<int> FullHand = new List<int>();

        int queen = 10;

        public void fullHand()
        {
            FullHand.Add(queen);
        }
    }
}
