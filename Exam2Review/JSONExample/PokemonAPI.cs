using System;
using System.Collections.Generic;
using System.Text;

namespace JSONExample
{
    class PokemonAPI
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<PokeResults> results {get; set;}
    }
    class PokeResults
    {
        public string name { get; set; }
        public string url { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
}
