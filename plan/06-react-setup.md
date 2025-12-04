# Milestone 6: React Frontend Setup

## Goal
Create React app with Vite, hosted by ASP.NET Core

## What to Build
- React + Vite app in `ClientApp` or `frontend` subfolder
- Proxy configuration for dev mode
- ASP.NET Core static file serving for production
- Basic routing with React Router
- API client setup (axios)

## Success Criteria
- [ ] React dev server runs with hot reload
- [ ] Can call .NET API from React
- [ ] Proxy works in development
- [ ] Production build served by ASP.NET Core
- [ ] React Router navigation works

## Key Hints
- Create with: `npm create vite@latest` (React + TypeScript)
- Proxy in vite.config.ts: target .NET API port
- In Program.cs: `UseStaticFiles()` + `UseSpa()`
- Create axios instance with base URL
- Install React Router: `npm install react-router-dom`
