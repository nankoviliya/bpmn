# Milestone 5: User Task Operations

## Goal
Fetch user tasks and complete them via API endpoints

## What to Build
- `GET /api/tasks` - List available tasks
- `GET /api/tasks/{taskId}` - Get task details with variables
- `POST /api/tasks/{taskId}/complete` - Complete task with decision

## Success Criteria
- [ ] Can fetch pending tasks from your API
- [ ] Can get task details including process variables
- [ ] Can complete task with approve/reject decision
- [ ] Process advances to correct end state
- [ ] Completed task disappears from pending list

## Key Hints
- Camunda endpoint: `GET /task` with query params
- Get variables: `GET /task/{id}/variables`
- Complete: `POST /task/{id}/complete` with variables
- Decision variable: `{"variables": {"approved": {"value": true, "type": "Boolean"}}}`
- Match variable name in gateway expression
