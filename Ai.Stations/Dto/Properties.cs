using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ai.Stations.Dto
{
    public class Properties
    {
        public string Description { get; set; }
        
        [JsonProperty("marker-symbol")]
        public string MarkerSymbol { get; set; }
        
        public string Title { get; set; }
        public string Url { get; set; }
        public List<string> Lines { get; set; }
        public string Address { get; set; }
    }
}