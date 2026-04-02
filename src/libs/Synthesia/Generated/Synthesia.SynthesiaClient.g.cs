
#nullable enable

namespace Synthesia
{
    /// <summary>
    /// Synthesia public API endpoints<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class SynthesiaClient : global::Synthesia.ISynthesiaClient, global::System.IDisposable
    {
        /// <summary>
        /// Synthesia public API URL.
        /// </summary>
        public const string DefaultBaseUrl = "https://api.synthesia.io";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Synthesia.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::Synthesia.JsonConverters.DubbingOutputLanguageJsonConverter(),
                    new global::Synthesia.JsonConverters.DubbingOutputLanguageNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.AddLocalesToDubbingProjectRequestVideoDurationJsonConverter(),
                    new global::Synthesia.JsonConverters.AddLocalesToDubbingProjectRequestVideoDurationNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.AddLocalesToDubbingProjectRequestVisibilityJsonConverter(),
                    new global::Synthesia.JsonConverters.AddLocalesToDubbingProjectRequestVisibilityNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.DubbingAssetRequestConfigurationNameJsonConverter(),
                    new global::Synthesia.JsonConverters.DubbingAssetRequestConfigurationNameNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.CreateAssetRequestContentTypeJsonConverter(),
                    new global::Synthesia.JsonConverters.CreateAssetRequestContentTypeNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.CreateAssetRequestConfigurationDiscriminatorNameJsonConverter(),
                    new global::Synthesia.JsonConverters.CreateAssetRequestConfigurationDiscriminatorNameNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.DubbingInputLanguageJsonConverter(),
                    new global::Synthesia.JsonConverters.DubbingInputLanguageNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.CreateDubbingProjectApiRequestFromSourceAssetIdVideoDurationJsonConverter(),
                    new global::Synthesia.JsonConverters.CreateDubbingProjectApiRequestFromSourceAssetIdVideoDurationNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.CreateDubbingProjectApiRequestFromSourceAssetIdVisibilityJsonConverter(),
                    new global::Synthesia.JsonConverters.CreateDubbingProjectApiRequestFromSourceAssetIdVisibilityNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDurationJsonConverter(),
                    new global::Synthesia.JsonConverters.CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDurationNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibilityJsonConverter(),
                    new global::Synthesia.JsonConverters.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibilityNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.UpsertVideoTranslationsApiRequestAutoGenerateJsonConverter(),
                    new global::Synthesia.JsonConverters.UpsertVideoTranslationsApiRequestAutoGenerateNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.PublicApiImportedAndDubbedVideosErrorCodeJsonConverter(),
                    new global::Synthesia.JsonConverters.PublicApiImportedAndDubbedVideosErrorCodeNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.DubbedAssetCompleteStatusJsonConverter(),
                    new global::Synthesia.JsonConverters.DubbedAssetCompleteStatusNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.DubbedAssetCompleteVisibilityJsonConverter(),
                    new global::Synthesia.JsonConverters.DubbedAssetCompleteVisibilityNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.DubbedAssetErrorStatusJsonConverter(),
                    new global::Synthesia.JsonConverters.DubbedAssetErrorStatusNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.DubbedAssetInProgressStatusJsonConverter(),
                    new global::Synthesia.JsonConverters.DubbedAssetInProgressStatusNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.AssetContentTypeJsonConverter(),
                    new global::Synthesia.JsonConverters.AssetContentTypeNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.LanguageBCP47JsonConverter(),
                    new global::Synthesia.JsonConverters.LanguageBCP47NullableJsonConverter(),
                    new global::Synthesia.JsonConverters.PublicApiUserUploadedAssetErrorCodesJsonConverter(),
                    new global::Synthesia.JsonConverters.PublicApiUserUploadedAssetErrorCodesNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.PublicApiUserUploadedAssetStatusJsonConverter(),
                    new global::Synthesia.JsonConverters.PublicApiUserUploadedAssetStatusNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseUploadingStatusJsonConverter(),
                    new global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseUploadingStatusNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseInProgressStatusJsonConverter(),
                    new global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseInProgressStatusNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseCompleteStatusJsonConverter(),
                    new global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseCompleteStatusNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseErrorStatusJsonConverter(),
                    new global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseErrorStatusNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.ActorTypeJsonConverter(),
                    new global::Synthesia.JsonConverters.ActorTypeNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.TargetTypeJsonConverter(),
                    new global::Synthesia.JsonConverters.TargetTypeNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.UpsertVideoTranslationsRunningWorkflowApiItemStatusJsonConverter(),
                    new global::Synthesia.JsonConverters.UpsertVideoTranslationsRunningWorkflowApiItemStatusNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.UpsertVideoTranslationsRunningWorkflowApiItemStepJsonConverter(),
                    new global::Synthesia.JsonConverters.UpsertVideoTranslationsRunningWorkflowApiItemStepNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.TranslationStatusApiItemErrorStatusJsonConverter(),
                    new global::Synthesia.JsonConverters.TranslationStatusApiItemErrorStatusNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.TranslationStatusApiItemErrorErrorCodeJsonConverter(),
                    new global::Synthesia.JsonConverters.TranslationStatusApiItemErrorErrorCodeNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.TranslationStatusApiItemSuccessStatusJsonConverter(),
                    new global::Synthesia.JsonConverters.TranslationStatusApiItemSuccessStatusNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.TranslationStatusApiItemSuccessStepJsonConverter(),
                    new global::Synthesia.JsonConverters.TranslationStatusApiItemSuccessStepNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.GetVideoTranslationsApiResponseTranslationDiscriminatorStatusJsonConverter(),
                    new global::Synthesia.JsonConverters.GetVideoTranslationsApiResponseTranslationDiscriminatorStatusNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.TemplateResponseVisibilityJsonConverter(),
                    new global::Synthesia.JsonConverters.TemplateResponseVisibilityNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.ActorSettingsHorizontalAlignJsonConverter(),
                    new global::Synthesia.JsonConverters.ActorSettingsHorizontalAlignNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.ActorSettingsStyleJsonConverter(),
                    new global::Synthesia.JsonConverters.ActorSettingsStyleNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.InputVideoBackgroundSettingsShortBackgroundContentMatchModeJsonConverter(),
                    new global::Synthesia.JsonConverters.InputVideoBackgroundSettingsShortBackgroundContentMatchModeNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.InputVideoBackgroundSettingsLongBackgroundContentMatchModeJsonConverter(),
                    new global::Synthesia.JsonConverters.InputVideoBackgroundSettingsLongBackgroundContentMatchModeNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.InputScriptLanguageJsonConverter(),
                    new global::Synthesia.JsonConverters.InputScriptLanguageNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.InputTransitionJsonConverter(),
                    new global::Synthesia.JsonConverters.InputTransitionNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.VideoResponseAspectRatioJsonConverter(),
                    new global::Synthesia.JsonConverters.VideoResponseAspectRatioNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.VideoResponseSoundtrackJsonConverter(),
                    new global::Synthesia.JsonConverters.VideoResponseSoundtrackNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.VideoResponseVisibilityJsonConverter(),
                    new global::Synthesia.JsonConverters.VideoResponseVisibilityNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.VideoResponseStatusJsonConverter(),
                    new global::Synthesia.JsonConverters.VideoResponseStatusNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.VideoFromTemplateApiVisibilityJsonConverter(),
                    new global::Synthesia.JsonConverters.VideoFromTemplateApiVisibilityNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.CreateVideoRequestAspectRatioJsonConverter(),
                    new global::Synthesia.JsonConverters.CreateVideoRequestAspectRatioNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.CreateVideoRequestSoundtrackJsonConverter(),
                    new global::Synthesia.JsonConverters.CreateVideoRequestSoundtrackNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.CreateVideoRequestVisibilityJsonConverter(),
                    new global::Synthesia.JsonConverters.CreateVideoRequestVisibilityNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.UpdateVideoMetadataRequestVisibilityJsonConverter(),
                    new global::Synthesia.JsonConverters.UpdateVideoMetadataRequestVisibilityNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.CreateWebhookRequestEventJsonConverter(),
                    new global::Synthesia.JsonConverters.CreateWebhookRequestEventNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.GetTemplatesSourceItemJsonConverter(),
                    new global::Synthesia.JsonConverters.GetTemplatesSourceItemNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.GetVideosSourceItemJsonConverter(),
                    new global::Synthesia.JsonConverters.GetVideosSourceItemNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.GetVideosXliffXliffVersionJsonConverter(),
                    new global::Synthesia.JsonConverters.GetVideosXliffXliffVersionNullableJsonConverter(),
                    new global::Synthesia.JsonConverters.TranslationsItemJsonConverter(),
                    new global::Synthesia.JsonConverters.AnyOfJsonConverter<global::Synthesia.DubbedAssetInProgress, global::Synthesia.DubbedAssetComplete, global::Synthesia.DubbedAssetError>(),
                    new global::Synthesia.JsonConverters.AnyOfJsonConverter<global::Synthesia.DubbedAssetInProgress, global::Synthesia.DubbedAssetComplete, global::Synthesia.DubbedAssetError>(),
                    new global::Synthesia.JsonConverters.AnyOfJsonConverter<global::Synthesia.DubbedAssetInProgress, global::Synthesia.DubbedAssetComplete, global::Synthesia.DubbedAssetError>(),
                    new global::Synthesia.JsonConverters.OneOfJsonConverter<global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetId, global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrl?>(),
                    new global::Synthesia.JsonConverters.OneOfJsonConverter<global::Synthesia.CreateDubbingProjectApiResponseFail, global::Synthesia.CreateDubbingResponse2>(),
                    new global::Synthesia.JsonConverters.OneOfJsonConverter<global::Synthesia.GetDubbingProjectVideosResponseUploading, global::Synthesia.GetDubbingProjectVideosResponseInProgress, global::Synthesia.GetDubbingProjectVideosResponseComplete, global::Synthesia.GetDubbingProjectVideosResponseError>(),
                    new global::Synthesia.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AssetsClient Assets => new AssetsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AuditLogsClient AuditLogs => new AuditLogsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DubbingClient Dubbing => new DubbingClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TemplatesClient Templates => new TemplatesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TranslationsClient Translations => new TranslationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public VideosClient Videos => new VideosClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public WebhooksClient Webhooks => new WebhooksClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the SynthesiaClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public SynthesiaClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Synthesia.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Synthesia.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}