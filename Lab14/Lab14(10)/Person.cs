using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_10_
{
    internal class Person
    {
        public string Name { get; private set; }

        public int Group { get; private set; }

        public Person(string name, int group)
        {
            Name = name;
            Group = group;
        }
    }
}
