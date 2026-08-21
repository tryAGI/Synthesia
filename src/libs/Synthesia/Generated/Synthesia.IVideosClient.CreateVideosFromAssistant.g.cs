#nullable enable

namespace Synthesia
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Create a video from a prompt and PDFs via the Assistant<br/>
        /// Pilot endpoint. Accepts a text prompt and up to 5 PDFs (multipart/form-data) and returns a videoId and embed code immediately. Supply each PDF either inline by repeating the `file` field (6 MB total request body) or as a short-lived presigned URL by repeating the `fileUrl` field (https only, no size limit). The two forms cannot be mixed. The video is generated and published asynchronously by the Assistant. An optional `duration` field (`short`, `medium` or `long`; defaults to `medium`) sizes the video to roughly 1, 2 or 5 minutes respectively. An optional `motionGraphics` field (`brief` or `comprehensive`) selects the richness of the video's motion graphics; `comprehensive` produces richer graphics but takes longer to render.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Synthesia.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateVideosFromAssistantAsync(
            global::Synthesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a video from a prompt and PDFs via the Assistant<br/>
        /// Pilot endpoint. Accepts a text prompt and up to 5 PDFs (multipart/form-data) and returns a videoId and embed code immediately. Supply each PDF either inline by repeating the `file` field (6 MB total request body) or as a short-lived presigned URL by repeating the `fileUrl` field (https only, no size limit). The two forms cannot be mixed. The video is generated and published asynchronously by the Assistant. An optional `duration` field (`short`, `medium` or `long`; defaults to `medium`) sizes the video to roughly 1, 2 or 5 minutes respectively. An optional `motionGraphics` field (`brief` or `comprehensive`) selects the richness of the video's motion graphics; `comprehensive` produces richer graphics but takes longer to render.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Synthesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Synthesia.AutoSDKHttpResponse> CreateVideosFromAssistantAsResponseAsync(
            global::Synthesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}