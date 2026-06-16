#nullable enable

namespace Synthesia
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Create a video from a prompt and a PDF via the Assistant<br/>
        /// Pilot endpoint. Accepts a text prompt and a single PDF (multipart/form-data, max 6 MB) and returns a videoId and embed code immediately. The video is generated and published asynchronously by the Assistant.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Synthesia.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateVideosFromAssistantAsync(
            global::Synthesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a video from a prompt and a PDF via the Assistant<br/>
        /// Pilot endpoint. Accepts a text prompt and a single PDF (multipart/form-data, max 6 MB) and returns a videoId and embed code immediately. The video is generated and published asynchronously by the Assistant.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Synthesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Synthesia.AutoSDKHttpResponse> CreateVideosFromAssistantAsResponseAsync(
            global::Synthesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}