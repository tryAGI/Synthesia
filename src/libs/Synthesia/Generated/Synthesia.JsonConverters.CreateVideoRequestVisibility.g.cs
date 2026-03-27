#nullable enable

namespace Synthesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateVideoRequestVisibilityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Synthesia.CreateVideoRequestVisibility>
    {
        /// <inheritdoc />
        public override global::Synthesia.CreateVideoRequestVisibility Read(
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
                        return global::Synthesia.CreateVideoRequestVisibilityExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Synthesia.CreateVideoRequestVisibility)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Synthesia.CreateVideoRequestVisibility);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Synthesia.CreateVideoRequestVisibility value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Synthesia.CreateVideoRequestVisibilityExtensions.ToValueString(value));
        }
    }
}
