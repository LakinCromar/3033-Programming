using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon
{
    class PokeAPI
    {
        public Sprites sprites { get; set; }
        public double weight {get; set;}
        public double height { get; set; }


    }
    public class Sprites
    {
        public string front_default { get; set; }

    }
    public class AllPokemonAPI
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<AllPokemonResult> results { get; set; }
    }
    public class AllPokemonResult
    {
        public string name { get; set; }
        public string url { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
    
}
