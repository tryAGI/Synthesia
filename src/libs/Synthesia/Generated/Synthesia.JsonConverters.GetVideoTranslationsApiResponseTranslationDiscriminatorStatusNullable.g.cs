#nullable enable

namespace Synthesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetVideoTranslationsApiResponseTranslationDiscriminatorStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus?>
    {
        /// <inheritdoc />
        public override global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus? Read(
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
                        return global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminatorStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminatorStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
