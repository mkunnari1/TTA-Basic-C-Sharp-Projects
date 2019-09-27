using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace page154Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there friend can you provide me with a number please?");
            string num = Console.ReadLine();
            using (StreamWriter userNum = new StreamWriter(@"C:\Users\HP\OneDrive\Documents\C#-Projects\TTA-Basic-C-Sharp-Projects\page154Drill\page154Drill\numLog.txt", true))
            {
                userNum.WriteLine(num);
            }
            Console.WriteLine("The numbers you have provided are:\n" + File.ReadAllText(@"C:\Users\HP\OneDrive\Documents\C#-Projects\TTA-Basic-C-Sharp-Projects\page154Drill\page154Drill\numLog.txt"));
            Console.Read();
        }
    }
}
