
#nullable enable

namespace Synthesia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InputVideoBackgroundSettings
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trim")]
        public global::Synthesia.InputBackgroundTrim? Trim { get; set; }

        /// <summary>
        /// Possible values: - `freeze` freezes the last frame of the background until the content is finished - `loop` loops the background until the content is finished - `slow_down` slows down the background so that its duration matches the content duration<br/>
        /// Default Value: freeze
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shortBackgroundContentMatchMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Synthesia.JsonConverters.InputVideoBackgroundSettingsShortBackgroundContentMatchModeJsonConverter))]
        public global::Synthesia.InputVideoBackgroundSettingsShortBackgroundContentMatchMode? ShortBackgroundContentMatchMode { get; set; }

        /// <summary>
        /// Possible values - `trim` trims the background to the duration of the content - `speed_up` speeds up the background so that its duration matches the content duration<br/>
        /// Default Value: trim
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("longBackgroundContentMatchMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Synthesia.JsonConverters.InputVideoBackgroundSettingsLongBackgroundContentMatchModeJsonConverter))]
        public global::Synthesia.InputVideoBackgroundSettingsLongBackgroundContentMatchMode? LongBackgroundContentMatchMode { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        public double? Volume { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputVideoBackgroundSettings" /> class.
        /// </summary>
        /// <param name="trim">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="shortBackgroundContentMatchMode">
        /// Possible values: - `freeze` freezes the last frame of the background until the content is finished - `loop` loops the background until the content is finished - `slow_down` slows down the background so that its duration matches the content duration<br/>
        /// Default Value: freeze
        /// </param>
        /// <param name="longBackgroundContentMatchMode">
        /// Possible values - `trim` trims the background to the duration of the content - `speed_up` speeds up the background so that its duration matches the content duration<br/>
        /// Default Value: trim
        /// </param>
        /// <param name="volume">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputVideoBackgroundSettings(
            global::Synthesia.InputBackgroundTrim? trim,
            global::Synthesia.InputVideoBackgroundSettingsShortBackgroundContentMatchMode? shortBackgroundContentMatchMode,
            global::Synthesia.InputVideoBackgroundSettingsLongBackgroundContentMatchMode? longBackgroundContentMatchMode,
            double? volume)
        {
            this.Trim = trim;
            this.ShortBackgroundContentMatchMode = shortBackgroundContentMatchMode;
            this.LongBackgroundContentMatchMode = longBackgroundContentMatchMode;
            this.Volume = volume;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputVideoBackgroundSettings" /> class.
        /// </summary>
        public InputVideoBackgroundSettings()
        {
        }
    }
}