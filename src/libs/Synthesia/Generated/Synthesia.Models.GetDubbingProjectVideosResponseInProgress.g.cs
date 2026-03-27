
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Synthesia
{
    /// <summary>
    /// Response when dubbing project is in progress.
    /// </summary>
    public sealed partial class GetDubbingProjectVideosResponseInProgress
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The status of the dubbed video.<br/>
        /// Default Value: in_progress
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseInProgressStatusJsonConverter))]
        public global::Synthesia.GetDubbingProjectVideosResponseInProgressStatus? Status { get; set; }

        /// <summary>
        /// The dubbed videos in the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dubbedAssets")]
        public global::System.Collections.Generic.IList<global::Synthesia.AnyOf<global::Synthesia.DubbedAssetInProgress, global::Synthesia.DubbedAssetComplete, global::Synthesia.DubbedAssetError>>? DubbedAssets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDubbingProjectVideosResponseInProgress" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status">
        /// The status of the dubbed video.<br/>
        /// Default Value: in_progress
        /// </param>
        /// <param name="dubbedAssets">
        /// The dubbed videos in the project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDubbingProjectVideosResponseInProgress(
            global::System.Guid id,
            global::Synthesia.GetDubbingProjectVideosResponseInProgressStatus? status,
            global::System.Collections.Generic.IList<global::Synthesia.AnyOf<global::Synthesia.DubbedAssetInProgress, global::Synthesia.DubbedAssetComplete, global::Synthesia.DubbedAssetError>>? dubbedAssets)
        {
            this.Id = id;
            this.Status = status;
            this.DubbedAssets = dubbedAssets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDubbingProjectVideosResponseInProgress" /> class.
        /// </summary>
        public GetDubbingProjectVideosResponseInProgress()
        {
        }
    }
}