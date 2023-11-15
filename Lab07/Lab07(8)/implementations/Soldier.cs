using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab07_8_.interfaces;

namespace Lab07_8_.implementations
{
    internal class Soldier : ISoldier
    {
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }

        public Soldier(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{GetType().Name} {Id} {FirstName} {LastName}";
        }
    }
}
