
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
            typeof(global::Synthesia.JsonConverters.DubbingOutputLanguageJsonConverter),

            typeof(global::Synthesia.JsonConverters.DubbingOutputLanguageNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.AddLocalesToDubbingProjectRequestVideoDurationJsonConverter),

            typeof(global::Synthesia.JsonConverters.AddLocalesToDubbingProjectRequestVideoDurationNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.AddLocalesToDubbingProjectRequestVisibilityJsonConverter),

            typeof(global::Synthesia.JsonConverters.AddLocalesToDubbingProjectRequestVisibilityNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.DubbingAssetRequestConfigurationNameJsonConverter),

            typeof(global::Synthesia.JsonConverters.DubbingAssetRequestConfigurationNameNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.CreateAssetRequestContentTypeJsonConverter),

            typeof(global::Synthesia.JsonConverters.CreateAssetRequestContentTypeNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.CreateAssetRequestConfigurationDiscriminatorNameJsonConverter),

            typeof(global::Synthesia.JsonConverters.CreateAssetRequestConfigurationDiscriminatorNameNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.DubbingInputLanguageJsonConverter),

            typeof(global::Synthesia.JsonConverters.DubbingInputLanguageNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.CreateDubbingProjectApiRequestFromSourceAssetIdVideoDurationJsonConverter),

            typeof(global::Synthesia.JsonConverters.CreateDubbingProjectApiRequestFromSourceAssetIdVideoDurationNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.CreateDubbingProjectApiRequestFromSourceAssetIdVisibilityJsonConverter),

            typeof(global::Synthesia.JsonConverters.CreateDubbingProjectApiRequestFromSourceAssetIdVisibilityNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDurationJsonConverter),

            typeof(global::Synthesia.JsonConverters.CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDurationNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibilityJsonConverter),

            typeof(global::Synthesia.JsonConverters.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibilityNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.UpsertVideoTranslationsApiRequestAutoGenerateJsonConverter),

            typeof(global::Synthesia.JsonConverters.UpsertVideoTranslationsApiRequestAutoGenerateNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.PublicApiImportedAndDubbedVideosErrorCodeJsonConverter),

            typeof(global::Synthesia.JsonConverters.PublicApiImportedAndDubbedVideosErrorCodeNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.DubbedAssetCompleteStatusJsonConverter),

            typeof(global::Synthesia.JsonConverters.DubbedAssetCompleteStatusNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.DubbedAssetCompleteVisibilityJsonConverter),

            typeof(global::Synthesia.JsonConverters.DubbedAssetCompleteVisibilityNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.DubbedAssetErrorStatusJsonConverter),

            typeof(global::Synthesia.JsonConverters.DubbedAssetErrorStatusNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.DubbedAssetInProgressStatusJsonConverter),

            typeof(global::Synthesia.JsonConverters.DubbedAssetInProgressStatusNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.AssetContentTypeJsonConverter),

            typeof(global::Synthesia.JsonConverters.AssetContentTypeNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.LanguageBCP47JsonConverter),

            typeof(global::Synthesia.JsonConverters.LanguageBCP47NullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.PublicApiUserUploadedAssetErrorCodesJsonConverter),

            typeof(global::Synthesia.JsonConverters.PublicApiUserUploadedAssetErrorCodesNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.PublicApiUserUploadedAssetStatusJsonConverter),

            typeof(global::Synthesia.JsonConverters.PublicApiUserUploadedAssetStatusNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseUploadingStatusJsonConverter),

            typeof(global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseUploadingStatusNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseInProgressStatusJsonConverter),

            typeof(global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseInProgressStatusNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseCompleteStatusJsonConverter),

            typeof(global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseCompleteStatusNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseErrorStatusJsonConverter),

            typeof(global::Synthesia.JsonConverters.GetDubbingProjectVideosResponseErrorStatusNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.ActorTypeJsonConverter),

            typeof(global::Synthesia.JsonConverters.ActorTypeNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.TargetTypeJsonConverter),

            typeof(global::Synthesia.JsonConverters.TargetTypeNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.UpsertVideoTranslationsRunningWorkflowApiItemStatusJsonConverter),

            typeof(global::Synthesia.JsonConverters.UpsertVideoTranslationsRunningWorkflowApiItemStatusNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.UpsertVideoTranslationsRunningWorkflowApiItemStepJsonConverter),

            typeof(global::Synthesia.JsonConverters.UpsertVideoTranslationsRunningWorkflowApiItemStepNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.TranslationStatusApiItemErrorStatusJsonConverter),

            typeof(global::Synthesia.JsonConverters.TranslationStatusApiItemErrorStatusNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.TranslationStatusApiItemErrorErrorCodeJsonConverter),

            typeof(global::Synthesia.JsonConverters.TranslationStatusApiItemErrorErrorCodeNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.TranslationStatusApiItemSuccessStatusJsonConverter),

            typeof(global::Synthesia.JsonConverters.TranslationStatusApiItemSuccessStatusNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.TranslationStatusApiItemSuccessStepJsonConverter),

            typeof(global::Synthesia.JsonConverters.TranslationStatusApiItemSuccessStepNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.GetVideoTranslationsApiResponseTranslationDiscriminatorStatusJsonConverter),

            typeof(global::Synthesia.JsonConverters.GetVideoTranslationsApiResponseTranslationDiscriminatorStatusNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.TemplateResponseVisibilityJsonConverter),

            typeof(global::Synthesia.JsonConverters.TemplateResponseVisibilityNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.ActorSettingsHorizontalAlignJsonConverter),

            typeof(global::Synthesia.JsonConverters.ActorSettingsHorizontalAlignNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.ActorSettingsStyleJsonConverter),

            typeof(global::Synthesia.JsonConverters.ActorSettingsStyleNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.InputVideoBackgroundSettingsShortBackgroundContentMatchModeJsonConverter),

            typeof(global::Synthesia.JsonConverters.InputVideoBackgroundSettingsShortBackgroundContentMatchModeNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.InputVideoBackgroundSettingsLongBackgroundContentMatchModeJsonConverter),

            typeof(global::Synthesia.JsonConverters.InputVideoBackgroundSettingsLongBackgroundContentMatchModeNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.InputScriptLanguageJsonConverter),

            typeof(global::Synthesia.JsonConverters.InputScriptLanguageNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.InputTransitionJsonConverter),

            typeof(global::Synthesia.JsonConverters.InputTransitionNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.VideoResponseAspectRatioJsonConverter),

            typeof(global::Synthesia.JsonConverters.VideoResponseAspectRatioNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.VideoResponseSoundtrackJsonConverter),

            typeof(global::Synthesia.JsonConverters.VideoResponseSoundtrackNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.VideoResponseVisibilityJsonConverter),

            typeof(global::Synthesia.JsonConverters.VideoResponseVisibilityNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.VideoResponseStatusJsonConverter),

            typeof(global::Synthesia.JsonConverters.VideoResponseStatusNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.VideoFromTemplateApiVisibilityJsonConverter),

            typeof(global::Synthesia.JsonConverters.VideoFromTemplateApiVisibilityNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.CreateVideoRequestAspectRatioJsonConverter),

            typeof(global::Synthesia.JsonConverters.CreateVideoRequestAspectRatioNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.CreateVideoRequestSoundtrackJsonConverter),

            typeof(global::Synthesia.JsonConverters.CreateVideoRequestSoundtrackNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.CreateVideoRequestVisibilityJsonConverter),

            typeof(global::Synthesia.JsonConverters.CreateVideoRequestVisibilityNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.UpdateVideoMetadataRequestVisibilityJsonConverter),

            typeof(global::Synthesia.JsonConverters.UpdateVideoMetadataRequestVisibilityNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.CreateWebhookRequestEventJsonConverter),

            typeof(global::Synthesia.JsonConverters.CreateWebhookRequestEventNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.GetTemplatesSourceItemJsonConverter),

            typeof(global::Synthesia.JsonConverters.GetTemplatesSourceItemNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.GetVideosSourceItemJsonConverter),

            typeof(global::Synthesia.JsonConverters.GetVideosSourceItemNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.GetVideosXliffXliffVersionJsonConverter),

            typeof(global::Synthesia.JsonConverters.GetVideosXliffXliffVersionNullableJsonConverter),

            typeof(global::Synthesia.JsonConverters.TranslationsItemJsonConverter),

            typeof(global::Synthesia.JsonConverters.AnyOfJsonConverter<global::Synthesia.DubbedAssetInProgress, global::Synthesia.DubbedAssetComplete, global::Synthesia.DubbedAssetError>),

            typeof(global::Synthesia.JsonConverters.AnyOfJsonConverter<global::Synthesia.DubbedAssetInProgress, global::Synthesia.DubbedAssetComplete, global::Synthesia.DubbedAssetError>),

            typeof(global::Synthesia.JsonConverters.AnyOfJsonConverter<global::Synthesia.DubbedAssetInProgress, global::Synthesia.DubbedAssetComplete, global::Synthesia.DubbedAssetError>),

            typeof(global::Synthesia.JsonConverters.OneOfJsonConverter<global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetId, global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrl?>),

            typeof(global::Synthesia.JsonConverters.OneOfJsonConverter<global::Synthesia.CreateDubbingProjectApiResponseFail, global::Synthesia.CreateDubbingResponse2>),

            typeof(global::Synthesia.JsonConverters.OneOfJsonConverter<global::Synthesia.GetDubbingProjectVideosResponseUploading, global::Synthesia.GetDubbingProjectVideosResponseInProgress, global::Synthesia.GetDubbingProjectVideosResponseComplete, global::Synthesia.GetDubbingProjectVideosResponseError>),

            typeof(global::Synthesia.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbingOutputLanguage), TypeInfoPropertyName = "DubbingOutputLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.AddLocalesToDubbingProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Synthesia.DubbingOutputLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.AddLocalesToDubbingProjectRequestVideoDuration), TypeInfoPropertyName = "AddLocalesToDubbingProjectRequestVideoDuration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.AddLocalesToDubbingProjectRequestVisibility), TypeInfoPropertyName = "AddLocalesToDubbingProjectRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbingAssetRequestConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbingAssetRequestConfigurationName), TypeInfoPropertyName = "DubbingAssetRequestConfigurationName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateAssetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateAssetRequestContentType), TypeInfoPropertyName = "CreateAssetRequestContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateAssetRequestConfigurationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateAssetRequestConfigurationDiscriminatorName), TypeInfoPropertyName = "CreateAssetRequestConfigurationDiscriminatorName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbingInputLanguage), TypeInfoPropertyName = "DubbingInputLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetIdVideoDuration), TypeInfoPropertyName = "CreateDubbingProjectApiRequestFromSourceAssetIdVideoDuration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetIdVisibility), TypeInfoPropertyName = "CreateDubbingProjectApiRequestFromSourceAssetIdVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDuration), TypeInfoPropertyName = "CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDuration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility), TypeInfoPropertyName = "CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.AuditLogsQueryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.AuditLogsExportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.UpsertVideoTranslationsApiRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.UpsertVideoTranslationsApiRequestAutoGenerate), TypeInfoPropertyName = "UpsertVideoTranslationsApiRequestAutoGenerate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.DubbedVideosApiError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.PublicApiImportedAndDubbedVideosErrorCode), TypeInfoPropertyName = "PublicApiImportedAndDubbedVideosErrorCode2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.MultipartUploadCredentialsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateAssetMultipartUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateDubbingProjectApiResponseFail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.ImportedAssetId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateDubbingProjectApiResponseSuccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.AssetContentType), TypeInfoPropertyName = "AssetContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetPublicApiMediaAssetMetadataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.LanguageBCP47), TypeInfoPropertyName = "LanguageBCP472")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.PublicApiUserUploadedAssetErrorCodes), TypeInfoPropertyName = "PublicApiUserUploadedAssetErrorCodes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.PublicApiUserUploadedAssetStatus), TypeInfoPropertyName = "PublicApiUserUploadedAssetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetPublicApiUserUploadedAssetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetDubbingProjectVideosResponseUploading))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetDubbingProjectVideosResponseUploadingStatus), TypeInfoPropertyName = "GetDubbingProjectVideosResponseUploadingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetDubbingProjectVideosResponseInProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetDubbingProjectVideosResponseInProgressStatus), TypeInfoPropertyName = "GetDubbingProjectVideosResponseInProgressStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetDubbingProjectVideosResponseComplete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetDubbingProjectVideosResponseCompleteStatus), TypeInfoPropertyName = "GetDubbingProjectVideosResponseCompleteStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetDubbingProjectVideosResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetDubbingProjectVideosResponseErrorStatus), TypeInfoPropertyName = "GetDubbingProjectVideosResponseErrorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.Actor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.ActorType), TypeInfoPropertyName = "ActorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.AuditLogEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.Target))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.Context))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.Metadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.TargetType), TypeInfoPropertyName = "TargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.AuditLogsPageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Synthesia.AuditLogEvent>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.TemplateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.TemplateResponseVisibility), TypeInfoPropertyName = "TemplateResponseVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.TemplateListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Synthesia.TemplateResponse>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoThumbnailTypesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoResponseAspectRatio), TypeInfoPropertyName = "VideoResponseAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Synthesia.Input>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoResponseSoundtrack), TypeInfoPropertyName = "VideoResponseSoundtrack2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoResponseVisibility), TypeInfoPropertyName = "VideoResponseVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.VideoResponseStatus), TypeInfoPropertyName = "VideoResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateTranslatedVideoFromXliffRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateTranslatedVideoFromXliffResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.WebhookResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.WebhookListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Synthesia.WebhookResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateWebhookRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Synthesia.CreateWebhookRequestEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateWebhookRequestEvent), TypeInfoPropertyName = "CreateWebhookRequestEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.OneOf<global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetId, global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrl?>), TypeInfoPropertyName = "OneOfCreateDubbingProjectApiRequestFromSourceAssetIdCreateDubbingProjectApiRequestFromSourceVideoUrl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Synthesia.GetTemplatesSourceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetTemplatesSourceItem), TypeInfoPropertyName = "GetTemplatesSourceItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Synthesia.GetVideosSourceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetVideosSourceItem), TypeInfoPropertyName = "GetVideosSourceItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.GetVideosXliffXliffVersion), TypeInfoPropertyName = "GetVideosXliffXliffVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.OneOf<global::Synthesia.CreateDubbingProjectApiResponseFail, global::Synthesia.CreateDubbingResponse2>), TypeInfoPropertyName = "OneOfCreateDubbingProjectApiResponseFailCreateDubbingResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateDubbingResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.CreateDubbingResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Synthesia.OneOf<global::Synthesia.GetDubbingProjectVideosResponseUploading, global::Synthesia.GetDubbingProjectVideosResponseInProgress, global::Synthesia.GetDubbingProjectVideosResponseComplete, global::Synthesia.GetDubbingProjectVideosResponseError>), TypeInfoPropertyName = "OneOfGetDubbingProjectVideosResponseUploadingGetDubbingProjectVideosResponseInProgressGetDubbingProjectVideosResponseCompleteGetDubbingProjectVideosResponseError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Synthesia.DubbingOutputLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Synthesia.DubbedVideosApiError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Synthesia.AnyOf<global::Synthesia.DubbedAssetInProgress, global::Synthesia.DubbedAssetComplete, global::Synthesia.DubbedAssetError>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Synthesia.AuditLogEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Synthesia.TranslationsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Synthesia.TemplateResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Synthesia.ParentSoundtrackRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Synthesia.Input>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Synthesia.VideoResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Synthesia.WebhookResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Synthesia.CreateWebhookRequestEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Synthesia.GetTemplatesSourceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Synthesia.GetVideosSourceItem>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}