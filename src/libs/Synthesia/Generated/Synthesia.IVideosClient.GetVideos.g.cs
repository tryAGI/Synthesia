#nullable enable

namespace Synthesia
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// List videos<br/>
        /// You can use the List videos endpoint to get an overview of all videos created via the API or STUDIO.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="source">
        /// Default Value: [workspace, shared_with_me, my_videos]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Synthesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Synthesia.VideoListResponse> GetVideosAsync(
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<global::Synthesia.GetVideosSourceItem>? source = default,
            global::Synthesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}