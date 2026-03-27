#nullable enable

namespace Synthesia
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Create a Webhook<br/>
        /// Use the Create a webhook endpoint to create a new even subscription.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Synthesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Synthesia.WebhookResponse> CreateWebhooksAsync(

            global::Synthesia.CreateWebhookRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Webhook<br/>
        /// Use the Create a webhook endpoint to create a new even subscription.
        /// </summary>
        /// <param name="events">
        /// [The webhook events](https://docs.synthesia.io/reference/webhook-events) for which notifications should be sent.
        /// </param>
        /// <param name="url">
        /// The URL to send notifications to
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Synthesia.WebhookResponse> CreateWebhooksAsync(
            global::System.Collections.Generic.IList<global::Synthesia.CreateWebhookRequestEvent> events,
            string url,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}