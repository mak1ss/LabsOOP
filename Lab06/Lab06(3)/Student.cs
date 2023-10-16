using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class Student : Human
    {
        private string facultyNumber;
        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get => facultyNumber;
            private set => facultyNumber = value.Length >= 5 && value.Length <= 10 ? value : throw new ArgumentException("Invalid faculty number!");
        }

        public override string ToString()
        {   
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(base.ToString())
                .AppendLine($"Faculty Number : {facultyNumber}");
            return builder.ToString();
        }
    }
}
