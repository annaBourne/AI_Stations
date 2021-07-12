using System.Collections.Generic;
using Ai.Stations.Dto;
using Newtonsoft.Json;

namespace Ai.Stations.Services
{
    public class StationsService
    {

        public static List<string> GetList()
        {
            var features = JsonConvert.DeserializeObject<StationsListDto>("@/Data/stations.json");
            

            return new List<string>();
        }

        public static string GetStationByTitle(string stationName)
        {
            //if (!stationName)
            //{

            //    return Getone();
            //}

            return string.Empty;
        }
    }
}

