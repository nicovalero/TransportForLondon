using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using TfLConsoleApp1.Class;
using TfLConsoleApp1.Controller;
using System.Collections.Generic;
using TfLConsoleAppTests.fake;

namespace TfLConsoleAppTests
{
    [TestClass]
    public class RequestControllerTests
    {
        private FakeTflService service;
        private RequestController underTest;

        [TestInitialize]
        public void Setup()
        {
            service = new FakeTflService();
            underTest = new RequestController(service);
        }

        [TestMethod]
        public async Task NullIsRetrieved_WHEN_serviceReturnsNull()
        {
            string RoadName = "londonRoad";
            service.GetRoadInformationResult = null;

            var result = await underTest.GetRoadInformation(RoadName);

            Assert.IsNull(result);
        }

        [TestMethod]
        public async Task NullIsRetrieved_WHEN_serviceSuccess_AND_roadNameIsNotFound()
        {
            string RoadName = "londonRoad";
            List<Road> expectedRoads = new List<Road>();
            expectedRoads.Add(new Road());
            expectedRoads.Add(new Road());
            service.GetRoadInformationResult = expectedRoads;

            var result = await underTest.GetRoadInformation(RoadName);

            Assert.IsNull(result);
        }


        [TestMethod]
        public async Task RoadIsNotNull_WHEN_roadNameMatchesWithOneIdFromTheRetrievedList()
        {
            string RoadName = "londonRoad";
            Road expectedRoad = new Road();
            expectedRoad.id = RoadName;
            List<Road> expectedRoads = new List<Road>();
            expectedRoads.Add(expectedRoad);
            expectedRoads.Add(new Road());
            service.GetRoadInformationResult = expectedRoads;

            var result = await underTest.GetRoadInformation(RoadName);

            Assert.AreEqual(expectedRoad, result);
            Assert.AreEqual(RoadName, service.GetRoadInformationRoadName);
        }
    }

}
