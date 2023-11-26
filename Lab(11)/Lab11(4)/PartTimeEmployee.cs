using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_4_
{
    internal class PartTimeEmployee : IEmployee
    {
        public int HoursPerWeek { get; } = 20;

        public string Name { get ; }

        public PartTimeEmployee(string name)
        {
            Name = name;
        }
    }
}
