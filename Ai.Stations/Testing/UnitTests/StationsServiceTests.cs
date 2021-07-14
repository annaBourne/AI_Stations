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
        public void ServiceReturnsCorrectResponse()
        {
            const string filePath = @"Testing/Resources/test.json";
            _stationsServiceMock = new StationsService();
            var result = _stationsServiceMock.GetList(filePath);
            
            Assert.That(result, Is.TypeOf<List<Feature>>());
            Assert.That(result.Count == 2);
            Assert.That(result.First().Properties.Title, Is.EqualTo("Southern Ave"));
        }
    }
}