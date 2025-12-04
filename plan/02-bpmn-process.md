# Milestone 2: BPMN Process Design

## Goal
Create and deploy a simple approval workflow BPMN diagram

## What to Build
- BPMN diagram with: Start Event → User Task (Submit) → User Task (Review) → Gateway → End Events
- Form fields for user tasks
- Gateway conditions for approve/reject paths

## Success Criteria
- [ ] Valid BPMN 2.0 XML file created
- [ ] Process deployed to Camunda 7
- [ ] Process visible in Cockpit
- [ ] Can start process manually from Tasklist
- [ ] Gateway routes correctly based on decision

## Key Hints
- Download Camunda Modeler from camunda.com (free)
- Set process definition key: `approval-process`
- Add form fields in Properties Panel → Forms tab
- Gateway condition example: `#{approved == true}`
- Deploy from Modeler: REST endpoint `http://localhost:8080/engine-rest`
