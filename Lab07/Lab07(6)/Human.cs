using Lab07_6_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_5_
{
    internal class Human : IEntity, IIdentifiable
    {
        public string Name { get; set; }
        public string Birthdate { get; set; }
        public long Id { get; set; }
        public int Age { get; private set; }

        public Human (string name, int age, long id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

    }
}
