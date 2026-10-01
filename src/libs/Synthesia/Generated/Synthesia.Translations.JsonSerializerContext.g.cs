
#nullable enable

namespace Synthesia
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.UpsertVideoTranslationsApiRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.UpsertVideoTranslationsApiRequestAutoGenerate), TypeInfoPropertyName = "UpsertVideoTranslationsApiRequestAutoGenerate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItemStatus), TypeInfoPropertyName = "UpsertVideoTranslationsRunningWorkflowApiItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItemStep), TypeInfoPropertyName = "UpsertVideoTranslationsRunningWorkflowApiItemStep2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.UpsertVideoTranslationsSuccessApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.TranslationStatusApiItemError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.TranslationStatusApiItemErrorStatus), TypeInfoPropertyName = "TranslationStatusApiItemErrorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.TranslationStatusApiItemErrorErrorCode), TypeInfoPropertyName = "TranslationStatusApiItemErrorErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.TranslationStatusApiItemSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.TranslationStatusApiItemSuccessStatus), TypeInfoPropertyName = "TranslationStatusApiItemSuccessStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.TranslationStatusApiItemSuccessStep), TypeInfoPropertyName = "TranslationStatusApiItemSuccessStep2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetVideoTranslationsApiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Synthesia.TranslationsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.TranslationsItem), TypeInfoPropertyName = "TranslationsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus), TypeInfoPropertyName = "GetVideoTranslationsApiResponseTranslationDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CtaSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoAssetCaptionTypesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.ActorSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.ActorSettingsHorizontalAlign), TypeInfoPropertyName = "ActorSettingsHorizontalAlign2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.ActorSettingsStyle), TypeInfoPropertyName = "ActorSettingsStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.InputBackgroundPosition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.InputBackgroundTrim))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.InputVideoBackgroundSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.InputVideoBackgroundSettingsShortBackgroundContentMatchMode), TypeInfoPropertyName = "InputVideoBackgroundSettingsShortBackgroundContentMatchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.InputVideoBackgroundSettingsLongBackgroundContentMatchMode), TypeInfoPropertyName = "InputVideoBackgroundSettingsLongBackgroundContentMatchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.InputBackgroundSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.InputSoundSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.Input))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.InputScriptLanguage), TypeInfoPropertyName = "InputScriptLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.InputTransition), TypeInfoPropertyName = "InputTransition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.ParentSoundtrackRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.ParentSoundSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Synthesia.ParentSoundtrackRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.C2PAContentProvenanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.ContentProvenanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoThumbnailTypesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoResponseAspectRatio), TypeInfoPropertyName = "VideoResponseAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Synthesia.Input>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoResponseSoundtrack), TypeInfoPropertyName = "VideoResponseSoundtrack2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoResponseVisibility), TypeInfoPropertyName = "VideoResponseVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoResponseStatus), TypeInfoPropertyName = "VideoResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateTranslatedVideoFromXliffRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateTranslatedVideoFromXliffResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.UpsertVideoTranslationsApiRequestAutoGenerate?), TypeInfoPropertyName = "NullableUpsertVideoTranslationsApiRequestAutoGenerate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItemStatus?), TypeInfoPropertyName = "NullableUpsertVideoTranslationsRunningWorkflowApiItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItemStep?), TypeInfoPropertyName = "NullableUpsertVideoTranslationsRunningWorkflowApiItemStep2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.TranslationStatusApiItemErrorStatus?), TypeInfoPropertyName = "NullableTranslationStatusApiItemErrorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.TranslationStatusApiItemErrorErrorCode?), TypeInfoPropertyName = "NullableTranslationStatusApiItemErrorErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.TranslationStatusApiItemSuccessStatus?), TypeInfoPropertyName = "NullableTranslationStatusApiItemSuccessStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.TranslationStatusApiItemSuccessStep?), TypeInfoPropertyName = "NullableTranslationStatusApiItemSuccessStep2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.TranslationsItem?), TypeInfoPropertyName = "NullableTranslationsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus?), TypeInfoPropertyName = "NullableGetVideoTranslationsApiResponseTranslationDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.ActorSettingsHorizontalAlign?), TypeInfoPropertyName = "NullableActorSettingsHorizontalAlign2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.ActorSettingsStyle?), TypeInfoPropertyName = "NullableActorSettingsStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.InputVideoBackgroundSettingsShortBackgroundContentMatchMode?), TypeInfoPropertyName = "NullableInputVideoBackgroundSettingsShortBackgroundContentMatchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.InputVideoBackgroundSettingsLongBackgroundContentMatchMode?), TypeInfoPropertyName = "NullableInputVideoBackgroundSettingsLongBackgroundContentMatchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.InputScriptLanguage?), TypeInfoPropertyName = "NullableInputScriptLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.InputTransition?), TypeInfoPropertyName = "NullableInputTransition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoResponseAspectRatio?), TypeInfoPropertyName = "NullableVideoResponseAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoResponseSoundtrack?), TypeInfoPropertyName = "NullableVideoResponseSoundtrack2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoResponseVisibility?), TypeInfoPropertyName = "NullableVideoResponseVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoResponseStatus?), TypeInfoPropertyName = "NullableVideoResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Synthesia.TranslationsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Synthesia.ParentSoundtrackRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Synthesia.Input>))]
    internal sealed partial class TranslationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TranslationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TranslationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TranslationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Synthesia.JsonConverters.TranslationsItemJsonConverter());
            options.Converters.Add(new global::Synthesia.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Synthesia.UpsertVideoTranslationsApiRequestAutoGenerate)

                    || typeToConvert == typeof(global::Synthesia.UpsertVideoTranslationsApiRequestAutoGenerate?)

                    || typeToConvert == typeof(global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItemStatus)

                    || typeToConvert == typeof(global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItemStatus?)

                    || typeToConvert == typeof(global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItemStep)

                    || typeToConvert == typeof(global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItemStep?)

                    || typeToConvert == typeof(global::Synthesia.TranslationStatusApiItemErrorStatus)

                    || typeToConvert == typeof(global::Synthesia.TranslationStatusApiItemErrorStatus?)

                    || typeToConvert == typeof(global::Synthesia.TranslationStatusApiItemErrorErrorCode)

                    || typeToConvert == typeof(global::Synthesia.TranslationStatusApiItemErrorErrorCode?)

                    || typeToConvert == typeof(global::Synthesia.TranslationStatusApiItemSuccessStatus)

                    || typeToConvert == typeof(global::Synthesia.TranslationStatusApiItemSuccessStatus?)

                    || typeToConvert == typeof(global::Synthesia.TranslationStatusApiItemSuccessStep)

                    || typeToConvert == typeof(global::Synthesia.TranslationStatusApiItemSuccessStep?)

                    || typeToConvert == typeof(global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus)

                    || typeToConvert == typeof(global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus?)

                    || typeToConvert == typeof(global::Synthesia.ActorSettingsHorizontalAlign)

                    || typeToConvert == typeof(global::Synthesia.ActorSettingsHorizontalAlign?)

                    || typeToConvert == typeof(global::Synthesia.ActorSettingsStyle)

                    || typeToConvert == typeof(global::Synthesia.ActorSettingsStyle?)

                    || typeToConvert == typeof(global::Synthesia.InputVideoBackgroundSettingsShortBackgroundContentMatchMode)

                    || typeToConvert == typeof(global::Synthesia.InputVideoBackgroundSettingsShortBackgroundContentMatchMode?)

                    || typeToConvert == typeof(global::Synthesia.InputVideoBackgroundSettingsLongBackgroundContentMatchMode)

                    || typeToConvert == typeof(global::Synthesia.InputVideoBackgroundSettingsLongBackgroundContentMatchMode?)

                    || typeToConvert == typeof(global::Synthesia.InputScriptLanguage)

                    || typeToConvert == typeof(global::Synthesia.InputScriptLanguage?)

                    || typeToConvert == typeof(global::Synthesia.InputTransition)

                    || typeToConvert == typeof(global::Synthesia.InputTransition?)

                    || typeToConvert == typeof(global::Synthesia.VideoResponseAspectRatio)

                    || typeToConvert == typeof(global::Synthesia.VideoResponseAspectRatio?)

                    || typeToConvert == typeof(global::Synthesia.VideoResponseSoundtrack)

                    || typeToConvert == typeof(global::Synthesia.VideoResponseSoundtrack?)

                    || typeToConvert == typeof(global::Synthesia.VideoResponseVisibility)

                    || typeToConvert == typeof(global::Synthesia.VideoResponseVisibility?)

                    || typeToConvert == typeof(global::Synthesia.VideoResponseStatus)

                    || typeToConvert == typeof(global::Synthesia.VideoResponseStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Synthesia.UpsertVideoTranslationsApiRequestAutoGenerate))
                {
                    return new global::Synthesia.JsonConverters.UpsertVideoTranslationsApiRequestAutoGenerateJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.UpsertVideoTranslationsApiRequestAutoGenerate?))
                {
                    return new global::Synthesia.JsonConverters.UpsertVideoTranslationsApiRequestAutoGenerateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItemStatus))
                {
                    return new global::Synthesia.JsonConverters.UpsertVideoTranslationsRunningWorkflowApiItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItemStatus?))
                {
                    return new global::Synthesia.JsonConverters.UpsertVideoTranslationsRunningWorkflowApiItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItemStep))
                {
                    return new global::Synthesia.JsonConverters.UpsertVideoTranslationsRunningWorkflowApiItemStepJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItemStep?))
                {
                    return new global::Synthesia.JsonConverters.UpsertVideoTranslationsRunningWorkflowApiItemStepNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.TranslationStatusApiItemErrorStatus))
                {
                    return new global::Synthesia.JsonConverters.TranslationStatusApiItemErrorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.TranslationStatusApiItemErrorStatus?))
                {
                    return new global::Synthesia.JsonConverters.TranslationStatusApiItemErrorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.TranslationStatusApiItemErrorErrorCode))
                {
                    return new global::Synthesia.JsonConverters.TranslationStatusApiItemErrorErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.TranslationStatusApiItemErrorErrorCode?))
                {
                    return new global::Synthesia.JsonConverters.TranslationStatusApiItemErrorErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.TranslationStatusApiItemSuccessStatus))
                {
                    return new global::Synthesia.JsonConverters.TranslationStatusApiItemSuccessStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.TranslationStatusApiItemSuccessStatus?))
                {
                    return new global::Synthesia.JsonConverters.TranslationStatusApiItemSuccessStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.TranslationStatusApiItemSuccessStep))
                {
                    return new global::Synthesia.JsonConverters.TranslationStatusApiItemSuccessStepJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.TranslationStatusApiItemSuccessStep?))
                {
                    return new global::Synthesia.JsonConverters.TranslationStatusApiItemSuccessStepNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus))
                {
                    return new global::Synthesia.JsonConverters.GetVideoTranslationsApiResponseTranslationDiscriminatorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus?))
                {
                    return new global::Synthesia.JsonConverters.GetVideoTranslationsApiResponseTranslationDiscriminatorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.ActorSettingsHorizontalAlign))
                {
                    return new global::Synthesia.JsonConverters.ActorSettingsHorizontalAlignJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.ActorSettingsHorizontalAlign?))
                {
                    return new global::Synthesia.JsonConverters.ActorSettingsHorizontalAlignNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.ActorSettingsStyle))
                {
                    return new global::Synthesia.JsonConverters.ActorSettingsStyleJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.ActorSettingsStyle?))
                {
                    return new global::Synthesia.JsonConverters.ActorSettingsStyleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.InputVideoBackgroundSettingsShortBackgroundContentMatchMode))
                {
                    return new global::Synthesia.JsonConverters.InputVideoBackgroundSettingsShortBackgroundContentMatchModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.InputVideoBackgroundSettingsShortBackgroundContentMatchMode?))
                {
                    return new global::Synthesia.JsonConverters.InputVideoBackgroundSettingsShortBackgroundContentMatchModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.InputVideoBackgroundSettingsLongBackgroundContentMatchMode))
                {
                    return new global::Synthesia.JsonConverters.InputVideoBackgroundSettingsLongBackgroundContentMatchModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.InputVideoBackgroundSettingsLongBackgroundContentMatchMode?))
                {
                    return new global::Synthesia.JsonConverters.InputVideoBackgroundSettingsLongBackgroundContentMatchModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.InputScriptLanguage))
                {
                    return new global::Synthesia.JsonConverters.InputScriptLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.InputScriptLanguage?))
                {
                    return new global::Synthesia.JsonConverters.InputScriptLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.InputTransition))
                {
                    return new global::Synthesia.JsonConverters.InputTransitionJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.InputTransition?))
                {
                    return new global::Synthesia.JsonConverters.InputTransitionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.VideoResponseAspectRatio))
                {
                    return new global::Synthesia.JsonConverters.VideoResponseAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.VideoResponseAspectRatio?))
                {
                    return new global::Synthesia.JsonConverters.VideoResponseAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.VideoResponseSoundtrack))
                {
                    return new global::Synthesia.JsonConverters.VideoResponseSoundtrackJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.VideoResponseSoundtrack?))
                {
                    return new global::Synthesia.JsonConverters.VideoResponseSoundtrackNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.VideoResponseVisibility))
                {
                    return new global::Synthesia.JsonConverters.VideoResponseVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.VideoResponseVisibility?))
                {
                    return new global::Synthesia.JsonConverters.VideoResponseVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.VideoResponseStatus))
                {
                    return new global::Synthesia.JsonConverters.VideoResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.VideoResponseStatus?))
                {
                    return new global::Synthesia.JsonConverters.VideoResponseStatusNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new TranslationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}