using System.Collections.Generic;
using System.Threading.Tasks;
using TfLConsoleApp1.Class;
using TfLConsoleApp1.Controller.Services;

namespace TfLConsoleAppTests.fake
{
    public class FakeTflService : ITfLService
    {
        public List<Road> GetRoadInformationResult = null;
        public string GetRoadInformationRoadName = null;

        Task<List<Road>> ITfLService.GetRoadInformation(string roadName)
        {
            GetRoadInformationRoadName = roadName;
            return Task.FromResult(GetRoadInformationResult);
        }
    }
}
