using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    enum MusicTool
    {
        Drums,
        Guitar,
        BassGuitar,
        Piano,
        Vocal
    }

    class Musician : Human
    {
        public string Style;
        public MusicTool Tool;

        public Musician(DateTime birthdate, Address address)
            : base(birthdate, address)
        {
        }

        public override void Walk()
        {
            base.Walk();
            Console.WriteLine("Moon walking! (By Musician)");
        }

        public void Compose()
        {
            Console.WriteLine("Musician is composing");
        }

        public void Sing()
        {
            Console.WriteLine("Musician is singing");
        }

        public void Play()
        {
            Console.WriteLine("Musician is playing");
        }

        public override void Save(StreamWriter sw)
        {
            base.Save(sw);
            sw.WriteLine("Style: " + Style);
        }
    }
}
