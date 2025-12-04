# Milestone 10: Testing & Polish

## Goal
Test complete workflow and add observability

## What to Build
- Complete end-to-end workflow test (submit → review → approve/reject)
- Structured logging in .NET API
- Error handling improvements
- README with setup instructions
- Optional: docker-compose for entire stack

## Success Criteria
- [ ] Can complete full approval workflow without issues
- [ ] Can complete full rejection workflow
- [ ] Errors logged with structured logging
- [ ] Can debug using Camunda Cockpit
- [ ] README documents setup steps

## Key Hints
- Test both approve and reject paths
- Check Cockpit for process instance history
- Add Serilog for structured logging
- Log all Camunda API calls and responses
- Document prerequisites: .NET 10, Node.js, Docker
