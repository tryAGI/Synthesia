
#nullable enable

namespace Synthesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDubbingProjectProgressResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("dubbedVideos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Synthesia.DubbingProjectVideoProgress> DubbedVideos { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDubbingProjectProgressResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dubbedVideos"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDubbingProjectProgressResponse(
            global::System.Guid id,
            global::System.Collections.Generic.IList<global::Synthesia.DubbingProjectVideoProgress> dubbedVideos)
        {
            this.Id = id;
            this.DubbedVideos = dubbedVideos ?? throw new global::System.ArgumentNullException(nameof(dubbedVideos));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDubbingProjectProgressResponse" /> class.
        /// </summary>
        public GetDubbingProjectProgressResponse()
        {
        }

    }
}