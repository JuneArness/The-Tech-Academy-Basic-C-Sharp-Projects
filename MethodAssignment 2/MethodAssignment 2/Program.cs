using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // gathering the user input to apply to math equation 
            
            Console.WriteLine("Please enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a second number (optional)");
            try
            {
                int num2 = Convert.ToInt32(Console.ReadLine());
                int answer = Pong.Comparing(num1, num2);
                Console.WriteLine("Your two numbers added together is equal to:" + answer);
            }
            catch
            {
                int answer = Pong.Comparing(num1);
                Console.WriteLine("Your umber plus 7 is eqaul too" + answer);
            }
            

            


            Console.ReadLine();
        }
    }
}


