using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_6_
{
    internal class Person : IComparable<Person>
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

        public int CompareTo(Person? other)
        {
            int res;
            res = this.Name.CompareTo(other.Name);
            if(res == 0)
            {
                res = this.Age - other.Age;
            }
            return res;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Person))
            {
                return false;
            }
            Person other = (Person)obj;
            return this.Name.Equals(other.Name) && this.Age == other.Age;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Age;
        }
    }
}
