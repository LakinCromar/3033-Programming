﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_JSON
{
    class RickMortyAPI
    {
        //2 properties 
        public InfoObject info { get; set; }
        public List<ResultObject> results { get; set; }

    }
    public class InfoObject
    {
        public int count { get; set; }
        public int pages { get; set; }
        public string next { get; set; }
        public string prev { get; set; }

    }

    public class ResultObject
    {
        public int id { get; set; }

        public string name { get; set; }
        public string staus { get; set; }
        public string species { get; set; }
        public string gender { get; set; }
        public string image { get; set; }
        public string url { get; set;  }
    public override string ToString()
    {
        return $"({id}) {name}";
    }
    }
    
}
