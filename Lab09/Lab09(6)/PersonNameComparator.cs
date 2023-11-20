using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_6_
{
    internal class PersonNameComparator : IComparer<Person>
    {
        public int Compare(Person? x, Person? y)
        {
            int res;
            res = x.Name.Length - y.Name.Length;
            if(res == 0)
            {
                res = x.Name.ToLower().CompareTo(y.Name.ToLower());
            }
            return res;
        }
    }
}
