using Lab_02_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    internal class Citizen : IPerson, IBirthable, IIdentifiable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string BirthDate { get; set; }
        public string Id { get; set; }
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthdate;
        }
    }
}
