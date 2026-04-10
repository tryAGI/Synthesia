#nullable enable

namespace Synthesia
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Get dubbing project status and videos<br/>
        /// Retrieve the status of a dubbing project and its dubbed videos.<br/>
        /// **Status values:** - `uploading`: The source video is still being uploaded/processed (only for projects created via sourceVideoUrl) - `in_progress`: Dubbing is in progress - `complete`: All dubbing is complete - `error`: An error occurred during dubbing<br/>
        /// **Response varies by status:** - UPLOADING: Returns only id and status - IN_PROGRESS/COMPLETE: Returns id, status, and dubbedAssets array - ERROR: Returns id, status, and errorCode<br/>
        /// **Dubbed asset status:** - IN_PROGRESS: Returns minimal data (id, language, status) - COMPLETE: Returns full data including download URLs - ERROR: Returns minimal data plus errorCode
        /// </summary>
        /// <param name="dubbingProjectId"></param>
        /// <param name="targetLanguages"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Synthesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Synthesia.OneOf<global::Synthesia.GetDubbingProjectVideosResponseUploading, global::Synthesia.GetDubbingProjectVideosResponseInProgress, global::Synthesia.GetDubbingProjectVideosResponseComplete, global::Synthesia.GetDubbingProjectVideosResponseError>> GetDubbingByDubbingProjectIdAsync(
            global::System.Guid dubbingProjectId,
            global::System.Collections.Generic.IList<string>? targetLanguages = default,
            global::Synthesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}