using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopProject
{
    class Program
    {
        static void Main(string[] args)
        {   // This is for a user to be promted to chose a number
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;
            // this is a do (while ) statement that will aloow the loop to be satfsied at the begining
            do
            {   // Here a user is promted to chose a number
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed 12. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }
            while (!isGuessed);
            // Here I am attempting to ADD a while loop witha boolean comparison

            bool greatJob = true;
            bool tryAgain = false;
            while (tryAgain == false)
            {
                Console.Write("Did you win? Please answer true or false ");  // Asks if you won or not
                greatJob = Convert.ToBoolean(Console.ReadLine());

                if (greatJob)  // Validates the input containts characters and/or spaces
                {
                    Console.WriteLine("Great Job!!!!");
                    tryAgain = true;
                    
                }
                else  // Error message if the input is not valid
                {
                    
                    Console.WriteLine("Try Again!");
                    
                }
            }

            Console.Read();
        }
    }
}
