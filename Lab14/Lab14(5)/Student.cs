﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    internal class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }  
        
        public string Email { get; private set; }

        public Student (string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
    }
}
