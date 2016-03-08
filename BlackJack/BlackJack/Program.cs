using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Amount MineAmount = new Amount();

            MineAmount.MyAmount = 100;

            Console.WriteLine("Welcome to BlackJack!");
            Console.WriteLine("(B)et");
            Console.WriteLine("(Q)uit");
            var choice = Console.ReadLine();
            switch(choice.ToUpper())
            {
                case "B":
                    {
                        Console.WriteLine("How much do you want to bet?");
                        break;
                    }
                case "Q":
                    {
                        Console.WriteLine("Welcome back!");
                        Environment.Exit(0);
                        break;
                    }
            }
        }
    }
}
