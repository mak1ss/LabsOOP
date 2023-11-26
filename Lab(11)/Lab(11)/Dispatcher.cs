using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_
{
    public delegate void OnNameChangeEventHandler(object sender, NameChangeEventArgs e);
    internal class Dispatcher
    {
        private string name;
        public string Name
        {
            get => name;
            set
            {      
                name = value;
                OnNameChanged(new NameChangeEventArgs(Name));
            }
        }
        public event OnNameChangeEventHandler NameChange;
        private void OnNameChanged(NameChangeEventArgs e)
        {
            if( NameChange != null )
            {
                NameChange.Invoke(this, e);
            }
        }
    }
}
