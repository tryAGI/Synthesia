
#nullable enable

namespace Synthesia
{
    /// <summary>
    /// Dubbed asset error - minimal data + error code.
    /// </summary>
    public sealed partial class DubbedAssetError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Synthesia.JsonConverters.DubbingOutputLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Synthesia.DubbingOutputLanguage Language { get; set; }

        /// <summary>
        /// The status of the dubbed video.<br/>
        /// Default Value: error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Synthesia.JsonConverters.DubbedAssetErrorStatusJsonConverter))]
        public global::Synthesia.DubbedAssetErrorStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Synthesia.JsonConverters.PublicApiImportedAndDubbedVideosErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Synthesia.PublicApiImportedAndDubbedVideosErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbedAssetError" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="language"></param>
        /// <param name="errorCode"></param>
        /// <param name="status">
        /// The status of the dubbed video.<br/>
        /// Default Value: error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbedAssetError(
            global::System.Guid id,
            global::Synthesia.DubbingOutputLanguage language,
            global::Synthesia.PublicApiImportedAndDubbedVideosErrorCode errorCode,
            global::Synthesia.DubbedAssetErrorStatus? status)
        {
            this.Id = id;
            this.Language = language;
            this.Status = status;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbedAssetError" /> class.
        /// </summary>
        public DubbedAssetError()
        {
        }
    }
}