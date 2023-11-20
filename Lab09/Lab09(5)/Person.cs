using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_5_
{
    internal class Person : IComparable<Person>
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Town { get; private set; }

        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }

        public int CompareTo(Person? other)
        {           
            if (other == null)
            {
                return -1;
            }
            if (other == this)
            {
                return 0;
            }
            if(this.Name.CompareTo(other.Name) != 0)
            {
                if(this.Age != other.Age)
                {
                    return this.Town.CompareTo(other.Town);                  
                } else
                {
                    return 0;
                }
            } else
            {
                return 0;
            }
        }
    }
}
