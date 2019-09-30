using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page162Drill
{
    public class Dude
    {
        public Dude(string name) : this(name, 5)
        {
            
        }
        public Dude(string name, int radness)
        {
            Name = name;
            Radness = radness;
            Id = Guid.NewGuid();
        }

        public string Name { get; set; }
        public Guid Id { get; set; }
        public int Radness { get; set; }

       
    }
}
