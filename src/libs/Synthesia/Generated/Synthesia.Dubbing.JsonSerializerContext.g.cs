
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.OneOf<global::Synthesia.GetDubbingProjectVideosResponseUploading, global::Synthesia.GetDubbingProjectVideosResponseInProgress, global::Synthesia.GetDubbingProjectVideosResponseComplete, global::Synthesia.GetDubbingProjectVideosResponseError>), TypeInfoPropertyName = "GetDubbingProjectVideosResponseError_6fdb2bfd159f6d5b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.OneOf<global::Synthesia.GetDubbingProjectVideosResponseUploading, global::Synthesia.GetDubbingProjectVideosResponseInProgress, global::Synthesia.GetDubbingProjectVideosResponseComplete, global::Synthesia.GetDubbingProjectVideosResponseError>?), TypeInfoPropertyName = "GetDubbingProjectVideosResponseError_bd208661388836a6")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbingOutputLanguage), TypeInfoPropertyName = "DubbingOutputLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.AddLocalesToDubbingProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Synthesia.DubbingOutputLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.AddLocalesToDubbingProjectRequestVideoDuration), TypeInfoPropertyName = "AddLocalesToDubbingProjectRequestVideoDuration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.AddLocalesToDubbingProjectRequestVisibility), TypeInfoPropertyName = "AddLocalesToDubbingProjectRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbingInputLanguage), TypeInfoPropertyName = "DubbingInputLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetIdVideoDuration), TypeInfoPropertyName = "CreateDubbingProjectApiRequestFromSourceAssetIdVideoDuration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetIdVisibility), TypeInfoPropertyName = "CreateDubbingProjectApiRequestFromSourceAssetIdVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDuration), TypeInfoPropertyName = "CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDuration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility), TypeInfoPropertyName = "CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbedVideosApiError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.ImportedAndDubbedVideosErrorCode), TypeInfoPropertyName = "ImportedAndDubbedVideosErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbedAssetCaptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbedAssetComplete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbedAssetCompleteStatus), TypeInfoPropertyName = "DubbedAssetCompleteStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbedAssetCompleteVisibility), TypeInfoPropertyName = "DubbedAssetCompleteVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbedAssetThumbnail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbedAssetError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbedAssetErrorStatus), TypeInfoPropertyName = "DubbedAssetErrorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbedAssetInProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbedAssetInProgressStatus), TypeInfoPropertyName = "DubbedAssetInProgressStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.AddLocalesToDubbingProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Synthesia.DubbedVideosApiError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Synthesia.AnyOf<global::Synthesia.DubbedAssetInProgress, global::Synthesia.DubbedAssetComplete, global::Synthesia.DubbedAssetError>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.AnyOf<global::Synthesia.DubbedAssetInProgress, global::Synthesia.DubbedAssetComplete, global::Synthesia.DubbedAssetError>), TypeInfoPropertyName = "AnyOfDubbedAssetInProgressDubbedAssetCompleteDubbedAssetError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateDubbingProjectApiResponseFail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.ImportedAssetId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateDubbingProjectApiResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetDubbingProjectVideosResponseUploading))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetDubbingProjectVideosResponseUploadingStatus), TypeInfoPropertyName = "GetDubbingProjectVideosResponseUploadingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetDubbingProjectVideosResponseInProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetDubbingProjectVideosResponseInProgressStatus), TypeInfoPropertyName = "GetDubbingProjectVideosResponseInProgressStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetDubbingProjectVideosResponseComplete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetDubbingProjectVideosResponseCompleteStatus), TypeInfoPropertyName = "GetDubbingProjectVideosResponseCompleteStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetDubbingProjectVideosResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetDubbingProjectVideosResponseErrorStatus), TypeInfoPropertyName = "GetDubbingProjectVideosResponseErrorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.OneOf<global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetId, global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrl?>), TypeInfoPropertyName = "OneOfCreateDubbingProjectApiRequestFromSourceAssetIdCreateDubbingProjectApiRequestFromSourceVideoUrl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.OneOf<global::Synthesia.CreateDubbingProjectApiResponseFail, global::Synthesia.CreateDubbingResponse2>), TypeInfoPropertyName = "OneOfCreateDubbingProjectApiResponseFailCreateDubbingResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateDubbingResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateDubbingResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbingOutputLanguage?), TypeInfoPropertyName = "NullableDubbingOutputLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.AddLocalesToDubbingProjectRequestVideoDuration?), TypeInfoPropertyName = "NullableAddLocalesToDubbingProjectRequestVideoDuration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.AddLocalesToDubbingProjectRequestVisibility?), TypeInfoPropertyName = "NullableAddLocalesToDubbingProjectRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbingInputLanguage?), TypeInfoPropertyName = "NullableDubbingInputLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetIdVideoDuration?), TypeInfoPropertyName = "NullableCreateDubbingProjectApiRequestFromSourceAssetIdVideoDuration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetIdVisibility?), TypeInfoPropertyName = "NullableCreateDubbingProjectApiRequestFromSourceAssetIdVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDuration?), TypeInfoPropertyName = "NullableCreateDubbingProjectApiRequestFromSourceVideoUrlVideoDuration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility?), TypeInfoPropertyName = "NullableCreateDubbingProjectApiRequestFromSourceVideoUrlVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.ImportedAndDubbedVideosErrorCode?), TypeInfoPropertyName = "NullableImportedAndDubbedVideosErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbedAssetCompleteStatus?), TypeInfoPropertyName = "NullableDubbedAssetCompleteStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbedAssetCompleteVisibility?), TypeInfoPropertyName = "NullableDubbedAssetCompleteVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbedAssetErrorStatus?), TypeInfoPropertyName = "NullableDubbedAssetErrorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbedAssetInProgressStatus?), TypeInfoPropertyName = "NullableDubbedAssetInProgressStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.AnyOf<global::Synthesia.DubbedAssetInProgress, global::Synthesia.DubbedAssetComplete, global::Synthesia.DubbedAssetError>?), TypeInfoPropertyName = "NullableAnyOfDubbedAssetInProgressDubbedAssetCompleteDubbedAssetError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetDubbingProjectVideosResponseUploadingStatus?), TypeInfoPropertyName = "NullableGetDubbingProjectVideosResponseUploadingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetDubbingProjectVideosResponseInProgressStatus?), TypeInfoPropertyName = "NullableGetDubbingProjectVideosResponseInProgressStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetDubbingProjectVideosResponseCompleteStatus?), TypeInfoPropertyName = "NullableGetDubbingProjectVideosResponseCompleteStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetDubbingProjectVideosResponseErrorStatus?), TypeInfoPropertyName = "NullableGetDubbingProjectVideosResponseErrorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.OneOf<global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetId, global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrl?>?), TypeInfoPropertyName = "NullableOneOfCreateDubbingProjectApiRequestFromSourceAssetIdCreateDubbingProjectApiRequestFromSourceVideoUrl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.OneOf<global::Synthesia.CreateDubbingProjectApiResponseFail, global::Synthesia.CreateDubbingResponse2>?), TypeInfoPropertyName = "NullableOneOfCreateDubbingProjectApiResponseFailCreateDubbingResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Synthesia.DubbingOutputLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Synthesia.DubbedVideosApiError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Synthesia.AnyOf<global::Synthesia.DubbedAssetInProgress, global::Synthesia.DubbedAssetComplete, global::Synthesia.DubbedAssetError>>))]
    internal sealed partial class DubbingSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DubbingSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DubbingSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DubbingSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Synthesia.JsonConverters.AnyOfJsonConverter<global::Synthesia.DubbedAssetInProgress, global::Synthesia.DubbedAssetComplete, global::Synthesia.DubbedAssetError>());
            options.Converters.Add(new global::Synthesia.JsonConverters.AnyOfJsonConverter<global::Synthesia.DubbedAssetInProgress, global::Synthesia.DubbedAssetComplete, global::Synthesia.DubbedAssetError>());
            options.Converters.Add(new global::Synthesia.JsonConverters.AnyOfJsonConverter<global::Synthesia.DubbedAssetInProgress, global::Synthesia.DubbedAssetComplete, global::Synthesia.DubbedAssetError>());
            options.Converters.Add(new global::Synthesia.JsonConverters.OneOfJsonConverter<global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetId, global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrl?>());
            options.Converters.Add(new global::Synthesia.JsonConverters.OneOfJsonConverter<global::Synthesia.CreateDubbingProjectApiResponseFail, global::Synthesia.CreateDubbingResponse2>());
            options.Converters.Add(new global::Synthesia.JsonConverters.OneOfJsonConverter<global::Synthesia.GetDubbingProjectVideosResponseUploading, global::Synthesia.GetDubbingProjectVideosResponseInProgress, global::Synthesia.GetDubbingProjectVideosResponseComplete, global::Synthesia.GetDubbingProjectVideosResponseError>());
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
                    typeToConvert == typeof(global::Synthesia.DubbingOutputLanguage)

                    || typeToConvert == typeof(global::Synthesia.DubbingOutputLanguage?)

                    || typeToConvert == typeof(global::Synthesia.AddLocalesToDubbingProjectRequestVideoDuration)

                    || typeToConvert == typeof(global::Synthesia.AddLocalesToDubbingProjectRequestVideoDuration?)

                    || typeToConvert == typeof(global::Synthesia.AddLocalesToDubbingProjectRequestVisibility)

                    || typeToConvert == typeof(global::Synthesia.AddLocalesToDubbingProjectRequestVisibility?)

                    || typeToConvert == typeof(global::Synthesia.DubbingInputLanguage)

                    || typeToConvert == typeof(global::Synthesia.DubbingInputLanguage?)

                    || typeToConvert == typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetIdVideoDuration)

                    || typeToConvert == typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetIdVideoDuration?)

                    || typeToConvert == typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetIdVisibility)

                    || typeToConvert == typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetIdVisibility?)

                    || typeToConvert == typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDuration)

                    || typeToConvert == typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDuration?)

                    || typeToConvert == typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility)

                    || typeToConvert == typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility?)

                    || typeToConvert == typeof(global::Synthesia.ImportedAndDubbedVideosErrorCode)

                    || typeToConvert == typeof(global::Synthesia.ImportedAndDubbedVideosErrorCode?)

                    || typeToConvert == typeof(global::Synthesia.DubbedAssetCompleteStatus)

                    || typeToConvert == typeof(global::Synthesia.DubbedAssetCompleteStatus?)

                    || typeToConvert == typeof(global::Synthesia.DubbedAssetCompleteVisibility)

                    || typeToConvert == typeof(global::Synthesia.DubbedAssetCompleteVisibility?)

                    || typeToConvert == typeof(global::Synthesia.DubbedAssetErrorStatus)

                    || typeToConvert == typeof(global::Synthesia.DubbedAssetErrorStatus?)

                    || typeToConvert == typeof(global::Synthesia.DubbedAssetInProgressStatus)

                    || typeToConvert == typeof(global::Synthesia.DubbedAssetInProgressStatus?)

                    || typeToConvert == typeof(global::Synthesia.GetDubbingProjectVideosResponseUploadingStatus)

                    || typeToConvert == typeof(global::Synthesia.GetDubbingProjectVideosResponseUploadingStatus?)

                    || typeToConvert == typeof(global::Synthesia.GetDubbingProjectVideosResponseInProgressStatus)

                    || typeToConvert == typeof(global::Synthesia.GetDubbingProjectVideosResponseInProgressStatus?)

                    || typeToConvert == typeof(global::Synthesia.GetDubbingProjectVideosResponseCompleteStatus)

                    || typeToConvert == typeof(global::Synthesia.GetDubbingProjectVideosResponseCompleteStatus?)

                    || typeToConvert == typeof(global::Synthesia.GetDubbingProjectVideosResponseErrorStatus)

                    || typeToConvert == typeof(global::Synthesia.GetDubbingProjectVideosResponseErrorStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Synthesia.DubbingOutputLanguage))
                {
                    return new global::Synthesia.JsonConverters.DubbingOutputLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.DubbingOutputLanguage?))
                {
                    return new global::Synthesia.JsonConverters.DubbingOutputLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.AddLocalesToDubbingProjectRequestVideoDuration))
                {
                    return new global::Synthesia.JsonConverters.AddLocalesToDubbingProjectRequestVideoDurationJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.AddLocalesToDubbingProjectRequestVideoDuration?))
                {
                    return new global::Synthesia.JsonConverters.AddLocalesToDubbingProjectRequestVideoDurationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.AddLocalesToDubbingProjectRequestVisibility))
                {
                    return new global::Synthesia.JsonConverters.AddLocalesToDubbingProjectRequestVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.AddLocalesToDubbingProjectRequestVisibility?))
                {
                    return new global::Synthesia.JsonConverters.AddLocalesToDubbingProjectRequestVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.DubbingInputLanguage))
                {
                    return new global::Synthesia.JsonConverters.DubbingInputLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.DubbingInputLanguage?))
                {
                    return new global::Synthesia.JsonConverters.DubbingInputLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetIdVideoDuration))
                {
                    return new global::Synthesia.JsonConverters.CreateDubbingProjectApiRequestFromSourceAssetIdVideoDurationJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetIdVideoDuration?))
                {
                    return new global::Synthesia.JsonConverters.CreateDubbingProjectApiRequestFromSourceAssetIdVideoDurationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetIdVisibility))
                {
                    return new global::Synthesia.JsonConverters.CreateDubbingProjectApiRequestFromSourceAssetIdVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetIdVisibility?))
                {
                    return new global::Synthesia.JsonConverters.CreateDubbingProjectApiRequestFromSourceAssetIdVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDuration))
                {
                    return new global::Synthesia.JsonConverters.CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDurationJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDuration?))
                {
                    return new global::Synthesia.JsonConverters.CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDurationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility))
                {
                    return new global::Synthesia.JsonConverters.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility?))
                {
                    return new global::Synthesia.JsonConverters.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.ImportedAndDubbedVideosErrorCode))
                {
                    return new global::Synthesia.JsonConverters.ImportedAndDubbedVideosErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.ImportedAndDubbedVideosErrorCode?))
                {
                    return new global::Synthesia.JsonConverters.ImportedAndDubbedVideosErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.DubbedAssetCompleteStatus))
                {
                    return new global::Synthesia.JsonConverters.DubbedAssetCompleteStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.DubbedAssetCompleteStatus?))
                {
                    return new global::Synthesia.JsonConverters.DubbedAssetCompleteStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.DubbedAssetCompleteVisibility))
                {
                    return new global::Synthesia.JsonConverters.DubbedAssetCompleteVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.DubbedAssetCompleteVisibility?))
                {
                    return new global::Synthesia.JsonConverters.DubbedAssetCompleteVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.DubbedAssetErrorStatus))
                {
                    return new global::Synthesia.JsonConverters.DubbedAssetErrorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.DubbedAssetErrorStatus?))
                {
                    return new global::Synthesia.JsonConverters.DubbedAssetErrorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.DubbedAssetInProgressStatus))
                {
                    return new global::Synthesia.JsonConverters.DubbedAssetInProgressStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.DubbedAssetInProgressStatus?))
                {
                    return new global::Synthesia.JsonConverters.DubbedAssetInProgressStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.GetDubbingProjectVideosResponseUploadingStatus))
                {
                    return new global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseUploadingStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.GetDubbingProjectVideosResponseUploadingStatus?))
                {
                    return new global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseUploadingStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.GetDubbingProjectVideosResponseInProgressStatus))
                {
                    return new global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseInProgressStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.GetDubbingProjectVideosResponseInProgressStatus?))
                {
                    return new global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseInProgressStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.GetDubbingProjectVideosResponseCompleteStatus))
                {
                    return new global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseCompleteStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.GetDubbingProjectVideosResponseCompleteStatus?))
                {
                    return new global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseCompleteStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.GetDubbingProjectVideosResponseErrorStatus))
                {
                    return new global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseErrorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Synthesia.GetDubbingProjectVideosResponseErrorStatus?))
                {
                    return new global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseErrorStatusNullableJsonConverter();
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
                    0 => new DubbingSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}