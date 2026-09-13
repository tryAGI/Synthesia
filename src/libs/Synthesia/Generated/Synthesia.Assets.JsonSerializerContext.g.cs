
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbingAssetRequestConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbingAssetRequestConfigurationName), TypeInfoPropertyName = "DubbingAssetRequestConfigurationName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateAssetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateAssetRequestContentType), TypeInfoPropertyName = "CreateAssetRequestContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateAssetRequestConfigurationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateAssetRequestConfigurationDiscriminatorName), TypeInfoPropertyName = "CreateAssetRequestConfigurationDiscriminatorName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.MultipartUploadCredentialsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateAssetMultipartUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.AssetContentType), TypeInfoPropertyName = "AssetContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetPublicApiMediaAssetMetadataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.LanguageBCP47), TypeInfoPropertyName = "LanguageBCP472")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.PublicApiUserUploadedAssetErrorCodes), TypeInfoPropertyName = "PublicApiUserUploadedAssetErrorCodes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.PublicApiUserUploadedAssetStatus), TypeInfoPropertyName = "PublicApiUserUploadedAssetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetPublicApiUserUploadedAssetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbingAssetRequestConfigurationName?), TypeInfoPropertyName = "NullableDubbingAssetRequestConfigurationName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateAssetRequestContentType?), TypeInfoPropertyName = "NullableCreateAssetRequestContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateAssetRequestConfigurationDiscriminatorName?), TypeInfoPropertyName = "NullableCreateAssetRequestConfigurationDiscriminatorName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.AssetContentType?), TypeInfoPropertyName = "NullableAssetContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.LanguageBCP47?), TypeInfoPropertyName = "NullableLanguageBCP472")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.PublicApiUserUploadedAssetErrorCodes?), TypeInfoPropertyName = "NullablePublicApiUserUploadedAssetErrorCodes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.PublicApiUserUploadedAssetStatus?), TypeInfoPropertyName = "NullablePublicApiUserUploadedAssetStatus2")]
    internal sealed partial class AssetsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AssetsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AssetsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AssetsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Synthesia.DubbingAssetRequestConfigurationName)

                    || typeToConvert == typeof(global::Synthesia.DubbingAssetRequestConfigurationName?)

                    || typeToConvert == typeof(global::Synthesia.CreateAssetRequestContentType)

                    || typeToConvert == typeof(global::Synthesia.CreateAssetRequestContentType?)

                    || typeToConvert == typeof(global::Synthesia.CreateAssetRequestConfigurationDiscriminatorName)

                    || typeToConvert == typeof(global::Synthesia.CreateAssetRequestConfigurationDiscriminatorName?)

                    || typeToConvert == typeof(global::Synthesia.AssetContentType)

                    || typeToConvert == typeof(global::Synthesia.AssetContentType?)

                    || typeToConvert == typeof(global::Synthesia.LanguageBCP47)

                    || typeToConvert == typeof(global::Synthesia.LanguageBCP47?)

                    || typeToConvert == typeof(global::Synthesia.PublicApiUserUploadedAssetErrorCodes)

                    || typeToConvert == typeof(global::Synthesia.PublicApiUserUploadedAssetErrorCodes?)

                    || typeToConvert == typeof(global::Synthesia.PublicApiUserUploadedAssetStatus)

                    || typeToConvert == typeof(global::Synthesia.PublicApiUserUploadedAssetStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Synthesia.DubbingAssetRequestConfigurationName))
                {
                    return new global::Synthesia.JsonConverters.DubbingAssetRequestConfigurationNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.DubbingAssetRequestConfigurationName?))
                {
                    return new global::Synthesia.JsonConverters.DubbingAssetRequestConfigurationNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.CreateAssetRequestContentType))
                {
                    return new global::Synthesia.JsonConverters.CreateAssetRequestContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.CreateAssetRequestContentType?))
                {
                    return new global::Synthesia.JsonConverters.CreateAssetRequestContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.CreateAssetRequestConfigurationDiscriminatorName))
                {
                    return new global::Synthesia.JsonConverters.CreateAssetRequestConfigurationDiscriminatorNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.CreateAssetRequestConfigurationDiscriminatorName?))
                {
                    return new global::Synthesia.JsonConverters.CreateAssetRequestConfigurationDiscriminatorNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.AssetContentType))
                {
                    return new global::Synthesia.JsonConverters.AssetContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.AssetContentType?))
                {
                    return new global::Synthesia.JsonConverters.AssetContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.LanguageBCP47))
                {
                    return new global::Synthesia.JsonConverters.LanguageBCP47JsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.LanguageBCP47?))
                {
                    return new global::Synthesia.JsonConverters.LanguageBCP47NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.PublicApiUserUploadedAssetErrorCodes))
                {
                    return new global::Synthesia.JsonConverters.PublicApiUserUploadedAssetErrorCodesJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.PublicApiUserUploadedAssetErrorCodes?))
                {
                    return new global::Synthesia.JsonConverters.PublicApiUserUploadedAssetErrorCodesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.PublicApiUserUploadedAssetStatus))
                {
                    return new global::Synthesia.JsonConverters.PublicApiUserUploadedAssetStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.PublicApiUserUploadedAssetStatus?))
                {
                    return new global::Synthesia.JsonConverters.PublicApiUserUploadedAssetStatusNullableJsonConverter();
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
                    0 => new AssetsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}