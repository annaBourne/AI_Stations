using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Ai.Stations.Services;

namespace Ai.Stations.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api")]
    public class StationsController : ControllerBase
    {
        private readonly ILogger<StationsController> _logger;
        private readonly StationsService Service;

        public StationsController(ILogger<StationsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("stations")]
        public ActionResult<Dictionary<string, object>> GetStations()
        {
            var stations = new StationsService();
            List<string> List = StationsService.GetList();

            var dictionary = new Dictionary<string, object>();

            foreach (var item in List)
            {
                dictionary.Add(item, item);
            }

            if (List.Count == 0)
            {
                Console.WriteLine("No List");

            }

            return dictionary;
        }

        [HttpGet]
        [Route("station/{?stationName}")]
        public ActionResult<string> GetStation(string stationName)
        {
            var stations = new StationsService();
            var one = StationsService.GetStationByTitle(string.Empty);

            return one;
        }
    }
}