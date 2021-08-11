using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TfLConsoleApp1.Class;
using TfLConsoleApp1.Controller.Services;
using TfLConsoleAppTests.fake;

namespace TfLConsoleAppTests
{
    [TestClass]
    public class TfLServiceTests
    {
        private FakeCustomHttpClient customHttpClient;
        TfLService underTest;

        [TestInitialize]
        public void Setup()
        {
            customHttpClient = new FakeCustomHttpClient();
            underTest = new TfLService(customHttpClient);
        }

        [TestMethod]
        public async Task NullIsRetrieved_WHEN_clientReturnsNull()
        {
            string roadName = "any";
            customHttpClient.getResult = null;

            List<Road> result = await underTest.GetRoadInformation(roadName);

            Assert.IsNull(result);
        }

        [TestMethod]
        public async Task ListIsRetrieved_WHEN_clientIsSuccessful()
        {
            string roadName = "a2";
            List<Road> clientResultRoads = new List<Road>();
            clientResultRoads.Add(new Road());
            customHttpClient.getResult = clientResultRoads;

            List<Road> result = await underTest.GetRoadInformation(roadName);

            Assert.AreEqual(clientResultRoads, result);
        }

        [TestMethod]
        public async Task ExpectedEndpoint_WHEN_clientCallsGet()
        {
            string roadName = "a2";
            Uri uri = new Uri("https://api.tfl.gov.uk/Road/a2");
            customHttpClient.getUri = uri;

            await underTest.GetRoadInformation(roadName);

            Assert.AreEqual(uri, customHttpClient.getUri);
        }
    }
}
