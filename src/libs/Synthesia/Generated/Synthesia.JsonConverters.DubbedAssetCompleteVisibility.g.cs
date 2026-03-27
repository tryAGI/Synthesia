#nullable enable

namespace Synthesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class DubbedAssetCompleteVisibilityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Synthesia.DubbedAssetCompleteVisibility>
    {
        /// <inheritdoc />
        public override global::Synthesia.DubbedAssetCompleteVisibility Read(
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
                        return global::Synthesia.DubbedAssetCompleteVisibilityExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Synthesia.DubbedAssetCompleteVisibility)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Synthesia.DubbedAssetCompleteVisibility);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Synthesia.DubbedAssetCompleteVisibility value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Synthesia.DubbedAssetCompleteVisibilityExtensions.ToValueString(value));
        }
    }
}
