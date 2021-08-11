using System;
using System.Threading.Tasks;
using TfLConsoleApp1.Controller.Services;

namespace TfLConsoleAppTests.fake
{
    class FakeCustomHttpClient : ICustomHttpClient
    {
        public dynamic getResult = null;
        public Uri getUri = null;

        Task<T> ICustomHttpClient.Get<T>(Uri endpoint)
        {
            getUri = endpoint;
            return Task.FromResult<T>(getResult);
        }
    }
}
