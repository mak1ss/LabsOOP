using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    using System;

    public class Chicken
    {
        private int age;
        private string name;
        private int productPerDay;
        public Chicken(int age, string name)
        {
            SetAge(age);
            SetName(name);
            CalcProductPerDay();
        }

        private void SetAge(int age)
        {
            if (age <= 0 || age > 15)
            {
                throw new ArgumentException("Age should be between 0 and 15");
            }
            this.age = age;
        }

        private void SetName(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name should be not empty");
            }
            this.name = name;
        }
        public int GetAge()
        {
            return age;
        }
        public string GetName()
        {
            return name;
        }

        public int GetProductPerDay()
        {
            return productPerDay;
        }
        private void CalcProductPerDay()
        {
            productPerDay = (int)(age * 0.2);
        }

        public override string ToString()
        {
            return String.Format("Chicken {0} (age {1}) can produce {2} eggs per day.", name, age, productPerDay);
        }
    }
    public class Program
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Chicken chicken = null;
            try
            {
                chicken = new Chicken(age, name);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            if (chicken != null)
            {
                Console.WriteLine(chicken.ToString());
            }
        }
    }
}
