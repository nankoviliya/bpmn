# Milestone 3: ASP.NET Core API Setup

## Goal
Create .NET API project and establish connection to Camunda

## What to Build
- ASP.NET Core 10 Web API project
- HttpClient configuration for Camunda REST API
- Configuration in appsettings.json
- Health check endpoint

## Success Criteria
- [x] API project created with `dotnet new webapi`
- [x] Can make HTTP calls to Camunda REST API
- [x] Health endpoint returns Camunda engine status
- [x] Configuration externalized to appsettings.json

## Key Hints
- Use IHttpClientFactory for Camunda HTTP calls
- Create service interface: `ICamundaService`
- Store Camunda base URL: `http://localhost:8080/engine-rest`
- Test with GET to `/engine` endpoint
- Add typed HttpClient registration for cleaner DI
