using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    internal class Student
    {
        public string Name { get; private set; }
        public int Faculty { get; private set; }



        public Student(string name, int faculty)
        {
            Faculty = faculty;
            Name = name;
        }
    }
}
