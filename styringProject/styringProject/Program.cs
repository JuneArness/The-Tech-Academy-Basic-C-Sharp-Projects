using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace styringProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said, \"Hello\" Jesse. \n Hello on a new line. \n \t Hello on a tab.";
            ////string fileName = "C:\\Users\\Jesse"; Or you could use @"C:\Users\Jesse"

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;
            string slammed = "<Laying on the floor!>";
            string threeWheel = lowLife.Style.ToShortDateString();

            // Use the + and += operators for one-time concatenations.
            string lowLife = "Lay on the floor " + slammed + ". Style is " + threeWheel + ".";
            System.Console.WriteLine(lowLife);
            
            lowLife += "Hitting Switches on them";
            System.Console.WriteLine(lowLife);

            string parts = "Hydraulics";
            parts = parts.ToUpper();

            //name = name.ToLower();

            //Console.WriteLine(quote);
            //Console.ReadLine();

            StringBuilder lowriders = new StringBuilder();

            lowriders.Append("Hit the switch");
            lowriders.Append("Still Dippin");
            lowriders.Append("And scrapping bumper!");



            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
