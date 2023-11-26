using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_8_
{
    internal class Pet
    {
        public string Name { get; private set; }
        public string Kind { get; private set; }
        public int Age { get; private set; }

        public Pet(string name, int age, string kind)
        {
            Name = name;
            Kind = kind;
            Age = age;
        }

    }
}
