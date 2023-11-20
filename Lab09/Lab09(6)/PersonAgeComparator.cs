using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_6_
{
    internal class PersonAgeComparator : IComparer<Person>
    {
        public int Compare(Person? x, Person? y)
        {
            return x.Age - y.Age;
        }
    }
}
