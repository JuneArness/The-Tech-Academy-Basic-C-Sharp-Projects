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
            if (list.Contains(userInput))
            {
                Console.WriteLine("The input has been found");
                int index = list.IndexOf(userInput);
                Console.WriteLine("number: " + userInput + " " + "index: " + index);

            }
            else
            {
                Console.WriteLine("The input has not been found");

            }
            break;
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
            if (list.Contains(numSelect))
            {
                Console.WriteLine("The input has been found");
                int append = list.IndexOf(numSelect);
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
        year.Add("70");
        year.Add("79");
        year.Add("96");
        year.Add("00");

        Console.WriteLine("What is your favorite year of the Chevy Impala? Chose from '64, '70, '79, '96, '00");
        string chevyImpala = (Console.ReadLine());


        foreach (string list in year)
        {
            if (list.Contains(chevyImpala))
            {
                Console.WriteLine("The input has been found");
                int classes = list.IndexOf(chevyImpala);
                Console.WriteLine("number: " + chevyImpala + " " + "append: " + classes);

            }
            else
            {
                Console.WriteLine("The input has not been found");

            }
            break;
        }


        Console.ReadLine();

    }
}

