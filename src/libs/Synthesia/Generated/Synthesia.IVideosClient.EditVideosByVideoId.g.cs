#nullable enable

namespace Synthesia
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Update a video<br/>
        /// Use the Update a video endpoint to make the video public and accessible via the share page or update its title and description.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Synthesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Synthesia.VideoResponse> EditVideosByVideoIdAsync(
            string videoId,

            global::Synthesia.UpdateVideoMetadataRequest request,
            global::Synthesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a video<br/>
        /// Use the Update a video endpoint to make the video public and accessible via the share page or update its title and description.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="ctaSettings"></param>
        /// <param name="description"></param>
        /// <param name="title"></param>
        /// <param name="visibility"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Synthesia.VideoResponse> EditVideosByVideoIdAsync(
            string videoId,
            global::Synthesia.CtaSettings? ctaSettings = default,
            string? description = default,
            string? title = default,
            global::Synthesia.UpdateVideoMetadataRequestVisibility? visibility = default,
            global::Synthesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}