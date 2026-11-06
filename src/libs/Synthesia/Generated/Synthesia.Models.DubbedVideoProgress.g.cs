
#nullable enable

namespace Synthesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DubbedVideoProgress
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalEstProcessingTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalEstProcessingTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Progress { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        public int? StartTime { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generationStage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Synthesia.JsonConverters.DubbingGenerationStageJsonConverter))]
        public global::Synthesia.DubbingGenerationStage? GenerationStage { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generationState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Synthesia.JsonConverters.GenerationStateJsonConverter))]
        public global::Synthesia.GenerationState? GenerationState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbedVideoProgress" /> class.
        /// </summary>
        /// <param name="totalEstProcessingTime"></param>
        /// <param name="progress"></param>
        /// <param name="startTime">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="generationStage">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="generationState">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbedVideoProgress(
            int totalEstProcessingTime,
            double progress,
            int? startTime,
            global::Synthesia.DubbingGenerationStage? generationStage,
            global::Synthesia.GenerationState? generationState)
        {
            this.TotalEstProcessingTime = totalEstProcessingTime;
            this.Progress = progress;
            this.StartTime = startTime;
            this.GenerationStage = generationStage;
            this.GenerationState = generationState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbedVideoProgress" /> class.
        /// </summary>
        public DubbedVideoProgress()
        {
        }

    }
}