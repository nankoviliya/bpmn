public class CamundaService
{
    private readonly HttpClient _httpClient;

    public CamundaService(
        HttpClient httpClient,
        IConfiguration configuration)
    {
        _httpClient = httpClient;

        var camundaBaseUrl = configuration["CamundaBaseUrl"];
        _httpClient.BaseAddress = new Uri(camundaBaseUrl);
    }

    public async Task<string> GetProcessDefinitionByKeyAsync(string key, CancellationToken ct)
    {
        return await _httpClient.GetStringAsync($"process-definition/key/{key}", ct);
    }

    public async Task<HttpResponseMessage> GetCamundaEngineStatus(CancellationToken ct)
    {
        return await _httpClient.GetAsync("engine", ct);
    }
}