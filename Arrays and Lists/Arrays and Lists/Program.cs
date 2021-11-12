using System;
using System.Collections.Generic;




class Program
{
    static void Main()

        
    {       // This is a list of strings fro the user to select from:
        Console.WriteLine("Chose from the index of lists:");
        List<string> intList = new List<string>();
        intList.Add ("Red0");
        intList.Add ("Blue1");
        intList.Add ("Yellow2");
        intList.Add ("Purple3");
        intList.Add ("Green4");
        intList.Add ("Orange5");

        Console.WriteLine("Select a number between 1 and 6");
        int stringSelect = Convert.ToInt32(Console.ReadLine());
        


        //// This is a one-demsional array of strings: 
        
        List<string> strArray = new List<string>();
        strArray.Add("Earth0");
        strArray.Add("Fire1");
        strArray.Add("Water2");
        strArray.Add("Sun3");
        strArray.Add("Wind4");
        strArray.Add("Moon5");
        Console.WriteLine("Chose an index: 0| 1| 2| 3| 4 5| 6|");
        int intSelect = Convert.ToInt32(Console.ReadLine());
       




        Console.WriteLine();
        Console.WriteLine();


        //// This is a one-demsional array of integers: 

        List<string> intArray = new List<string>();
        intArray.Add("Happy1");
        intArray.Add("Sad");
        intArray.Add("Angry");
        intArray.Add("Confused");
        intArray.Add("Excited");
        intArray.Add("Intgrigued");
        Console.WriteLine("Chose an index: 0| 1| 2| 3| 4 5| 6|");
        int intergerSelect = Convert.ToInt32(Console.ReadLine());
       


        Console.WriteLine();
        Console.WriteLine();




        //// This is an while statement that will let the user know if they have selected a index that is included
        // I am using a catch and block statement here 

        if (stringSelect <= 6)
        {
            Console.WriteLine("You have selected " + strArray[stringSelect - 1]);
        }

        else
        {
            Console.WriteLine("Sorry, that number selection is invalid. Select a number between 1 and 6");

        }

        // Try catch for String Array


        if (intSelect <= 6)
        {
            Console.WriteLine("You have selected " + intList[intSelect - 1]);
        }

        else
        {
            Console.WriteLine("Sorry, that number selection is invalid. Select a number between 1 and 6");

        }

        

        // Try catch for int Array

        if (intergerSelect <= 6)
        {
            Console.WriteLine("You have selected " + intArray[intergerSelect - 1]);
        }

        else
        {
            Console.WriteLine("Sorry, that number selection is invalid. Select a number between 1 and 6");

        }

     

        Console.ReadLine();

       

            
       

    }
}
