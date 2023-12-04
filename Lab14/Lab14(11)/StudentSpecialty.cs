using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_11_
{
    internal class StudentSpecialty
    {
        public string SpecialtyName { get; private set; }
        public int Faculty { get; private set; }

        public StudentSpecialty(string name, int faculty)
        {
            SpecialtyName = name;
            Faculty = faculty;
        }
    }
}
