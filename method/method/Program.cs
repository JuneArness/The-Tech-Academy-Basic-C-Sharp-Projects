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
            Math math = new Math();
            int num1 = 3;
           Console.WriteLine(math.Addition(num1));
          
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