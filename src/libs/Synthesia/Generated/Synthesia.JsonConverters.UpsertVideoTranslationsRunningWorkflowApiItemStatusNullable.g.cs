#nullable enable

namespace Synthesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpsertVideoTranslationsRunningWorkflowApiItemStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItemStatus?>
    {
        /// <inheritdoc />
        public override global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItemStatus? Read(
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
                        return global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItemStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItemStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItemStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItemStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItemStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
