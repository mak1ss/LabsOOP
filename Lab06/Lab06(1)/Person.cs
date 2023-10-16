using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    public class Person
    {
        protected string name;
        protected int age;
        public virtual string Name
        {
            get => name;
            protected set => name = name.Length > 3 ? value : throw new ArgumentException("Name's length should not be less than 3 symbols");
        }
        public virtual int Age
        {
            get => age;
            protected set => age = age > 0 ? value : throw new ArgumentException("Age must be positive");
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(String.Format("Name: {0}, Age: {1}", Name, Age));
            return builder.ToString();
        }
    }
}
