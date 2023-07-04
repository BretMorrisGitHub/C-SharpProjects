using System;
using System.Collections.Generic;




class Program
{ 
        static void Main(string[] args)
        {
        int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        for (int i = 0; i < testScores.Length; i++)
        {
            if (testScores[i] > 85)
            {
                Console.WriteLine("Passing test score: " + testScores[i]);
            }
        }
        Console.ReadLine();


        List<int> scores = new List<int>();
        scores.Add(98);
        scores.Add(99);
        scores.Add(90);
        scores.Add(93);
        scores.Add(89);
        scores.Add(88);
        scores.Add(81);

        foreach (int score in scores)
        {
            if (score > 85)
            {
                Console.WriteLine("Passing test score: " + score);
            }
        }
        Console.ReadLine();

    }
}

