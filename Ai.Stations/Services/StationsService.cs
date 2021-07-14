using System.Collections.Generic;
using Ai.Stations.Dto;
using Newtonsoft.Json;

namespace Ai.Stations.Services
{
    public class StationsService
    {
        public List<Feature> GetList()
        {
            return JsonConvert.DeserializeObject<Dto.Stations>("@/Data/stations.json")?.Features;
        }

        public Feature GetStationByTitle(string stationName)
        {
            var features = GetList();

            return features.Find(x => x.Properties.Title == stationName);
        }
    }
}

