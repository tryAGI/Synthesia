namespace Synthesia.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static SynthesiaClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("SYNTHESIA_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("SYNTHESIA_API_KEY environment variable is not found.");

        var client = new SynthesiaClient(apiKey);
        
        return client;
    }
}
