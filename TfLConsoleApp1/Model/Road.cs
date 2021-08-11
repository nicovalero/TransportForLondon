using Newtonsoft.Json;

namespace TfLConsoleApp1.Class
{
    public class Road
    {
        [System.Runtime.Serialization.DataMember(Name ="$type")]
        public string type { get; set; }

        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("displayName")]
        public string displayName { get; set; }

        [JsonProperty("statusSeverity")]
        public string statusSeverity { get; set; }

        [JsonProperty("statusSeverityDescription")]
        public string statusSeverityDescription { get; set; }

        [JsonProperty("bounds")]
        public string bounds { get; set; }

        [JsonProperty("envelope")]
        public string envelope { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }
    }
}
