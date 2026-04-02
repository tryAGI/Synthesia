#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Synthesia.JsonConverters
{
    /// <inheritdoc />
    public class TranslationsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Synthesia.TranslationsItem>
    {
        /// <inheritdoc />
        public override global::Synthesia.TranslationsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminator>(ref readerCopy, options);

            global::Synthesia.TranslationStatusApiItemSuccess? complete = default;
            if (discriminator?.Status == global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus.Complete)
            {
                complete = global::System.Text.Json.JsonSerializer.Deserialize<global::Synthesia.TranslationStatusApiItemSuccess>(ref reader, options);
            }
            global::Synthesia.TranslationStatusApiItemError? error = default;
            if (discriminator?.Status == global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus.Error)
            {
                error = global::System.Text.Json.JsonSerializer.Deserialize<global::Synthesia.TranslationStatusApiItemError>(ref reader, options);
            }

            var __value = new global::Synthesia.TranslationsItem(
                discriminator?.Status,
                complete,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Synthesia.TranslationsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsComplete)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Complete, typeof(global::Synthesia.TranslationStatusApiItemSuccess), options);
            }
            else if (value.IsError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeof(global::Synthesia.TranslationStatusApiItemError), options);
            }
        }
    }
}