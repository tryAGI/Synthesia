#nullable enable

namespace Synthesia
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// List webhooks<br/>
        /// List all currently configured webhooks in your Synthesia account.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="deleted">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Synthesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Synthesia.WebhookListResponse> GetWebhooksAsync(
            int? limit = default,
            int? offset = default,
            bool? deleted = default,
            global::Synthesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}