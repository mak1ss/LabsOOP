using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_7_
{
    internal class Rebel : IBuyer
    {
        public string Name { get; set; }

        public int Age { get; private set; }
        public string Group { get; private set; }
        public int Food { get; set; }

        public Rebel (string name, string group, int age)
        {
            this.Name = name;
            this.Group = group;
            this.Age = Age;
        }

        public void BuyFood()
        {
            Food += 5;
        }

    }
}
