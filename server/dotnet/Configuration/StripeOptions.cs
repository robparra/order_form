public class StripeOptions
{
    public string PublishableKey { get; set; }
    public string SecretKey { get; set; }
    public string WebhookSecret { get; set; }

    public string BasicPrice { get; set; }
    public string MediumPrice { get; set; }
    public string ProPrice { get; set; }

    // SOCIAL
    public string SocialBasicPrice { get; set; }
    public string SocialMediumPrice { get; set; }
    public string SocialProPrice { get; set; }
    // EXPO
    public string ExpoBasicPrice { get; set; }
    public string ExpoMediumPrice { get; set; }
    public string ExpoProPrice { get; set; }
    // MARKET
    public string MarketBasicPrice { get; set; }
    public string MarketMediumPrice { get; set; }
    public string MarketProPrice { get; set; }
    public string Domain { get; set; }
}
