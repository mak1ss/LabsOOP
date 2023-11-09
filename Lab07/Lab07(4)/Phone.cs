using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab07_4_
{
    internal class Phone : ICallable, IBrowsable
    {
        public void Call(string phoneNumber)
        {
            if (Regex.IsMatch(phoneNumber, @"[a-zA-Z]")) 
            {
                throw new ArgumentException("Invalid number!");
            }
            Console.WriteLine($"Calling...{phoneNumber}");
        }

        public void Browse(string siteName)
        {
            if (Regex.IsMatch(siteName, @"[0-9]"))
            {
                throw new ArgumentException("Invalid URL!");
            }
            Console.WriteLine($"Browsing... {siteName}");
        }
    }
}
