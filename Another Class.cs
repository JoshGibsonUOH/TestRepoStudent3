using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram
{
    internal class Another_Class
    {
        public static void Game()
        {
            Console.WriteLine("Welcome to Roll for Sum!");

            Console.Write("How many dice do you want to roll? ");
            int numDice = int.Parse(Console.ReadLine());

            Console.Write("How many sides does each die have? ");
            int numSides = int.Parse(Console.ReadLine());

            int targetSum = numDice * numSides;

            Console.WriteLine("Press any key to roll the dice...");
            Console.ReadKey();

            Random rand = new Random();

            int rollSum = 0;
            for (int i = 0; i < numDice; i++)
            {
                int roll = rand.Next(1, numSides + 1);
                Console.WriteLine("Roll " + (i + 1) + ": " + roll);
                rollSum += roll;
            }

            Console.WriteLine("Total: " + rollSum);

            if (rollSum >= targetSum)
            {
                Console.WriteLine("Congratulations, you win!");
            }
            else
            {
                Console.WriteLine("Sorry, you lose. Better luck next time!");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
