using Newtonsoft.Json;
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
    public class RequestController
    {
        private ITfLService _tflService;

        public RequestController(ITfLService tflService)
        {
            _tflService = tflService;
        }
        
        public async Task<Road> GetRoadInformation(string roadName)
        {
            List<Road> list = await _tflService.GetRoadInformation(roadName);

            if (list != null)
                return list.Where(n => n.id == roadName).FirstOrDefault();
            else
                return null;
        }

    }
}
