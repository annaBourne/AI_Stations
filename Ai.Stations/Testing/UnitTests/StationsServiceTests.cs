using System.Collections.Generic;
using System.Linq;
using Ai.Stations.Dto;
using Ai.Stations.Services;
using NUnit.Framework;

namespace Ai.Stations.Testing.UnitTests
{
    [TestFixture]
    public class StationsServiceTests
    {
        private static StationsService _stationsServiceMock;

        [Test]
        public void ServiceReturnsCorrectResponseToGetList()
        {
            _stationsServiceMock = new StationsService();
            var result = _stationsServiceMock.GetList();
            
            Assert.That(result, Is.TypeOf<List<Feature>>());
            Assert.That(result.Count == 91);
            Assert.That(result.First().Properties.Title, Is.EqualTo("Southern Ave"));
        }

        [Test]
        [TestCase("Southern Ave")]
        public void ServiceReturnsCorrectResponseToGetStationByTitle(string stationName)
        {
            _stationsServiceMock = new StationsService();
            
            var result = _stationsServiceMock.GetStationByTitle(stationName);
            
            Assert.That(result, Is.TypeOf<Feature>());
            Assert.That(result.Properties.Title, Is.EqualTo(stationName));
        }
    }
}