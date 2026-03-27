#nullable enable

namespace Synthesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class PublicApiUserUploadedAssetErrorCodesJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Synthesia.PublicApiUserUploadedAssetErrorCodes>
    {
        /// <inheritdoc />
        public override global::Synthesia.PublicApiUserUploadedAssetErrorCodes Read(
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
                        return global::Synthesia.PublicApiUserUploadedAssetErrorCodesExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Synthesia.PublicApiUserUploadedAssetErrorCodes)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Synthesia.PublicApiUserUploadedAssetErrorCodes);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Synthesia.PublicApiUserUploadedAssetErrorCodes value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Synthesia.PublicApiUserUploadedAssetErrorCodesExtensions.ToValueString(value));
        }
    }
}
