using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string score01 = "Win";
        string score02 = "Lose";
        string score03 = "Draw";




        Console.WriteLine("What is your score? Input Win, Lose or Draw:");
        string playerScore = (Console.ReadLine());

        string[] scores = new string[3];
        scores[0] = "Win";
        scores[1] = "Lose";
        scores[2] = "Draw";

        Console.WriteLine("" + playerScore);

        foreach (string score in playerScore) ;
        {
            Console.WriteLine();
        }

        foreach (string score in playerScore)
        {
            Console.WriteLine(playerScore);
        }

        int num02 = 0;

        do
        {
            Console.WriteLine("loop nr" + num02);
            num02++;
        } while(num02 < 10);

        int num03 = 0;

        do
        {
            Console.WriteLine("loop nr" + num03);
            num03++;
        } while (num03 < 10);

        int num04 = 0;

        do
        {
            Console.WriteLine("loop nr" + num04);
            num04++;
        } while (num04 <= 10);


        

        List<int> list = new List<int>();
        list.Add(55);
        list.Add(45);
        list.Add(55);
        list.Add(65);
        list.Add(73);
        list.Add(24);
        list.Add(65);

        Console.WriteLine("Chose from 55, 45, 55, 65, 73, 24, 65");
        foreach (int a in list)
        {
            Console.WriteLine("{0}", a);
        }

        List<int> myList = list.Distinct().ToList();
        Console.WriteLine();
        foreach (int a in myList)
        {
            Console.WriteLine("{0}", a);



            int list;
            if (int.TryParse(myList, out list))
                Console.WriteLine($"Your number is: {list}");
            else
                Console.WriteLine("This is not a number!");


            Console.WriteLine("Please select a number 01, 01, 02, 03, 04, 04");
            string[] x = new string[6];
            x[0] = "01";
            x[1] = "01";
            x[2] = "02";
            x[3] = "03";
            x[4] = "04";
            x[5] = "05";

            List<string> x = new List<string>()
                {
                    "01",
                    "01",
                    "03",
                    "04",
                    "05",

                };


            Console.ReadLine();


        }
}

