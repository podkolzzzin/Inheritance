using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    enum Sex
    {
        Male,
        Female
    }

    class Human : AliveEntity, ISavable, ILoadable
    {
        public Sex Sex;
        public string Name;

        public DateTime Birthdate
        {
            get;
            private set;
        }
        public Address Birthplace
        {
            get;
            private set;
        }
        public string Education;

        public Human(DateTime birthdate, Address birthplace)
        {
            Birthdate = birthdate;
            Birthplace = birthplace;
        }

        public virtual void Walk()
        {
            Console.WriteLine("Human walks");
        }

        public void Read()
        {
            Console.WriteLine("Human reads");
        }

        public void Write()
        {
            Console.WriteLine("Human writes");
        }

        public override void Die()
        {
            Console.WriteLine("Human is dieng");
        }


        public virtual void Save(StreamWriter sw)
        {
            sw.WriteLine("Human: " + Name);
        }

        void ILoadable.Load(StreamReader reader)
        {
            Console.WriteLine("Human is loading");
        }
    }
}
