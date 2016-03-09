using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
   {
        public List<string> Card = new List<string>();
        public void AddCardToList()
        {
            //U+2665=hjärter
            Card.Add('\u2665' + "2");
            Card.Add('\u2665' + "3");
            Card.Add('\u2665' + "4");
            Card.Add('\u2665' + "5");
            Card.Add('\u2665' + "6");
            Card.Add('\u2665' + "7");
            Card.Add('\u2665' + "8");
            Card.Add('\u2665' + "9");
            Card.Add('\u2665' + "10");
            Card.Add('\u2665' + "J");
            Card.Add('\u2665' + "Q");
            Card.Add('\u2665' + "K");
            //U+2666=ruter
            Card.Add('\u2666' + "2");
            Card.Add('\u2666' + "3");
            Card.Add('\u2666' + "4");
            Card.Add('\u2666' + "5");
            Card.Add('\u2666' + "6");
            Card.Add('\u2666' + "7");
            Card.Add('\u2666' + "8");
            Card.Add('\u2666' + "9");
            Card.Add('\u2666' + "10");
            Card.Add('\u2666' + "J");
            Card.Add('\u2666' + "Q");
            Card.Add('\u2666' + "K");
            //'\u2663'=klöver
            Card.Add('\u2663' + "2");
            Card.Add('\u2663' + "3");
            Card.Add('\u2663' + "4");
            Card.Add('\u2663' + "5");
            Card.Add('\u2663' + "6");
            Card.Add('\u2663' + "7");
            Card.Add('\u2663' + "8");
            Card.Add('\u2663' + "9");
            Card.Add('\u2663' + "10");
            Card.Add('\u2663' + "J");
            Card.Add('\u2663' + "Q");
            Card.Add('\u2663' + "K");
            //U+2660=spader
            Card.Add('\u2660' + "2");
            Card.Add('\u2660' + "3");
            Card.Add('\u2660' + "4");
            Card.Add('\u2660' + "5");
            Card.Add('\u2660' + "6");
            Card.Add('\u2660' + "7");
            Card.Add('\u2660' + "8");
            Card.Add('\u2660' + "9");
            Card.Add('\u2660' + "10");
            Card.Add('\u2660' + "J");
            Card.Add('\u2660' + "Q");
            Card.Add('\u2660' + "K");

            Card.Add('\u2665' + "A");//HJärter ess
            Card.Add('\u2666' + "A");//Ruter ess
            Card.Add('\u2663' + "A");//KLöver ess
            Card.Add('\u2660' + "A");//Spader ess

        }


        static void Main(string[] args)
        {
            


    }
    }
}
