using System;
using System.Collections.Generic;
using System.Text;

namespace WPF
{
    class EntryForm
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }

        public EntryForm()
        {
            Name = "";
            Address = "";
            ZipCode = 0;
        }

        public EntryForm(string name, string address, int zipCode)
        {
            Name = "";
            Address = "";
            ZipCode = 0;
        }
        
        public override string ToString()
        {
            string sentence = ($"{Name} lives at {Address} with a zipcode of {ZipCode}");
            return sentence;
        }
    }
}
