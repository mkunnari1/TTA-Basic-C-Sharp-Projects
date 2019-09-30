using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page162Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            const string bro = " THIS GUY IS A TOTAL BRO";

            var myGuy = new Dude("John");


            Console.WriteLine(myGuy.Name + " has a radness level of: " + myGuy.Radness + " and his bro ID is: "+ myGuy.Id+ bro) ;
            Console.ReadLine();
        }
    }
}
