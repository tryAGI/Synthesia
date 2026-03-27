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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Synthesia.TranslationStatusApiItemSuccess? complete = default;
            if (discriminator?.Status == global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus.Complete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Synthesia.TranslationStatusApiItemSuccess), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Synthesia.TranslationStatusApiItemSuccess> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Synthesia.TranslationStatusApiItemSuccess)}");
                complete = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Synthesia.TranslationStatusApiItemError? error = default;
            if (discriminator?.Status == global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Synthesia.TranslationStatusApiItemError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Synthesia.TranslationStatusApiItemError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Synthesia.TranslationStatusApiItemError)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsComplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Synthesia.TranslationStatusApiItemSuccess), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Synthesia.TranslationStatusApiItemSuccess?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Synthesia.TranslationStatusApiItemSuccess).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Complete, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Synthesia.TranslationStatusApiItemError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Synthesia.TranslationStatusApiItemError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Synthesia.TranslationStatusApiItemError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeInfo);
            }
        }
    }
}