#nullable enable

namespace Synthesia.JsonConverters
{
    /// <inheritdoc />
    public sealed class ActorSettingsHorizontalAlignJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Synthesia.ActorSettingsHorizontalAlign>
    {
        /// <inheritdoc />
        public override global::Synthesia.ActorSettingsHorizontalAlign Read(
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
                        return global::Synthesia.ActorSettingsHorizontalAlignExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Synthesia.ActorSettingsHorizontalAlign)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Synthesia.ActorSettingsHorizontalAlign);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Synthesia.ActorSettingsHorizontalAlign value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Synthesia.ActorSettingsHorizontalAlignExtensions.ToValueString(value));
        }
    }
}
