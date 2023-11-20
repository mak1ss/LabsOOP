using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_6_
{
    internal class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;    
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }
}
