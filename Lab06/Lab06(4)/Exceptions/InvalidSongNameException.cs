﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_4_.Exceptions
{
    public class InvalidSongNameException : InvalidSongException
    {
        public InvalidSongNameException()
        {

        }
        public InvalidSongNameException(string message) : base(message)
        {

        }
    }

}
