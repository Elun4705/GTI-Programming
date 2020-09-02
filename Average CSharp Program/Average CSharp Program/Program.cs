using System;

namespace ConsoleAppEmmanuelAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double score1, score2, score3;
            int averageScore;

            score1 = 87;
            score2 = 83;
            score3 = 78;

            averageScore = (int)((score1 + score2 + score3) / 3);

            Console.WriteLine("Scores");
            Console.WriteLine("exam 1= {0}", score1);
            Console.WriteLine("exam 2= {0}", score2);
            Console.WriteLine("exam 3= {0}", score3);
            Console.WriteLine("average----> {0}", averageScore);

            Console.ReadKey();
        }
    }
}
