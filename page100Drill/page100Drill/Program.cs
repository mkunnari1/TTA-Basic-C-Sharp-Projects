using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page100Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameAr = { "evan", "joe", "tony", "daithi" };
            int[] numAr = { 11, 13, 47, 58, 95 };
            string error = "Sorry but the index number you have requested does not exist. Please choose a new number between 0 and 3 \nMy bad on the directions my hardrive is having a rough morning";
            List<string> nameList = new List<string>();
            nameList.Add("brock");
            nameList.Add("brian");
            nameList.Add("marcel");
            nameList.Add("tyler");
            int catch1 = nameAr.Length;
            int catch2 = numAr.Length;
            int catch3 = nameList.Count;

            Console.WriteLine("Hey there user! can I get you to pick a number between.... 0 and 5? yeah let's go with that.");
            int selection = Convert.ToInt32(Console.ReadLine());
            if (selection > catch1)
            {
                Console.WriteLine(error);
                selection = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(nameAr[selection]);
            Console.WriteLine("Cool we got a name, let's give them a number. Pick another one between 0 and 5.");
            int select2 = Convert.ToInt32(Console.ReadLine());
            if (select2 > catch2)
            {
                Console.WriteLine(error);
                select2 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(numAr[select2]);
            Console.WriteLine("Good stuff there user, you're doing great.  I need one more name so you know what to do! 0-5");
            int select3 = Convert.ToInt32(Console.ReadLine());
            if (select3 > catch3)
            {
                Console.WriteLine(error);
                select3 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(nameList[select3]);
            Console.ReadLine();
            Console.WriteLine("Really wonderful stuff there user, you've really helped me out. Have a good one");
            Console.ReadLine();


        }
    }
}
