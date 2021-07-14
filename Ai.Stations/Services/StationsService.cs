using System.Collections.Generic;
using System.IO;
using Ai.Stations.Dto;
using Newtonsoft.Json;

namespace Ai.Stations.Services
{
    public class StationsService
    {
        public List<Feature> GetList(string filepath)
        {
            return JsonConvert.DeserializeObject<Dto.Stations>(File.ReadAllText(filepath))?.Features;
        }

        public Feature GetStationByTitle(string stationName, string filepath)
        {
            var features = GetList(filepath);

            return features.Find(x => x.Properties.Title == stationName);
        }
    }
}

