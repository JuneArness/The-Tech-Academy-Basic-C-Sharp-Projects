using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {

            // gathering the user input to apply to math equation 
            Math math = new Math();
            Console.WriteLine("What number would you like to add to 5?");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(math.Addition(num1));

            Console.WriteLine("What number would you like to add to 10?");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(math.Adding(num2));

            Console.WriteLine("What number would you like to add to 20?");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(math.Added(num3));

            Console.ReadLine();
        }
    }
}


//public void Caller()
//{
//    int numA = 4;
//    // Call with an int variable.
//    int productA = Square(numA);

//    int numB = 32;
//    // Call with another int variable.
//    int productB = Square(numB);

//    // Call with an integer literal.
//    int productC = Square(12);

//    // Call with an expression that evaulates to int.
//    productC = Square(productA * 3);
//}

//int Square(int i)
//{
//    // Store input argument in a local variable.
//    int input = i;
//    return input * input;
//}