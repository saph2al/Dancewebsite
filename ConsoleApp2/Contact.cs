using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Contact
    {
        public Contact(string Name, string Number)
        {
            name = Name;
            number = Number;
        }

        public string name { get; set; }
        public string number { get; set; }
    }
}
