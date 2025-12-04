# Milestone 4: Process Instance Management

## Goal
Start process instances from API and query their status

## What to Build
- `POST /api/processes/start` - Start new approval request
- `GET /api/processes/{instanceId}` - Get process details
- DTOs for request/response models

## Success Criteria
- [ ] Can start process from your API
- [ ] Process instance appears in Cockpit
- [ ] Variables passed correctly to process
- [ ] Can retrieve process status via API

## Key Hints
- Camunda endpoint: `POST /process-definition/key/{key}/start`
- Variable format: `{"variables": {"title": {"value": "Test", "type": "String"}}}`
- Store process key in appsettings.json
- Query with: `GET /process-instance/{id}`
- Get variables: `GET /process-instance/{id}/variables`
