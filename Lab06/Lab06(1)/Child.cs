using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    public class Child : Person
    {
        public override int Age
        {
            get => base.Age;
            protected set => base.Age = value < 15 ? value : throw new ArgumentException("Child's age must be less than 15!");
        }
        public Child(string name, int age) : base(name, age)
        {

        }
    }
}
