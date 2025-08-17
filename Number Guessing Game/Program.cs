using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing_Game
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====== Number Guessing Game ======");
            Console.WriteLine("I'm thinking of a number between 1-100.");
            Console.WriteLine("Try to guess it!");
            Console.WriteLine("Enter 'q' at any time to quit.");
            Console.WriteLine("=====================================\n");

            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int a = 0;

            while (true)
            {
                Console.Write("\nEnter your guess (or 'q' to quit): ");
                string input = Console.ReadLine();

                // Quit kontrolü
                if (input.ToLower() == "q")
                {
                    Console.WriteLine("\nThanks for playing!");
                    break;  // Oyundan çık
                }

                int number;
                if (int.TryParse(input, out number))
                {
                    a++;

                    if (number < 1 || number > 100)
                    {
                        Console.WriteLine("Please enter a number between 1-100!");
                        continue;
                    }
                        
                    if (number > secretNumber)
                    {
                        Console.WriteLine("\nToo high! Try again.");
                    }

                    else if (number < secretNumber)
                    {
                        Console.WriteLine("\nToo low! Try again.");
                    }

                    else
                    {
                        Console.WriteLine($"\nCongratulations! You found it in {a} attempts!");

                        Console.WriteLine("\nPlay again? (y/n)");
                        string s = Console.ReadLine();
                        string lower = s.ToLower();
                        if (lower == "y" || lower == "yes")
                        {
                            secretNumber = random.Next(1, 101);
                            a = 0;
                            Console.WriteLine("New Game Started!");
                            continue;
                        }

                        else
                        {
                            Console.WriteLine("Thanks for playing! 👋");
                            break;
                        }
                    }
                }
                else
                {
                        Console.WriteLine("Please enter a valid number!");
                }
            }
        }
    }
}
