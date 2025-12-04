# Milestone 7: Process Initiation Form

## Goal
Build React form to start new approval requests

## What to Build
- Form component with fields: title, description, amount, requestor
- Form validation
- Submit handler calling backend API
- Success/error feedback

## Success Criteria
- [ ] User can fill out and submit form
- [ ] Process starts in Camunda (verify in Cockpit)
- [ ] User receives confirmation with process instance ID
- [ ] Form handles errors gracefully
- [ ] Loading state during submission

## Key Hints
- Start with controlled components (useState)
- Consider React Hook Form or Formik for validation
- Display process instance ID after successful start
- Show loading spinner during API call
- Clear form after successful submission
