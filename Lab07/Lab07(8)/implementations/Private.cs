using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab07_8_.interfaces;

namespace Lab07_8_.implementations
{
    internal class Private : Soldier, IPrivate
    {
        public double Salary { get; }

        public Private(int id, string firstName, string lastName, double salary)
        : base(id, firstName, lastName)
        {
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Salary: {Salary:F2}";
        }
    }
}
