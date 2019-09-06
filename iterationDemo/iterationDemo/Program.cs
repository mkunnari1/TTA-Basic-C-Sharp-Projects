using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Failing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            //string[] names = { "joe", "tony", "daithi", "evan" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    if (names[j] == "joe")
            //    {
            //        Console.WriteLine(names[j]);
            //    }
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(78);
            //testScores.Add(68);
            //testScores.Add(85);
            //testScores.Add(94);
            //testScores.Add(98);

            //foreach(int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "joe", "tony", "daithi", "evan" };

            //foreach(string name in names)
            //{
            //    if( name == "joe")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //Console.ReadLine();

            List<int> testScores = new List<int>() { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
            List<int> passingScores = new List<int>();

            foreach(int score in testScores)
            {
                if (score >= 85)
                {
                    passingScores.Add(score);
                }

            }
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();

        }
    }
}
