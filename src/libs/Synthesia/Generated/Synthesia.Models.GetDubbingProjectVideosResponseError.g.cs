
#nullable enable

namespace Synthesia
{
    /// <summary>
    /// Response when dubbing project encountered an error.
    /// </summary>
    public sealed partial class GetDubbingProjectVideosResponseError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The status of the dubbed video.<br/>
        /// Default Value: error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseErrorStatusJsonConverter))]
        public global::Synthesia.GetDubbingProjectVideosResponseErrorStatus? Status { get; set; }

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
        /// Initializes a new instance of the <see cref="GetDubbingProjectVideosResponseError" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status">
        /// The status of the dubbed video.<br/>
        /// Default Value: error
        /// </param>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDubbingProjectVideosResponseError(
            global::System.Guid id,
            global::Synthesia.PublicApiImportedAndDubbedVideosErrorCode errorCode,
            global::Synthesia.GetDubbingProjectVideosResponseErrorStatus? status)
        {
            this.Id = id;
            this.ErrorCode = errorCode;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDubbingProjectVideosResponseError" /> class.
        /// </summary>
        public GetDubbingProjectVideosResponseError()
        {
        }
    }
}