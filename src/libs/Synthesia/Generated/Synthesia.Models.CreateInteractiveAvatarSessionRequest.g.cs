
#nullable enable

namespace Synthesia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateInteractiveAvatarSessionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AvatarIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("livekit_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LivekitUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lk_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LkToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInteractiveAvatarSessionRequest" /> class.
        /// </summary>
        /// <param name="avatarIds"></param>
        /// <param name="livekitUrl"></param>
        /// <param name="lkToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateInteractiveAvatarSessionRequest(
            global::System.Collections.Generic.IList<string> avatarIds,
            string livekitUrl,
            string lkToken)
        {
            this.AvatarIds = avatarIds ?? throw new global::System.ArgumentNullException(nameof(avatarIds));
            this.LivekitUrl = livekitUrl ?? throw new global::System.ArgumentNullException(nameof(livekitUrl));
            this.LkToken = lkToken ?? throw new global::System.ArgumentNullException(nameof(lkToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInteractiveAvatarSessionRequest" /> class.
        /// </summary>
        public CreateInteractiveAvatarSessionRequest()
        {
        }

    }
}