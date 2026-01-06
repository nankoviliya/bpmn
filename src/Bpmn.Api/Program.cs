using FastEndpoints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddHttpClient<CamundaService>();

builder.Services.AddHealthChecks()
    .AddCheck<CamundaHealthCheck>("camunda");

builder.Services.AddFastEndpoints();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/process-definition/{key}", (
    string key,
    CamundaService camundaService,
    CancellationToken cancellationToken) =>
{
    return camundaService.GetProcessDefinitionByKeyAsync(key, cancellationToken);
})
.WithName("GetProcessDefinitionByKey");

app.MapHealthChecks("/healthz");

app.UseFastEndpoints();
app.Run();