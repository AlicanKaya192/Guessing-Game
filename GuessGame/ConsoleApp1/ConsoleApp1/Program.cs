using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Guessing Game");
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine("");

            Random rnd = new Random();

            Console.Write("What range should the prediction be in : ");
            int firstRange = Convert.ToInt32(Console.ReadLine());

            int secondRange;
            while (true)
            {
                Console.Write("Second range : ");
                secondRange = Convert.ToInt32(Console.ReadLine());

                if (secondRange > firstRange)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid range. The second range must be greater than the first range.");
                }
            }

            int randomNumber = rnd.Next(firstRange, secondRange);

            Console.WriteLine("");
            Console.Write("Let's Guess Number: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (guess == randomNumber)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You found the number!");
                }
                else
                {
                    Console.WriteLine("");
                    Console.Write("Wrong, Let's guess again: ");
                    int guessAgain = Convert.ToInt32(Console.ReadLine());
                    guess = guessAgain;

                    if(guess == randomNumber)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You found the number!");
                    }
                }

            } while (guess != randomNumber);

            Console.WriteLine("Click a button to continue");
            Console.ReadKey();
        }
    }
}
