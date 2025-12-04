# Milestone 8: Task List View

## Goal
Display list of pending user tasks from Camunda

## What to Build
- Task list component fetching tasks from API
- Display task name, created date, and key variables
- Click handler to navigate to task details
- Auto-refresh or polling mechanism

## Success Criteria
- [ ] Can see list of pending tasks
- [ ] Tasks show relevant info (title, requestor, amount)
- [ ] Can click task to open details
- [ ] List updates when tasks are completed

## Key Hints
- Start with simple polling (refresh every 5 seconds)
- Use useEffect with setInterval for polling
- Display key process variables
- Use React Router Link for navigation
- Consider filtering by assignee later
