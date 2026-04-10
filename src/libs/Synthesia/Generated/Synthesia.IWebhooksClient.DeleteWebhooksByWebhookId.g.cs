#nullable enable

namespace Synthesia
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Delete a webhook<br/>
        /// Use this endpoint to delete videos.
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Synthesia.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteWebhooksByWebhookIdAsync(
            string webhookId,
            global::Synthesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}