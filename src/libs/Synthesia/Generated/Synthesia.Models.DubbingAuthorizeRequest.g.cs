
#nullable enable

namespace Synthesia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubbingAuthorizeRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Synthesia.JsonConverters.DubbingAuthorizeActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Synthesia.DubbingAuthorizeAction Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Locale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingAuthorizeRequest" /> class.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="action"></param>
        /// <param name="locale"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingAuthorizeRequest(
            string videoId,
            global::Synthesia.DubbingAuthorizeAction action,
            string locale)
        {
            this.VideoId = videoId ?? throw new global::System.ArgumentNullException(nameof(videoId));
            this.Action = action;
            this.Locale = locale ?? throw new global::System.ArgumentNullException(nameof(locale));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingAuthorizeRequest" /> class.
        /// </summary>
        public DubbingAuthorizeRequest()
        {
        }

    }
}