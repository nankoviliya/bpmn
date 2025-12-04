# Milestone 9: Task Completion Form

## Goal
Build form to approve or reject tasks

## What to Build
- Task detail view showing all process variables
- Approve and Reject buttons
- Optional comment field
- Submit handler completing task via API
- Navigation back to task list

## Success Criteria
- [ ] Can view task with full context (all variables)
- [ ] Can approve or reject request
- [ ] Process advances to correct end state
- [ ] UI navigates back to task list
- [ ] Completed task no longer appears in list

## Key Hints
- Fetch task details on component mount
- Pre-fill form with current process variables
- Set `approved` variable to true/false
- Add optional `comment` variable
- Show confirmation dialog before submit
