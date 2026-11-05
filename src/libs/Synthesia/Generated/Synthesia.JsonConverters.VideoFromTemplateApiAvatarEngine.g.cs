#nullable enable

namespace Synthesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class VideoFromTemplateApiAvatarEngineJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Synthesia.VideoFromTemplateApiAvatarEngine>
    {
        /// <inheritdoc />
        public override global::Synthesia.VideoFromTemplateApiAvatarEngine Read(
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
                        return global::Synthesia.VideoFromTemplateApiAvatarEngineExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Synthesia.VideoFromTemplateApiAvatarEngine)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Synthesia.VideoFromTemplateApiAvatarEngine);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Synthesia.VideoFromTemplateApiAvatarEngine value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Synthesia.VideoFromTemplateApiAvatarEngineExtensions.ToValueString(value));
        }
    }
}
