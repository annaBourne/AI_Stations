using Microsoft.AspNetCore.Mvc;
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
        private readonly StationsService _service;

        public StationsController(StationsService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("stations")]
        public ActionResult<List<Feature>> GetStations(string filePath)
        {
            var service = new StationsService();
            var list = service.GetList(filePath);

            if (list.Count == 0)
            {
                Console.WriteLine("List is not populated");
            }

            return list;
        }

        [HttpGet]
        [Route("station/{stationName}")]
        public ActionResult<Feature> GetStation(string stationName, string filePath)
        {
            var service = new StationsService();
            var feature = service.GetStationByTitle(stationName, filePath);

            return feature;
        }
    }
}