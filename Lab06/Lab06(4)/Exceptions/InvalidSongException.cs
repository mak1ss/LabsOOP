using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_4_.Exceptions
{
    public class InvalidSongException : Exception
    {
        public InvalidSongException()
        {

        }
        public InvalidSongException(string message) : base(message)
        {
        }
    }
}
