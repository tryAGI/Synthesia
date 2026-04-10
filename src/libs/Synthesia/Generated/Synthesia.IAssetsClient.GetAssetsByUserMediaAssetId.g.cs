#nullable enable

namespace Synthesia
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Get user media asset<br/>
        /// Retrieves a user uploaded media asset by its ID. Returns the asset's status, title, content type, and metadata including detected language if available. Currently only supports user-uploaded assets in the dubbing configuration.
        /// </summary>
        /// <param name="userMediaAssetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Synthesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Synthesia.GetPublicApiUserUploadedAssetResponse> GetAssetsByUserMediaAssetIdAsync(
            global::System.Guid userMediaAssetId,
            global::Synthesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}