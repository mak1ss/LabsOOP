using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_
{
    internal class Handler
    {
        public void OnDispatcherNameChange(object sender, NameChangeEventArgs e)
        {
            Console.WriteLine($"Dispatcher’s name changed to {e.Name}");
        }
    }
}
