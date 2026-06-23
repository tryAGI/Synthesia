#nullable enable

namespace Synthesia
{
    public partial interface IInteractiveAvatarClient
    {
        /// <summary>
        /// Start an interactive avatar session<br/>
        /// Launch a Synthesia avatar into a developer-supplied LiveKit room and return the session id.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Synthesia.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateInteractiveAvatarSessionsAsync(

            global::Synthesia.CreateInteractiveAvatarSessionRequest request,
            global::Synthesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start an interactive avatar session<br/>
        /// Launch a Synthesia avatar into a developer-supplied LiveKit room and return the session id.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Synthesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Synthesia.AutoSDKHttpResponse> CreateInteractiveAvatarSessionsAsResponseAsync(

            global::Synthesia.CreateInteractiveAvatarSessionRequest request,
            global::Synthesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start an interactive avatar session<br/>
        /// Launch a Synthesia avatar into a developer-supplied LiveKit room and return the session id.
        /// </summary>
        /// <param name="avatarIds"></param>
        /// <param name="livekitUrl"></param>
        /// <param name="lkToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateInteractiveAvatarSessionsAsync(
            global::System.Collections.Generic.IList<string> avatarIds,
            string livekitUrl,
            string lkToken,
            global::Synthesia.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}