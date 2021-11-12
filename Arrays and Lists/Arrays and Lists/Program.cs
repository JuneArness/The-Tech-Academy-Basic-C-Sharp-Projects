using System;
using System.Collections.Generic;




class Program
{
    static void Main()

        
    {       // This is async list of strings
        List<string> intList = new List<string>();
        intList.Add("Hello");
        intList.Add("June");
        intList.Remove("Arness");
        Console.WriteLine(intList[0]);



        // This is a one-demsional array of strings: 
        int[] stringArray = new int[5];
        stringArray[0] = 5;
        stringArray[1] = 2;
        stringArray[2] = 10;
        stringArray[3] = 200;
        stringArray[4] = 5000;

        int[] stringArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        int[] stringArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        stringArray2[5] = 650;


        Console.WriteLine(stringArray2[5]);


        // This is a one-demsional array of integers: 
        int[] intArray = new int[5];
        intArray[0] = 5;
        intArray[1] = 2;
        intArray[2] = 10;
        intArray[3] = 200;
        intArray[4] = 5000;

        int[] intArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        int[] intArrayy2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        intArray2[3] = 10;


        Console.WriteLine(intArray2[3]);


            // This is an if statement that will let the user know if they have selected a index that is included
        if (false)
        {
            Console.WriteLine("You have selected a invalid index. Try again");

        }

       
        Console.ReadLine();

       

            
        }

    }
}
