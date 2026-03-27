#nullable enable

namespace Synthesia
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Retrieve a video<br/>
        /// You can use Retrieve a video endpoint to pull for the video status.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Synthesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Synthesia.VideoResponse> GetVideosByVideoIdAsync(
            string videoId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}