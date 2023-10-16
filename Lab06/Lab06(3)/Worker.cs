using Lab06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class Worker : Human
    {
        private float weekSalary;
        private byte workingHours;

        public Worker (string firstName, string lastName, float weekSalary, byte workingHours) : base (firstName, lastName)
        {
            WeekSalary = weekSalary;
            WorkingHours = workingHours;
        }

        public float WeekSalary
        {
            get => weekSalary;
            private set => weekSalary = value > 10 ? value : throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
        }

        public byte WorkingHours
        {
            get =>  workingHours;
            private set => workingHours = value >= 1 && value <= 12 ? value : throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
        }
        public float salaryPerHour()
        {
            return weekSalary / 5 / workingHours;
        }

        public override string ToString()
        {   
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(base.ToString())
                .AppendLine($"Week Salary : {weekSalary:f2}")
                .AppendLine($"Hours Per Day : {workingHours}")
                .AppendLine($"Salary Per Hour : {salaryPerHour():f2}");
            return builder.ToString();
        }
    }
}
