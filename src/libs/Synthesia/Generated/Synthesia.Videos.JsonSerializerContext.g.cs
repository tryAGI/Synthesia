
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Synthesia
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CtaSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoAssetCaptionTypesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.ActorSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.ActorSettingsHorizontalAlign), TypeInfoPropertyName = "ActorSettingsHorizontalAlign2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoFromTemplateApi))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoFromTemplateApiVisibility), TypeInfoPropertyName = "VideoFromTemplateApiVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Synthesia.VideoResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateVideoRequestAspectRatio), TypeInfoPropertyName = "CreateVideoRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateVideoRequestSoundtrack), TypeInfoPropertyName = "CreateVideoRequestSoundtrack2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateVideoRequestVisibility), TypeInfoPropertyName = "CreateVideoRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.UpdateVideoMetadataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.UpdateVideoMetadataRequestVisibility), TypeInfoPropertyName = "UpdateVideoMetadataRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoXliffResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Synthesia.GetVideosSourceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetVideosSourceItem), TypeInfoPropertyName = "GetVideosSourceItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetVideosXliffXliffVersion), TypeInfoPropertyName = "GetVideosXliffXliffVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.ActorSettingsHorizontalAlign?), TypeInfoPropertyName = "NullableActorSettingsHorizontalAlign2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.ActorSettingsStyle?), TypeInfoPropertyName = "NullableActorSettingsStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.InputVideoBackgroundSettingsShortBackgroundContentMatchMode?), TypeInfoPropertyName = "NullableInputVideoBackgroundSettingsShortBackgroundContentMatchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.InputVideoBackgroundSettingsLongBackgroundContentMatchMode?), TypeInfoPropertyName = "NullableInputVideoBackgroundSettingsLongBackgroundContentMatchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.InputScriptLanguage?), TypeInfoPropertyName = "NullableInputScriptLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.InputTransition?), TypeInfoPropertyName = "NullableInputTransition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoResponseAspectRatio?), TypeInfoPropertyName = "NullableVideoResponseAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoResponseSoundtrack?), TypeInfoPropertyName = "NullableVideoResponseSoundtrack2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoResponseVisibility?), TypeInfoPropertyName = "NullableVideoResponseVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoResponseStatus?), TypeInfoPropertyName = "NullableVideoResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoFromTemplateApiVisibility?), TypeInfoPropertyName = "NullableVideoFromTemplateApiVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateVideoRequestAspectRatio?), TypeInfoPropertyName = "NullableCreateVideoRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateVideoRequestSoundtrack?), TypeInfoPropertyName = "NullableCreateVideoRequestSoundtrack2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateVideoRequestVisibility?), TypeInfoPropertyName = "NullableCreateVideoRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.UpdateVideoMetadataRequestVisibility?), TypeInfoPropertyName = "NullableUpdateVideoMetadataRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetVideosSourceItem?), TypeInfoPropertyName = "NullableGetVideosSourceItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetVideosXliffXliffVersion?), TypeInfoPropertyName = "NullableGetVideosXliffXliffVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Synthesia.ParentSoundtrackRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Synthesia.Input>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Synthesia.VideoResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Synthesia.GetVideosSourceItem>))]
    internal sealed partial class VideosSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VideosSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VideosSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VideosSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Synthesia.ActorSettingsHorizontalAlign)

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

                    || typeToConvert == typeof(global::Synthesia.VideoResponseStatus?)

                    || typeToConvert == typeof(global::Synthesia.VideoFromTemplateApiVisibility)

                    || typeToConvert == typeof(global::Synthesia.VideoFromTemplateApiVisibility?)

                    || typeToConvert == typeof(global::Synthesia.CreateVideoRequestAspectRatio)

                    || typeToConvert == typeof(global::Synthesia.CreateVideoRequestAspectRatio?)

                    || typeToConvert == typeof(global::Synthesia.CreateVideoRequestSoundtrack)

                    || typeToConvert == typeof(global::Synthesia.CreateVideoRequestSoundtrack?)

                    || typeToConvert == typeof(global::Synthesia.CreateVideoRequestVisibility)

                    || typeToConvert == typeof(global::Synthesia.CreateVideoRequestVisibility?)

                    || typeToConvert == typeof(global::Synthesia.UpdateVideoMetadataRequestVisibility)

                    || typeToConvert == typeof(global::Synthesia.UpdateVideoMetadataRequestVisibility?)

                    || typeToConvert == typeof(global::Synthesia.GetVideosSourceItem)

                    || typeToConvert == typeof(global::Synthesia.GetVideosSourceItem?)

                    || typeToConvert == typeof(global::Synthesia.GetVideosXliffXliffVersion)

                    || typeToConvert == typeof(global::Synthesia.GetVideosXliffXliffVersion?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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

                if (typeToConvert == typeof(global::Synthesia.VideoFromTemplateApiVisibility))
                {
                    return new global::Synthesia.JsonConverters.VideoFromTemplateApiVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.VideoFromTemplateApiVisibility?))
                {
                    return new global::Synthesia.JsonConverters.VideoFromTemplateApiVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.CreateVideoRequestAspectRatio))
                {
                    return new global::Synthesia.JsonConverters.CreateVideoRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.CreateVideoRequestAspectRatio?))
                {
                    return new global::Synthesia.JsonConverters.CreateVideoRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.CreateVideoRequestSoundtrack))
                {
                    return new global::Synthesia.JsonConverters.CreateVideoRequestSoundtrackJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.CreateVideoRequestSoundtrack?))
                {
                    return new global::Synthesia.JsonConverters.CreateVideoRequestSoundtrackNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.CreateVideoRequestVisibility))
                {
                    return new global::Synthesia.JsonConverters.CreateVideoRequestVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.CreateVideoRequestVisibility?))
                {
                    return new global::Synthesia.JsonConverters.CreateVideoRequestVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.UpdateVideoMetadataRequestVisibility))
                {
                    return new global::Synthesia.JsonConverters.UpdateVideoMetadataRequestVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.UpdateVideoMetadataRequestVisibility?))
                {
                    return new global::Synthesia.JsonConverters.UpdateVideoMetadataRequestVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.GetVideosSourceItem))
                {
                    return new global::Synthesia.JsonConverters.GetVideosSourceItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.GetVideosSourceItem?))
                {
                    return new global::Synthesia.JsonConverters.GetVideosSourceItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.GetVideosXliffXliffVersion))
                {
                    return new global::Synthesia.JsonConverters.GetVideosXliffXliffVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.GetVideosXliffXliffVersion?))
                {
                    return new global::Synthesia.JsonConverters.GetVideosXliffXliffVersionNullableJsonConverter();
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
                    0 => new VideosSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}