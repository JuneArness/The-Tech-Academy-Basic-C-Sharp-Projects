using System;


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
            Console.WriteLine("Chose from 55, 45, 55, 65, 73, 24, 65");
            int userInput = Convert.ToInt32(Console.ReadLine());


            try
            {

                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Divide the two....");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + "divided by" + numberTwo + "equals" + numberThree);
                Console.ReadLine();
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
