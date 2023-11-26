using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_4_
{
    internal class StandartTimeEmployee : IEmployee
    {
        public int HoursPerWeek { get; } = 40;
        public string Name { get; }

        public StandartTimeEmployee(string name)
        {
            Name = name;
        }

    }
}
