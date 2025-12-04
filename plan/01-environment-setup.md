# Milestone 1: Environment Setup

## Goal
Get Camunda 7 running in Docker with accessible web apps and REST API

## What to Build
- `docker-compose.yml` for Camunda BPM Platform 7
- Verify Cockpit, Tasklist, and REST API are accessible

## Success Criteria
- [ ] Camunda Cockpit accessible at http://localhost:8080/camunda
- [ ] Camunda Tasklist accessible at http://localhost:8080/camunda/app/tasklist
- [ ] Can login with default credentials (demo/demo)
- [ ] REST API responds at http://localhost:8080/engine-rest/engine

## Key Hints
- Use official Docker image: `camunda/camunda-bpm-platform:latest`
- H2 database is fine for learning (embedded)
- Expose port 8080
- No additional environment variables needed for basic setup
- Test REST API with: `curl http://localhost:8080/engine-rest/engine`
