using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page162Drill
{
    class Dude
    {
        string Name { get; set; }
        string Id { get; set; }
        int Radness { get; set; }

        public static void MyDude(string Name, string Id, int Radness )
        {
            Console.WriteLine(Name + " is my dude, his dude ID is: " + Id + " and his current level of radness is: " + Radness);
            Console.ReadLine();
        }
    }
}
