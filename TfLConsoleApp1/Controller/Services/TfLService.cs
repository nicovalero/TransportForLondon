using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TfLConsoleApp1.Class;

namespace TfLConsoleApp1.Controller.Services
{
    public interface ITfLService
    {
        public Task<List<Road>> GetRoadInformation(string roadName);
    }

    public class TfLService: ITfLService
    {
        private const string _host = "https://api.tfl.gov.uk";
        private ICustomHttpClient _client;

        public TfLService(ICustomHttpClient client)
        {
            _client = client;
        }

        public async Task<List<Road>> GetRoadInformation(string roadName)
        {
            string endpoint = _host + "/Road/" + roadName;
            Uri uri = new Uri(endpoint);
            
            List<Road> response = await _client.Get<List<Road>>(uri);

            return response;
        }
    }
}
