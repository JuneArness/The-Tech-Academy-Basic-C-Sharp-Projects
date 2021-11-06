using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income
{
    class Program
    {
        static void Main(string[] args)
        {
            // First and second line:
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine();
            Console.WriteLine();

            // This is simply a line break for ease to the reader:
            Console.WriteLine();
            Console.WriteLine();

            // This is code to imput the pay per hour and how many hours worked:
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate:");
            int hourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hourly Rate:" + hourlyRate);
            Console.WriteLine("Hours worked per week:");
            int hoursWorked = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week:" + hoursWorked);

            // This is simply a line break for ease to the reader:
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate:");
            int rateHourly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hourly Rate:" + rateHourly);
            Console.WriteLine("Hours worked per week:");
            int workedHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week:" + workedHours);
            Console.ReadLine();

            // This is simply a line break for ease to the reader:
            Console.WriteLine();
            Console.WriteLine();

            // Annual Salary code design to take the houryl rate add it to the weekly hours worked,
            // and then multiply that by 52 weeks.
            Console.WriteLine("Person 1 Annual Salary");
            //string annualSalary = Console.ReadLine();
            int annualSalary = hourlyRate * hoursWorked * 52;
            Console.WriteLine("Annual Salary:" + annualSalary);
            Console.ReadLine();

            // This is simply a line break for ease to the reader:
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Person 2 Annual Salary");
            //string salaryAnnual = Console.ReadLine();
            int salaryAnnual = rateHourly * workedHours * 52;
            Console.WriteLine("Annual Salary:" + salaryAnnual);
            Console.ReadLine();

            // This is simply a line break for ease to the reader:
            Console.WriteLine();
            Console.WriteLine();


            // Boolean to decide which person makes the most annually

            Console.WriteLine(" Does Person 1 make more money than Person 2?:");
            bool trueOrFalse = annualSalary > salaryAnnual;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();

            // This is simply a line break for ease to the reader:
            Console.WriteLine();
            Console.WriteLine();

            
            Console.ReadLine();


        }
    }
}
