#nullable enable

namespace Synthesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class VideoFromTemplateApiVisibilityNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Synthesia.VideoFromTemplateApiVisibility?>
    {
        /// <inheritdoc />
        public override global::Synthesia.VideoFromTemplateApiVisibility? Read(
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
                        return global::Synthesia.VideoFromTemplateApiVisibilityExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Synthesia.VideoFromTemplateApiVisibility)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Synthesia.VideoFromTemplateApiVisibility?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Synthesia.VideoFromTemplateApiVisibility? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Synthesia.VideoFromTemplateApiVisibilityExtensions.ToValueString(value.Value));
            }
        }
    }
}
