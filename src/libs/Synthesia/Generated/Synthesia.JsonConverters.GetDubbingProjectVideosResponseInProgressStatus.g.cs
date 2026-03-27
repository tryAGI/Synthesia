#nullable enable

namespace Synthesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetDubbingProjectVideosResponseInProgressStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Synthesia.GetDubbingProjectVideosResponseInProgressStatus>
    {
        /// <inheritdoc />
        public override global::Synthesia.GetDubbingProjectVideosResponseInProgressStatus Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Synthesia.GetDubbingProjectVideosResponseInProgressStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Synthesia.GetDubbingProjectVideosResponseInProgressStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Synthesia.GetDubbingProjectVideosResponseInProgressStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Synthesia.GetDubbingProjectVideosResponseInProgressStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Synthesia.GetDubbingProjectVideosResponseInProgressStatusExtensions.ToValueString(value));
        }
    }
}
