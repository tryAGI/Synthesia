#nullable enable

namespace Synthesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpsertVideoTranslationsApiRequestAutoGenerateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Synthesia.UpsertVideoTranslationsApiRequestAutoGenerate>
    {
        /// <inheritdoc />
        public override global::Synthesia.UpsertVideoTranslationsApiRequestAutoGenerate Read(
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
                        return global::Synthesia.UpsertVideoTranslationsApiRequestAutoGenerateExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Synthesia.UpsertVideoTranslationsApiRequestAutoGenerate)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Synthesia.UpsertVideoTranslationsApiRequestAutoGenerate);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Synthesia.UpsertVideoTranslationsApiRequestAutoGenerate value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Synthesia.UpsertVideoTranslationsApiRequestAutoGenerateExtensions.ToValueString(value));
        }
    }
}
