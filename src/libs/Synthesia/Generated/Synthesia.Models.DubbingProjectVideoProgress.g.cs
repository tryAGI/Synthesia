
#nullable enable

namespace Synthesia
{
    /// <summary>
    /// Progress of the latest version of one of a dubbing project's dubbed videos.
    /// </summary>
    public sealed partial class DubbingProjectVideoProgress
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid VideoId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Synthesia.JsonConverters.DubbingOutputLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Synthesia.DubbingOutputLanguage Language { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Synthesia.DubbedVideoProgress Progress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingProjectVideoProgress" /> class.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="version"></param>
        /// <param name="language"></param>
        /// <param name="progress"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingProjectVideoProgress(
            global::System.Guid videoId,
            int version,
            global::Synthesia.DubbingOutputLanguage language,
            global::Synthesia.DubbedVideoProgress progress)
        {
            this.VideoId = videoId;
            this.Version = version;
            this.Language = language;
            this.Progress = progress ?? throw new global::System.ArgumentNullException(nameof(progress));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingProjectVideoProgress" /> class.
        /// </summary>
        public DubbingProjectVideoProgress()
        {
        }

    }
}