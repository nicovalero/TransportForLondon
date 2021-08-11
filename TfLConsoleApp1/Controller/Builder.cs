using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TfLConsoleApp1.Class;

namespace TfLConsoleApp1.Controller
{
    enum InfrastructureType{
        Road
    }
    class Builder
    {
        public static object Create(InfrastructureType type, string json)
        {
            object obj = null;
            switch (type)
            {
                case InfrastructureType.Road:
                    obj = JsonConvert.DeserializeObject<Road>(json);
                    break;
            }

            return obj;
        }
    }
}
