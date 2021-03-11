using Newtonsoft.Json;

namespace new_apns_tests
{
    public class AppleNotification
    {
        public class ApsPayload
        {
            [JsonProperty("alert")]
            public string AlertBody { get; set; }
        }

        // Your custom properties as needed

        [JsonProperty("aps")]
        public ApsPayload Aps { get; set; }
    }
}
