using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooloeanLogic
{
    class Program
    {
        static void Main(string[] args)

        {


            // First and second line:
            Console.WriteLine("June Nation Secure Insurance Company");
            Console.WriteLine();
            Console.WriteLine();

            // This is simply a line break for ease to the reader:
            Console.WriteLine();
            Console.WriteLine();

            // This is code to imput the pay per hour and how many hours worked:
            Console.WriteLine("What is your Age?");
            int yourAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is:" + yourAge);
            
           

            // This is simply a line break for ease to the reader:
            Console.WriteLine();
            Console.WriteLine();

            // This is code to imput the pay per hour and how many hours worked:
            Console.WriteLine("Have you ever had a DUI?");
            string everDUI  = Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI:" + everDUI);


            // This is simply a line break for ease to the reader:
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have:" + speedingTickets);

            // This is simply a line break for ease to the reader:
            Console.WriteLine();
            Console.WriteLine();

            //This is a boolean eqaution to determine if the applicant is qualified 
            //The must be older 15 yeaerws of age, have NO DUI's, and have under
            //3 speeding tickets:

            Console.WriteLine(" Qualified?");
            bool trueOrFalse = yourAge > 15;
            bool trueOrFalse = everDUI == false;
            bool trueOrFalse = speedingTickets >  ;  
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();

            

            // This is simply a line break for ease to the reader:
            Console.WriteLine();
            Console.WriteLine();


            Console.ReadLine();


            //Console.WriteLine(true && false); // boolean AND operator

            //Console.WriteLine(true || false); // OR operator

            //Console.WriteLine(true == false); // EQUAL operator

            //Console.WriteLine(true != false); // DOES NOT EQUAL operator

            //Console.WriteLine(true ^ true); // EVALUATE FOR TRUE X OR operator


            Console.ReadLine();
            
        }
    }
}
