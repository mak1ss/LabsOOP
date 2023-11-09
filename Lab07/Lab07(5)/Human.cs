using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_5_
{
    internal class Human : Entity
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Human (string name, int age, long id)
        {
            Name = name;
            Age = age;
            base.Id = id;
        }

    }
}
