
#nullable enable

namespace Synthesia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentProvenanceResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("c2pa")]
        public global::Synthesia.C2PAContentProvenanceResponse? C2pa { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentProvenanceResponse" /> class.
        /// </summary>
        /// <param name="c2pa"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentProvenanceResponse(
            global::Synthesia.C2PAContentProvenanceResponse? c2pa)
        {
            this.C2pa = c2pa;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentProvenanceResponse" /> class.
        /// </summary>
        public ContentProvenanceResponse()
        {
        }

    }
}