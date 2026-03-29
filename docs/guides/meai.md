# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Synthesia SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Synthesia's enterprise AI video generation with speaking avatars and templates.

## Installation

```bash
dotnet add package Synthesia
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsCreateVideoTool()` | `CreateVideo` | Creates a video with a speaking avatar from a text script. Returns video ID for status polling. |
| `AsCreateVideoFromTemplateTool()` | `CreateVideoFromTemplate` | Creates a video from a Synthesia template with customizable variables. Returns video ID. |
| `AsListTemplatesTool()` | `ListTemplates` | Lists available video templates with their IDs and variables. |
| `AsGetVideoTool()` | `GetVideo` | Retrieves video status and download URL by ID. |
| `AsListVideosTool()` | `ListVideos` | Lists videos in the workspace with statuses and download URLs. |
| `AsDeleteVideoTool()` | `DeleteVideo` | Deletes a video by its ID. |

## Create Video Tool

Use `AsCreateVideoTool()` to create an `AIFunction` that generates videos from text scripts:

```csharp
using Synthesia;
using Microsoft.Extensions.AI;

var synthesiaClient = new SynthesiaClient(apiKey: Environment.GetEnvironmentVariable("SYNTHESIA_API_KEY")!);

var createVideoTool = synthesiaClient.AsCreateVideoTool(
    avatarId: "anna_costume1_cameraA",
    background: "off_white",
    test: true);

// Use with any IChatClient
IChatClient chatClient = /* your chat client */;
var options = new ChatOptions
{
    Tools = [createVideoTool],
};

var response = await chatClient.GetResponseAsync(
    "Create a video explaining the benefits of renewable energy",
    options);
```

## Create Video from Template Tool

Use `AsCreateVideoFromTemplateTool()` to create videos using predefined templates:

```csharp
var templateTool = synthesiaClient.AsCreateVideoFromTemplateTool(test: true);

var options = new ChatOptions
{
    Tools = [templateTool],
};
```

## List Templates Tool

Use `AsListTemplatesTool()` to discover available templates:

```csharp
var listTemplatesTool = synthesiaClient.AsListTemplatesTool(limit: 10);

var options = new ChatOptions
{
    Tools = [listTemplatesTool],
};
```

## Get Video Status Tool

Use `AsGetVideoTool()` to poll for video completion:

```csharp
var getVideoTool = synthesiaClient.AsGetVideoTool();

var options = new ChatOptions
{
    Tools = [getVideoTool],
};
```

## Combining All Tools

All tools can be used together to give the AI agent full video generation and management capabilities:

```csharp
var options = new ChatOptions
{
    Tools =
    [
        synthesiaClient.AsCreateVideoTool(),
        synthesiaClient.AsCreateVideoFromTemplateTool(),
        synthesiaClient.AsListTemplatesTool(),
        synthesiaClient.AsGetVideoTool(),
        synthesiaClient.AsListVideosTool(),
        synthesiaClient.AsDeleteVideoTool(),
    ],
};
```

## Async Task Pattern

Synthesia video generation is asynchronous. The creation tools (`AsCreateVideoTool`, `AsCreateVideoFromTemplateTool`) return a video ID and initial status. The `AsGetVideoTool` can then be used to poll for completion. Video statuses are:

- `in_progress` -- Video is being generated
- `complete` -- Video is ready, download URL is available
- `approved` -- Video has been approved
- `rejected` -- Video has been rejected
- `error` -- Video generation failed
- `deleted` -- Video has been deleted
