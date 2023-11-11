using Lab07_5_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_6_
{
    internal class Pet : IEntity
    {
        public string Name { get; set; }
        public string Birthdate { get; set; }

        public long Id { get; set; }

        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }
    }
}
