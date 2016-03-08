using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {
        private List<Enum> MyCards = new List<Enum>(52);
        
        private enum TheDeck
        {
            two = 2,
            three = 3,
            four = 4,
            five = 5,
            six = 6,
            seven = 7,
            eight = 8,
            nine = 9,
            ten = 10,
            knight = 10,
            queen = 10,
            king = 10,
            ace = 0,

        }
        private enum SortsofCards
        {
            Heart,
            Spades,
            Club,
            Diamond
        }

       
        public void TheCards() //Writes the cards to the list
        {
           
                       

        }

        
    }
}
