#nullable enable

namespace Synthesia
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Delete a video<br/>
        /// Use this endpoint to delete videos.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Synthesia.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteVideosByVideoIdAsync(
            string videoId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}