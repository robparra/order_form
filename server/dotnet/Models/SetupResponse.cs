
using Newtonsoft.Json;

public class SetupResponse
{
    [JsonProperty("publishableKey")]
    public string PublishableKey { get; set; }

    [JsonProperty("proPrice")]
    public string ProPrice { get; set; }

    [JsonProperty("mediumPrice")]
    public string MediumPrice { get; set; }

    [JsonProperty("basicPrice")]
    public string BasicPrice { get; set; }
}
