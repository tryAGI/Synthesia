#nullable enable

namespace Synthesia
{
    public partial interface ITranslationsClient
    {
        /// <summary>
        /// Translate and generate a video from XLIFF definition<br/>
        /// Given XLIFF content, translate and generate a video.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Synthesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Synthesia.CreateTranslatedVideoFromXliffResponse> CreateTranslateManualAsync(

            global::Synthesia.CreateTranslatedVideoFromXliffRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Translate and generate a video from XLIFF definition<br/>
        /// Given XLIFF content, translate and generate a video.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="xliffContent"></param>
        /// <param name="callbackId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Synthesia.CreateTranslatedVideoFromXliffResponse> CreateTranslateManualAsync(
            global::System.Guid videoId,
            string xliffContent,
            string? callbackId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}