using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string[] scores = new string[3];
        scores[0] = "1";
        scores[1] = "2";
        scores[2] = "3";




        Console.WriteLine("What is your score? Input Win, Lose or Draw:");
        string playerScore = Console.ReadLine();

      
        for (int i = 0; i < scores.Length; i++)
        {
            scores[i] += playerScore;
            Console.WriteLine(scores[i]);
        }


        Console.ReadLine();


        //// --------
        //int num02 = 0;

        //while (num02 == 0)
        //{
        //    Console.WriteLine(num02 == 0);
        //    break;
        //}



        //-------
        int num03 = 0;

        while (num03 < 5)
        {
            Console.WriteLine("the number is less than ten");
            num03++;
        }

        int num04 = 0;

        while (num04 <= 5)
        {
            Console.WriteLine("The number is less than or equals to ten");
            num04++;
        }


        ////--------

        List<string> lists = new List<string>();
        lists.Add ("55");
        lists.Add ("45");
        lists.Add ("55");
        lists.Add ("65");
        lists.Add ("73");
        lists.Add ("24");
        lists.Add ("65");
        Console.WriteLine("Chose from 55, 45, 55, 65, 73, 24, 65");
        string userInput = (Console.ReadLine());


        foreach (string list in lists)
        {
            if (lists.Contains(userInput))
            {
                Console.WriteLine("The input has been found");
                int index = lists.IndexOf(userInput);
                Console.WriteLine("number: " + userInput + " " + "index: " + index);

            }
            else
            {
                Console.WriteLine("The input has not been found");

            }
            
        }

        ////-----


        List<string> pick = new List<string>();
        pick.Add  ("00");
        pick.Add  ("01");
        pick.Add  ("02");
        pick.Add  ("03");
        pick.Add  ("04");
        pick.Add  ("05");

        Console.WriteLine("Chose from 01, 01, 02, 03, 04, 05");
        string numSelect = (Console.ReadLine());


            foreach (string list in pick)
        {
            if (pick.Contains(numSelect))
            {
                Console.WriteLine("The input has been found");
                int append = pick.IndexOf(numSelect);
                Console.WriteLine("number: " + numSelect + " " + "append: " + append);

            }
            else
            {
                Console.WriteLine("The input has not been found");

            }
            break;
        }

        //-------------

        List<string> year = new List<string>();
        year.Add("64");
        year.Add("64");
        year.Add("79");
        year.Add("96");
        year.Add("00");

        List<string> yearCopy = new List<string>();


        foreach (string element in year)
        {
            if (yearCopy.Contains(element))
            {
                Console.WriteLine(element + "has appeared before");
            }
            else
            {
                Console.WriteLine(element + "Has not appered before");
            }
            yearCopy.Add(element);
        }


        Console.ReadLine();

    }
}

