using System.Collections.Generic;
using Ai.Stations.Controllers;
using Ai.Stations.Dto;
using Ai.Stations.Services;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;

namespace Ai.Stations.Testing.IntegrationTests
{
    [TestFixture]
    public class StationsControllerTests
    {
        //[SetUp]
        public void SetUp()
        {
            var stationsControllerMock = new Mock<StationsController>();
            var stationsServiceMock = new Mock<StationsService>();
            const string filePath = "@/Testing/Resources/test.json";

            stationsServiceMock.Setup(x => x.GetList(filePath))
                .Returns<List<Feature>>(x => x);
            
        }
    }
}