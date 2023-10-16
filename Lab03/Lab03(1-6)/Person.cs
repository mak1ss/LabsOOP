using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab03
{
    using System.Collections.Generic;
    class Family
    {
        private List<Person> members;

        public Family()
        {
            members = new List<Person>();
        }
        public void AddMember(Person member)
        {
            members.Add(member);
        }

        public Person GetOldestMember()
        {

            Person res = members[0];
            foreach (Person p in members)
            {
                if (p.GetAge() > res.GetAge())
                {
                    res = p;
                }
            }
            return res;
        }

        public List<Person> GetFamily()
        {
            return this.members;
        }

    }
    class Person
    {
        private string name = "No name";
        private int age;

        //problem 2
        public Person()
        {           
            age = 1;
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        


        public Person(int age)
        {
            this.age = age;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetAge()
        {
            return this.age;
        }

        public override string ToString()
        {
            return this.GetName() + " " + this.GetAge();
        }
    }
}
