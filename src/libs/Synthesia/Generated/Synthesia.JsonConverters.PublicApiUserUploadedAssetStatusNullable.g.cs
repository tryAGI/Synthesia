#nullable enable

namespace Synthesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class PublicApiUserUploadedAssetStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Synthesia.PublicApiUserUploadedAssetStatus?>
    {
        /// <inheritdoc />
        public override global::Synthesia.PublicApiUserUploadedAssetStatus? Read(
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
                        return global::Synthesia.PublicApiUserUploadedAssetStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Synthesia.PublicApiUserUploadedAssetStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Synthesia.PublicApiUserUploadedAssetStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Synthesia.PublicApiUserUploadedAssetStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Synthesia.PublicApiUserUploadedAssetStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
