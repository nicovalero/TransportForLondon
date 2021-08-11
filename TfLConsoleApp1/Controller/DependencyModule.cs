using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TfLConsoleApp1.Class;
using TfLConsoleApp1.Controller.Services;

namespace TfLConsoleApp1.Controller
{
    public static class DependencyModule
    {
        
        private static HttpClient _httpClient = new HttpClient();

        public static CustomHttpClient MakeCustomHttpClient()
        {
            return new CustomHttpClient(_httpClient);
        }

        public static ITfLService MakeTflService()
        {
            return new TfLService(MakeCustomHttpClient());
        }

        public static Terminal MakeTerminal()
        {
            return new Terminal(MakeRequestController());
        }

        public static RequestController MakeRequestController()
        {
            return new RequestController(MakeTflService());
        }
    }
}
