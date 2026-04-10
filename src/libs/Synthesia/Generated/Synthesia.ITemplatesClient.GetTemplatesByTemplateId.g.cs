#nullable enable

namespace Synthesia
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Retrieve a template<br/>
        /// You can use Retrieve a template endpoint to pull information on a template. In particular, you may use it to find out the variables available for customisation.
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Synthesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Synthesia.TemplateResponse> GetTemplatesByTemplateIdAsync(
            string templateId,
            global::Synthesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}