namespace StepFun.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static StepFunClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("STEP_API_KEY") is { Length: > 0 } stepKeyValue
                ? stepKeyValue
                : Environment.GetEnvironmentVariable("STEPFUN_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("STEP_API_KEY or STEPFUN_API_KEY environment variable is not found.");

        var client = new StepFunClient(apiKey);
        
        return client;
    }
}
