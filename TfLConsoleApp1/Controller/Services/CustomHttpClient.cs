using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TfLConsoleApp1.Controller.Services
{
    public interface ICustomHttpClient
    {
        public Task<T> Get<T>(Uri endpoint);
    }
    public class CustomHttpClient: ICustomHttpClient
    {
        private HttpClient _client;

        public CustomHttpClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<T> Get<T>(Uri endpoint)
        {
            var response = await _client.GetAsync(endpoint);
           
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                T obj = JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
                return obj;
            }

            return default;
        }
    }
}
