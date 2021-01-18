
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

    [JsonProperty("SocialproPrice")]
    public string SocialProPrice { get; set; }

    [JsonProperty("SocialmediumPrice")]
    public string SocialMediumPrice { get; set; }

    [JsonProperty("SocialbasicPrice")]
    public string SocialBasicPrice { get; set; }

    [JsonProperty("ExpoproPrice")]
    public string ExpoProPrice { get; set; }

    [JsonProperty("ExpomediumPrice")]
    public string MediumPrice { get; set; }

    [JsonProperty("ExpobasicPrice")]
    public string ExpoBasicPrice { get; set; }

    [JsonProperty("MarketproPrice")]
    public string MarketProPrice { get; set; }

    [JsonProperty("MarketmediumPrice")]
    public string MarketMediumPrice { get; set; }

    [JsonProperty("MarketbasicPrice")]
    public string MarketBasicPrice { get; set; }
}
