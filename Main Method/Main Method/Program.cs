using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // gathering the user input to apply to math equation 
            MathProbs math = new MathProbs();

            Console.WriteLine("Please enter a number:");
            
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(math.question1(num1));

            Console.WriteLine("Please enter a number:");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(math.question2(num2));

            Console.WriteLine("Please enter a number:");
            string num3 = (Console.ReadLine());
            Console.WriteLine(math.question3(num3));

            Console.ReadLine();
        }
    }
}
