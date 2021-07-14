using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Ai.Stations.Services;
using Ai.Stations.Dto;

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
        public ActionResult<List<Feature>> GetStations()
        {
            var service = new StationsService();
            var list = service.GetList();

            if (list.Count == 0)
            {
                Console.WriteLine("List is not populated");
            }

            return list;
        }

        [HttpGet]
        [Route("station/{stationName}")]
        public ActionResult<Feature> GetStation(string stationName)
        {
            var service = new StationsService();
            var feature = service.GetStationByTitle(stationName);

            return feature;
        }
    }
}