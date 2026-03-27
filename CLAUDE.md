# CLAUDE.md — Synthesia SDK

## Overview

Auto-generated C# SDK for [Synthesia](https://www.synthesia.io/) — enterprise AI video generation with speaking avatars, templates, dubbing, translations, webhooks, and audit logs.
OpenAPI spec downloaded from `https://api.synthesia.io/api/openapi/swagger.json`.

## Build & Test

```bash
dotnet build Synthesia.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth:

```csharp
var client = new SynthesiaClient(apiKey); // SYNTHESIA_API_KEY env var
```

## Key Files

- `src/libs/Synthesia/openapi.yaml` — OpenAPI spec (downloaded from Synthesia API)
- `src/libs/Synthesia/generate.sh` — Downloads spec, converts `apiKey` to `http/bearer`, adds top-level security array, runs autosdk
- `src/libs/Synthesia/Generated/` — **Never edit** — auto-generated code
- `src/libs/Synthesia/Extensions/SynthesiaClient.Tools.cs` — MEAI `AIFunction` tools (CreateVideo, CreateVideoFromTemplate, ListTemplates, GetVideo, ListVideos, DeleteVideo)
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Spec Notes

- `generate.sh` converts `apiKey` security scheme to `http/bearer` for AutoSDK constructor generation
- Top-level `security` array injected via `jq`
- Uses `--exclude-deprecated-operations` flag

## Sub-client Pattern

Synthesia API has tagged operations generating sub-clients:
- `client.Videos.*` — Create, get, list, edit, delete videos; thumbnails; XLIFF export
- `client.Templates.*` — List and get video templates
- `client.Assets.*` — Upload and manage media assets
- `client.Webhooks.*` — Create, list, get, delete webhooks
- `client.Dubbing.*` — Create and manage video dubbing projects
- `client.Translations.*` — Translate videos, list languages
- `client.AuditLogs.*` — Query, search, and export audit log events

## Video Creation Workflow

Two-step async pattern:
1. **Create:** `client.Videos.CreateVideosAsync(input, title, test)` -- returns `VideoResponse` with `Id` and `Status`
2. **Poll:** `client.Videos.GetVideosByVideoIdAsync(videoId)` -- check `Status` (`in_progress` -> `complete`), then access `Download` URL

Template-based creation follows the same pattern via `client.Videos.CreateVideosFromTemplateAsync(templateId, templateData)`.

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsCreateVideoTool(avatarId, background, test)` — Create a video from a text script
- `AsCreateVideoFromTemplateTool(test)` — Create a video from a template
- `AsListTemplatesTool(limit)` — List available video templates
- `AsGetVideoTool()` — Get video status and download URL by ID
- `AsListVideosTool(limit)` — List videos in workspace
- `AsDeleteVideoTool()` — Delete a video by ID
