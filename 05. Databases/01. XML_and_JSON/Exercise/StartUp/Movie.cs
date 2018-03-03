using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StartUp
{
    public class Movie
    {
        public string Name { get; set; }
        
        public string Genre { get; set; }
        
        public string Director { get; set; }
        
        [JsonProperty("cast")]
        public IList<string> Actors { get; set; }
        
    }
}
