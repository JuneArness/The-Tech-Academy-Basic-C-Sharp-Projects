using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            //  This is the preset weight limit
            int weightLimit = 50;

            //Header line
            Console.WriteLine("Welcome to Package Express. Please follow the intructions below:");
            string name = Console.ReadLine();

            // User shold be able to input package weight
            Console.WriteLine("What is the pachage weight?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight <= weightLimit)
            {
                Console.WriteLine("What is the package weight");
            }
            else if (packageWeight > weightLimit)
            {
                Console.WriteLine("The Package is too heavy to be shipped via Package Express. Have a good day.");
            }
            

            {
                Console.WriteLine("What is the pachage width?");
                int packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("What is the package Length?");
                int packageLength = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("What is the package height?");
                int packageheight = Convert.ToInt32(Console.ReadLine());

                string comparisonReult = packageWidth + packageLength + packageheight > 50 ?: ("Package too big to be shipped via Package Express.");


                // User should be given a quote here
                int packageQuote = ((packageWidth * packageLength * packageheight) * packageWieght) / 100;
                Console.WriteLine("Package Qoute:" + packageQuote);
                Console.ReadLine();
            }
           
            Console.ReadLine();
        }
    }
}
