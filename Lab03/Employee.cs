using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Employee
    {
        private string name;
        private double salary;
        private string position;
        private string department;
        private string email = "n/a";
        private int age = -1;

        public Employee (string name, double salary, string position, string department, string email, int age)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.email = email;
            this.age = age;
        }
        public Employee(string name, double salary, string position, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
        }

        public string GetName() { return name; }
        public double GetSalary() {  return salary; }
        public string GetPosition() { return position; }
        public string GetDepartment() {  return department; }
        public int GetAge() { return age; }
        public string GetEmail() { return email; }

        public void SetName(string name) { this.name = name;}
        public void SetSalary(double salary) {  this.salary = salary;}
        public void SetPosition(string position) {  this.position = position;}
        public void SetDepartment(string department) {  this.department = department;}
        public void SetEmail(string email) {  this.email = email;}
        public void SetAge(int age) {  this.age = age;}

        public override string ToString()
        {
            return this.name + " " + string.Format("{0 : 0.00}" , this.salary) + " "
                + this.position + " " + this.department + " "
                + this.email + " " + this.age;
        }
    }
}
