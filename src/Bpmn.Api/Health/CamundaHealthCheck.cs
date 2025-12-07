using Microsoft.Extensions.Diagnostics.HealthChecks;
public class CamundaHealthCheck : IHealthCheck
{
    private readonly CamundaService _camundaService;

    public CamundaHealthCheck(CamundaService camundaService) => _camundaService = camundaService;

    public async Task<HealthCheckResult> CheckHealthAsync(
        HealthCheckContext context,
        CancellationToken ct = default)
    {
        try
        {
            var response = await _camundaService.GetCamundaEngineStatus(ct);
            return response.IsSuccessStatusCode
                ? HealthCheckResult.Healthy("Camunda is running")
                : HealthCheckResult.Unhealthy($"Status: {response.StatusCode}");
        }
        catch (Exception ex)
        {
            return HealthCheckResult.Unhealthy(ex.Message);
        }
    }
}