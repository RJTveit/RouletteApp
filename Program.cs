using System;
using System.Dynamic;

namespace RouletteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to place a bet on Roulette: yes or no?");
            
            switch (Console.ReadLine())
            {
                case "yes":
                    do
                    {
                        Bets newBet = new Bets();
                        newBet.BettingTable();

                        Console.WriteLine("Would you like to place another bet? (yes/no)");

                    } while (Console.ReadLine() == "yes");

                    Console.WriteLine("Okay, thanks for visiting");
                    break;

                case "no":
                    Console.WriteLine("Okay, thanks for visiting");
                    break;
            }                                
        }
    }
}
