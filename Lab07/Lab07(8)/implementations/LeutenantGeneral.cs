using Lab07_8_.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_8_.implementations
{
    internal class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public LeutenantGeneral(int id, string firstName, string lastName, double salary)
                : base(id, firstName, lastName, salary)
        {
            Privates = new List<IPrivate>();
        }

        public ICollection<IPrivate> Privates { get; }

        public override string ToString()
        {
            return $"{base.ToString()}\nPrivates:{(Privates.Any() ? "\n  " + string.Join("\n  ", Privates) : " None")}";
        }
    }
}
