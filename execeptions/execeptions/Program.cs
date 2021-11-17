using System;
using System.Collections.Generic;

namespace execeptions
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>();
            list.Add(55);
            list.Add(45);
            list.Add(55);
            list.Add(65);
            list.Add(73);
            list.Add(24);
            list.Add(65);
            Console.WriteLine("Enter any number to divide by:");
           


            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                foreach (int num in list)
                {
                    Console.WriteLine(num / userInput);
                }
               
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
                return;

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
