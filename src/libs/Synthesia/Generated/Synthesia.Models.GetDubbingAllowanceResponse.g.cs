
#nullable enable

namespace Synthesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDubbingAllowanceResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remainingSeconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RemainingSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowanceSeconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AllowanceSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coversLipsync")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CoversLipsync { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("periodStart")]
        public string? PeriodStart { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("periodEnd")]
        public string? PeriodEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDubbingAllowanceResponse" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="remainingSeconds"></param>
        /// <param name="allowanceSeconds"></param>
        /// <param name="coversLipsync"></param>
        /// <param name="periodStart"></param>
        /// <param name="periodEnd"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDubbingAllowanceResponse(
            bool enabled,
            double remainingSeconds,
            double allowanceSeconds,
            bool coversLipsync,
            string? periodStart,
            string? periodEnd)
        {
            this.Enabled = enabled;
            this.RemainingSeconds = remainingSeconds;
            this.AllowanceSeconds = allowanceSeconds;
            this.CoversLipsync = coversLipsync;
            this.PeriodStart = periodStart;
            this.PeriodEnd = periodEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDubbingAllowanceResponse" /> class.
        /// </summary>
        public GetDubbingAllowanceResponse()
        {
        }

    }
}