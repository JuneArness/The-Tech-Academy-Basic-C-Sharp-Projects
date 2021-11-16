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
        string playerScore = Console.ReadLine();

        string[] scores = new string[3];
        scores[0] = "Win";
        scores[1] = "Lose";
        scores[2] = "Draw";

        Console.WriteLine("" + playerScore);

        foreach (string score in scores) 
        {
            Console.WriteLine();
        }

        foreach (string score in scores)
        {
            Console.WriteLine(playerScore);
        }



        // --------
        int num02 = 0;

        while (num02 == 0)
        {
            Console.WriteLine(num02 == 0);
            break;
        }



        //-------
        int num03 = 0;

        while (num03 < 10)
        {
            Console.WriteLine("the number is less than ten");
            break;
        }

        int num04 = 0;

        while (num04 <= 10)
        {
            Console.WriteLine("The number is less than or equals to ten");
            break;
        } 


        //--------

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

        
        foreach (int a in list)
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

        //-----


        List<int> x = new List<int>();
        x[0] = (00);
        x[1] = (01);
        x[2] = (02);
        x[3] = (03);
        x[4] = (04);
        x[5] = (05);

        Console.WriteLine("Chose from 01, 01, 02, 03, 04, 05");
        int numSelect = Convert.ToInt32(Console.ReadLine());


        foreach (int a in x)
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



        List<int> year = new List<int>();
        year.Add(64);
        year.Add(70);
        year.Add(79);
        year.Add(96);
        year.Add(00);

        Console.WriteLine("What is your favorite year of the Chevy Impala? Chose from '64, '70, '79, '96, '00");
        int chevyImpala = Convert.ToInt32(Console.ReadLine());


        foreach (int a in year)
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




    }
}

