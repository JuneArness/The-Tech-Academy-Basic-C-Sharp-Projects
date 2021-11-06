using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multiplication
            Console.WriteLine(" Enter Your Number Here:");
            long X = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("your number multiplied by 50 is: " +  X * 50);

            Console.WriteLine();

            // Addition
            Console.WriteLine(" Enter Your Number Here:");
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your number added to 25 is: " + ( Y + 25));


            Console.WriteLine();

            // Decimal
            Console.WriteLine(" Enter Your Number Here:");
            float Z = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("your number devided by 12.5 is: " + Z / 12.5);

            Console.WriteLine();

            // Boolean
            Console.WriteLine(" Enter Your Number Here:");
            int Num = Convert.ToInt32(Console.ReadLine());
            bool  trueOrFalse = Num > 50 ;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();

            Console.WriteLine();

            //Remainder
            Console.WriteLine(" Enter Your Number Here:");
            int P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The remainder of your number devided by 12.5 is: " + P % 12.5);

            Console.ReadLine();



            //int total = 5 + 10;
            //int otherTool = 12 + 22;
            //int combined = total + otherTool;
            ////Console.WriteLine("Five plus Ten = " + total.ToString());
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("ten minus five =" + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 > 5;
            //Console.Write(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 70;

            //bool isWarm = currentTemperature >= roomTemperature;
            //bool isWarm = currentTemperature == roomTemperature; equal too
            //bool isWarm = currentTemperature != roomTemperature ;  does not equal
            //Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
}
