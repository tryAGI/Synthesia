
#nullable enable

namespace Synthesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class C2PAContentProvenanceResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SignedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claimGenerator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClaimGenerator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="C2PAContentProvenanceResponse" /> class.
        /// </summary>
        /// <param name="signedAt"></param>
        /// <param name="claimGenerator"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public C2PAContentProvenanceResponse(
            string signedAt,
            string claimGenerator)
        {
            this.SignedAt = signedAt ?? throw new global::System.ArgumentNullException(nameof(signedAt));
            this.ClaimGenerator = claimGenerator ?? throw new global::System.ArgumentNullException(nameof(claimGenerator));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="C2PAContentProvenanceResponse" /> class.
        /// </summary>
        public C2PAContentProvenanceResponse()
        {
        }

    }
}