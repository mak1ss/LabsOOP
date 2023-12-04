using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    internal class Student
    {
        public string Faculty {  get; private set; }  
        
        public string[] Marks { get; private set; }

        public Student (string faculty, string[] marks)
        {
            Faculty = faculty;
            Marks = marks;
        }
    }
}
