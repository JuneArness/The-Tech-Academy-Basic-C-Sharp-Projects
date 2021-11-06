using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // First and second line:
            Console.WriteLine("The Tech Academy");
            Console.WriteLine();
            Console.WriteLine("Student Daily Report");

            // This is simply a line break for ease to the reader:
            Console.WriteLine();
            Console.WriteLine();

            // Questions: in string
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is:" + yourName);

            // This is simply a line break for ease to the reader:
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("The course your on:" + yourCourse);

            // This is simply a line break for ease to the reader:
            Console.WriteLine();
            Console.WriteLine();

            // Questions in: int


            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);
            //int total = favNum + 5;
            Console.WriteLine("Your page number is:" + pageNum);
            Console.ReadLine();

            // This is simply a line break for ease to the reader:
            Console.WriteLine();
            Console.WriteLine();

            // Questions in: Bool
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string str = Console.ReadLine();
            bool help = bool.Parse(str);
            
            
            // This is simply a line break for ease to the reader:
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Where there any positve experiences you'd like to share? Please give specifics.");
            string feedBack = Console.ReadLine();

            // This is simply a line break for ease to the reader:
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyTime = Convert.ToInt32(studyHours);
            //int total = favNum + 5;
            Console.WriteLine("You studied for:" + studyTime);
            Console.ReadLine();

            // This is simply a line break for ease to the reader:
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Thank you for your answers.");
            Console.WriteLine("An Instructor will respond to this shortly.");
            Console.WriteLine("Have a great day!!");

            Console.ReadLine();
            

        }
    }
}
