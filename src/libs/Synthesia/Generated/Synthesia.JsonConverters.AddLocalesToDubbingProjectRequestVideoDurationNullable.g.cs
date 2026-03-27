#nullable enable

namespace Synthesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class AddLocalesToDubbingProjectRequestVideoDurationNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Synthesia.AddLocalesToDubbingProjectRequestVideoDuration?>
    {
        /// <inheritdoc />
        public override global::Synthesia.AddLocalesToDubbingProjectRequestVideoDuration? Read(
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
                        return global::Synthesia.AddLocalesToDubbingProjectRequestVideoDurationExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Synthesia.AddLocalesToDubbingProjectRequestVideoDuration)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Synthesia.AddLocalesToDubbingProjectRequestVideoDuration?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Synthesia.AddLocalesToDubbingProjectRequestVideoDuration? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Synthesia.AddLocalesToDubbingProjectRequestVideoDurationExtensions.ToValueString(value.Value));
            }
        }
    }
}
