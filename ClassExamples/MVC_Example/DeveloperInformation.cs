using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Example
{
    public class DeveloperInformation
    {
        public string name { get; set; }
        public DateTime CreationDate { get; set; }
        public DeveloperInformation()
        {
            name = "";
            CreationDate = DateTime.Now;
        }
    }
}