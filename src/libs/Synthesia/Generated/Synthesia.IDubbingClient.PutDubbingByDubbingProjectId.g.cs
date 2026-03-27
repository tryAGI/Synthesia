#nullable enable

namespace Synthesia
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Add locales to a a dubbing project (original imported video)<br/>
        /// Add the passed target locales to a dubbing project (original imported video). If a target locale is already added, it will be skipped.
        /// </summary>
        /// <param name="dubbingProjectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Synthesia.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Synthesia.AddLocalesToDubbingProjectResponse> PutDubbingByDubbingProjectIdAsync(
            global::System.Guid dubbingProjectId,

            global::Synthesia.AddLocalesToDubbingProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add locales to a a dubbing project (original imported video)<br/>
        /// Add the passed target locales to a dubbing project (original imported video). If a target locale is already added, it will be skipped.
        /// </summary>
        /// <param name="dubbingProjectId"></param>
        /// <param name="targetLanguages">
        /// The languages to dub the source media asset to.<br/>
        /// Example: [es-ES, fr-FR]
        /// </param>
        /// <param name="lipsyncEnabled">
        /// Whether to enable lipsync for the dubbed video.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="videoDuration">
        /// The duration of the video to create.<br/>
        /// Default Value: adaptive<br/>
        /// Example: adaptive
        /// </param>
        /// <param name="visibility">
        /// The visibility of the dubbed video.<br/>
        /// Default Value: private<br/>
        /// Example: private
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Synthesia.AddLocalesToDubbingProjectResponse> PutDubbingByDubbingProjectIdAsync(
            global::System.Guid dubbingProjectId,
            global::System.Collections.Generic.IList<global::Synthesia.DubbingOutputLanguage> targetLanguages,
            bool? lipsyncEnabled = default,
            global::Synthesia.AddLocalesToDubbingProjectRequestVideoDuration? videoDuration = default,
            global::Synthesia.AddLocalesToDubbingProjectRequestVisibility? visibility = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}