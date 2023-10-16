using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab06
{
    public class Human
    {
        protected string firstName;
        protected string lastName;

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;

        }

        public virtual string FirstName
        {
            get => firstName;
            private set
            {
                if (value.Length <= 3)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }
                if (!Regex.IsMatch(value, @"^[A-Z]"))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }
                firstName = value;
            }
        }

        public virtual string LastName
        {
            get => lastName;
            private set
            {
                if (value.Length <= 2)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }
                if (!Regex.IsMatch(value, @"^[A-Z]"))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }
                lastName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"First Name : {firstName}")
                .AppendLine($"Last Name : {lastName}");
            return builder.ToString();
        }
    }
}
