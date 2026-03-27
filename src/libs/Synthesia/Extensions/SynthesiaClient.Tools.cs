using System.Text.Json;
using Microsoft.Extensions.AI;

namespace Synthesia;

/// <summary>
/// Extensions for using SynthesiaClient as MEAI tools with any IChatClient.
/// </summary>
public static class SynthesiaToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that creates a video from a script/text
    /// using the Synthesia API. Returns the video ID and status for polling.
    /// </summary>
    /// <param name="client">The Synthesia client to use for video creation.</param>
    /// <param name="avatarId">Avatar ID to use (default: anna_costume1_cameraA).</param>
    /// <param name="background">Background to use (default: off_white).</param>
    /// <param name="test">Whether to create a test video with watermark (default: true).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsCreateVideoTool(
        this SynthesiaClient client,
        string avatarId = "anna_costume1_cameraA",
        string background = "off_white",
        bool test = true)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string scriptText, string? title, string? description, CancellationToken cancellationToken) =>
            {
                var response = await client.Videos.CreateVideosAsync(
                    input:
                    [
                        new Input
                        {
                            Avatar = avatarId,
                            Background = background,
                            ScriptText = scriptText,
                        },
                    ],
                    title: title,
                    description: description,
                    test: test,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatVideoResponse(response);
            },
            name: "CreateVideo",
            description: "Creates an AI-generated video with a speaking avatar from a text script using Synthesia. Provide the script text for the avatar to speak. Optionally set a title and description. Returns the video ID and status for polling.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that creates a video from a template
    /// using the Synthesia API. Returns the video ID and status for polling.
    /// </summary>
    /// <param name="client">The Synthesia client to use for video creation.</param>
    /// <param name="test">Whether to create a test video with watermark (default: true).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsCreateVideoFromTemplateTool(
        this SynthesiaClient client,
        bool test = true)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string templateId, string? templateDataJson, string? title, string? description, CancellationToken cancellationToken) =>
            {
                object templateData = templateDataJson is not null
                    ? JsonSerializer.Deserialize<Dictionary<string, object>>(templateDataJson) ?? new Dictionary<string, object>()
                    : new Dictionary<string, object>();

                var response = await client.Videos.CreateVideosFromTemplateAsync(
                    templateId: Guid.Parse(templateId),
                    templateData: templateData,
                    title: title,
                    description: description,
                    test: test,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatVideoResponse(response);
            },
            name: "CreateVideoFromTemplate",
            description: "Creates an AI-generated video based on a Synthesia template. Provide the template ID and optional template data as a JSON string with variable key-value pairs. Returns the video ID and status for polling.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists available video templates
    /// in the Synthesia workspace.
    /// </summary>
    /// <param name="client">The Synthesia client to use.</param>
    /// <param name="limit">Maximum number of templates to return (default: 10).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListTemplatesTool(
        this SynthesiaClient client,
        int limit = 10)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Templates.GetTemplatesAsync(
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatTemplateListResponse(response);
            },
            name: "ListTemplates",
            description: "Lists available video templates in the Synthesia workspace. Returns template IDs, titles, and available variables for customization.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves the status and details
    /// of a video by its ID. Use this to poll for video completion.
    /// </summary>
    /// <param name="client">The Synthesia client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetVideoTool(this SynthesiaClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string videoId, CancellationToken cancellationToken) =>
            {
                var response = await client.Videos.GetVideosByVideoIdAsync(
                    videoId: videoId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatVideoResponse(response);
            },
            name: "GetVideo",
            description: "Retrieves the status and details of a Synthesia video by its ID. Returns the video status (in_progress, complete, error) and download URL when ready.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists videos in the Synthesia workspace.
    /// </summary>
    /// <param name="client">The Synthesia client to use.</param>
    /// <param name="limit">Maximum number of videos to return (default: 10).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListVideosTool(
        this SynthesiaClient client,
        int limit = 10)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Videos.GetVideosAsync(
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatVideoListResponse(response);
            },
            name: "ListVideos",
            description: "Lists videos in the Synthesia workspace. Returns video IDs, titles, statuses, and download URLs for completed videos.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that deletes a video by its ID.
    /// </summary>
    /// <param name="client">The Synthesia client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsDeleteVideoTool(this SynthesiaClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string videoId, CancellationToken cancellationToken) =>
            {
                await client.Videos.DeleteVideosByVideoIdAsync(
                    videoId: videoId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return $"Video {videoId} deleted successfully.";
            },
            name: "DeleteVideo",
            description: "Deletes a Synthesia video by its ID. This action is irreversible.");
    }

    private static string FormatVideoResponse(VideoResponse response)
    {
        var parts = new List<string>();

        if (response.Id is { } id)
        {
            parts.Add($"Video ID: {id}");
        }
        if (response.Status is { } status)
        {
            parts.Add($"Status: {status.ToValueString()}");
        }
        if (!string.IsNullOrWhiteSpace(response.Title))
        {
            parts.Add($"Title: {response.Title}");
        }
        if (!string.IsNullOrWhiteSpace(response.Duration))
        {
            parts.Add($"Duration: {response.Duration}");
        }
        if (response.Status == VideoResponseStatus.Complete && !string.IsNullOrWhiteSpace(response.Download))
        {
            parts.Add($"Download: {response.Download}");
        }

        return string.Join("\n", parts);
    }

    private static string FormatTemplateListResponse(TemplateListResponse response)
    {
        var parts = new List<string>();

        if (response.Templates is { Count: > 0 })
        {
            parts.Add($"Templates ({response.Templates.Count}):");
            foreach (var template in response.Templates)
            {
                var entry = $"- ID: {template.TemplateId}";
                if (!string.IsNullOrWhiteSpace(template.Title))
                {
                    entry += $", Title: {template.Title}";
                }
                if (template.Variables is { Count: > 0 })
                {
                    entry += $", Variables: {template.Variables.Count}";
                }
                parts.Add(entry);
            }
        }
        else
        {
            parts.Add("No templates found.");
        }

        return string.Join("\n", parts);
    }

    private static string FormatVideoListResponse(VideoListResponse response)
    {
        var parts = new List<string>();

        if (response.Videos is { Count: > 0 })
        {
            parts.Add($"Videos ({response.Videos.Count}):");
            foreach (var video in response.Videos)
            {
                var entry = $"- ID: {video.Id}";
                if (!string.IsNullOrWhiteSpace(video.Title))
                {
                    entry += $", Title: {video.Title}";
                }
                if (video.Status is { } status)
                {
                    entry += $", Status: {status.ToValueString()}";
                }
                if (video.Status == VideoResponseStatus.Complete && !string.IsNullOrWhiteSpace(video.Download))
                {
                    entry += $", Download: {video.Download}";
                }
                parts.Add(entry);
            }
        }
        else
        {
            parts.Add("No videos found.");
        }

        return string.Join("\n", parts);
    }
}
