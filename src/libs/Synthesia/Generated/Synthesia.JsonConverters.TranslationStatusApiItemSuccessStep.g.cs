#nullable enable

namespace Synthesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class TranslationStatusApiItemSuccessStepJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Synthesia.TranslationStatusApiItemSuccessStep>
    {
        /// <inheritdoc />
        public override global::Synthesia.TranslationStatusApiItemSuccessStep Read(
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
                        return global::Synthesia.TranslationStatusApiItemSuccessStepExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Synthesia.TranslationStatusApiItemSuccessStep)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Synthesia.TranslationStatusApiItemSuccessStep);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Synthesia.TranslationStatusApiItemSuccessStep value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Synthesia.TranslationStatusApiItemSuccessStepExtensions.ToValueString(value));
        }
    }
}
