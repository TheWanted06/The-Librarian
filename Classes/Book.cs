using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing.Classes
{
    class Book
    {
        public int CallNumber { get; set; }
        public string Description { get; set; }

        public Book() { }
        public Book(int callNumber, string description)
        {
            CallNumber = callNumber;
            Description = description;
        }

    }
}
