using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Fan : Human
    {
        public Fan(DateTime birthdate, Address birthplace, params Band[] bands) 
            : base(birthdate, birthplace)
        {
            Groups = bands;
        }

        public Band[] Groups { get; set; }

        public void Shout()
        {
            string str = "";
            foreach (var item in Groups)
                str += item.Name + " ";

            Console.WriteLine("I love {0}!", str);
        }

        public override void Save(StreamWriter sw)
        {
            sw.WriteLine("Bands: ");
            foreach (var b in Groups)
                sw.WriteLine(b.Name);
        }
    }
}
