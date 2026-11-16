
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Synthesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.DubbingOutputLanguage? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.AddLocalesToDubbingProjectRequest? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Synthesia.DubbingOutputLanguage>? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.AddLocalesToDubbingProjectRequestVideoDuration? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.AddLocalesToDubbingProjectRequestVisibility? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.DubbingAssetRequestConfiguration? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.DubbingAssetRequestConfigurationName? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.CreateAssetRequest? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.CreateAssetRequestContentType? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.CreateAssetRequestConfigurationDiscriminator? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.CreateAssetRequestConfigurationDiscriminatorName? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.DubbingInputLanguage? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetId? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetIdVideoDuration? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetIdVisibility? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrl? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDuration? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.DubbingAuthorizeAction? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.DubbingAuthorizeRequest? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.AuditLogsQueryRequest? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.AuditLogsExportRequest? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.UpsertVideoTranslationsApiRequest? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.UpsertVideoTranslationsApiRequestAutoGenerate? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.GetDubbingAllowanceResponse? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.DubbingGenerationStage? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.GenerationState? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.DubbedVideoProgress? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.DubbingProjectVideoProgress? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.GetDubbingProjectProgressResponse? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Synthesia.DubbingProjectVideoProgress>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.DubbedVideosApiError? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.ImportedAndDubbedVideosErrorCode? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.DubbedAssetCaptions? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.DubbedAssetComplete? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.DubbedAssetCompleteStatus? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.DubbedAssetCompleteVisibility? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.DubbedAssetThumbnail? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.DubbedAssetError? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.DubbedAssetErrorStatus? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.DubbedAssetInProgress? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.DubbedAssetInProgressStatus? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.AddLocalesToDubbingProjectResponse? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Synthesia.DubbedVideosApiError>? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Synthesia.AnyOf<global::Synthesia.DubbedAssetInProgress, global::Synthesia.DubbedAssetComplete, global::Synthesia.DubbedAssetError>>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.AnyOf<global::Synthesia.DubbedAssetInProgress, global::Synthesia.DubbedAssetComplete, global::Synthesia.DubbedAssetError>? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.MultipartUploadCredentialsResponse? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.CreateAssetMultipartUploadResponse? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.CreateDubbingProjectApiResponseFail? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.ImportedAssetId? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.CreateDubbingProjectApiResponseSuccess? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.AssetContentType? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.GetPublicApiMediaAssetMetadataResponse? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.LanguageBCP47? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.PublicApiUserUploadedAssetErrorCodes? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.PublicApiUserUploadedAssetStatus? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.GetPublicApiUserUploadedAssetResponse? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.GetDubbingProjectVideosResponseUploading? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.GetDubbingProjectVideosResponseUploadingStatus? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.GetDubbingProjectVideosResponseInProgress? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.GetDubbingProjectVideosResponseInProgressStatus? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.GetDubbingProjectVideosResponseComplete? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.GetDubbingProjectVideosResponseCompleteStatus? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.GetDubbingProjectVideosResponseError? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.GetDubbingProjectVideosResponseErrorStatus? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.DubbingAuthorizeResponse? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.Actor? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.ActorType? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.AuditLogEvent? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.Target? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.Context? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.Metadata? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.TargetType? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.AuditLogsPageResponse? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Synthesia.AuditLogEvent>? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItem? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItemStatus? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItemStep? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.UpsertVideoTranslationsSuccessApiResponse? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItem>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.TranslationStatusApiItemError? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.TranslationStatusApiItemErrorStatus? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.TranslationStatusApiItemErrorErrorCode? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.TranslationStatusApiItemSuccess? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.TranslationStatusApiItemSuccessStatus? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.TranslationStatusApiItemSuccessStep? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.GetVideoTranslationsApiResponse? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Synthesia.TranslationsItem>? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.TranslationsItem? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminator? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.CtaSettings? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.TemplateResponse? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.TemplateResponseVisibility? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.TemplateResponseAvatarEngine? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.TemplateListResponse? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Synthesia.TemplateResponse>? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.Error? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.VideoFromTemplateApi? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.VideoFromTemplateApiVisibility? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.VideoFromTemplateApiAvatarEngine? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.VideoAssetCaptionTypesResponse? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.ActorSettings? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.ActorSettingsHorizontalAlign? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.ActorSettingsStyle? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.InputBackgroundPosition? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.InputBackgroundTrim? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.InputVideoBackgroundSettings? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.InputVideoBackgroundSettingsShortBackgroundContentMatchMode? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.InputVideoBackgroundSettingsLongBackgroundContentMatchMode? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.InputBackgroundSettings? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.InputSoundSettings? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.Input? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.InputScriptLanguage? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.InputTransition? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.ParentSoundtrackRegion? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.ParentSoundSettings? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Synthesia.ParentSoundtrackRegion>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.C2PAContentProvenanceResponse? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.ContentProvenanceResponse? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.VideoThumbnailTypesResponse? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.VideoResponse? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.VideoResponseAspectRatio? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Synthesia.Input>? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.VideoResponseSoundtrack? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.VideoResponseAvatarEngine? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.VideoResponseVisibility? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.VideoResponseStatus? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.VideoListResponse? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Synthesia.VideoResponse>? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.CreateVideoRequest? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.CreateVideoRequestAspectRatio? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.CreateVideoRequestSoundtrack? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.CreateVideoRequestAvatarEngine? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.CreateVideoRequestVisibility? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.UpdateVideoMetadataRequest? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.UpdateVideoMetadataRequestVisibility? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.VideoXliffResponse? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.WebhookResponse? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.WebhookListResponse? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Synthesia.WebhookResponse>? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.CreateWebhookRequest? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Synthesia.CreateWebhookRequestEvent>? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.CreateWebhookRequestEvent? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.CreateTranslatedVideoFromXliffRequest? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.CreateTranslatedVideoFromXliffResponse? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.OneOf<global::Synthesia.CreateDubbingProjectApiRequestFromSourceAssetId, global::Synthesia.CreateDubbingProjectApiRequestFromSourceVideoUrl?>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Synthesia.GetTemplatesSourceItem>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.GetTemplatesSourceItem? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Synthesia.GetVideosSourceItem>? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.GetVideosSourceItem? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.GetVideosXliffXliffVersion? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.OneOf<global::Synthesia.CreateDubbingProjectApiResponseFail, global::Synthesia.CreateDubbingResponse2>? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.CreateDubbingResponse2? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Synthesia.CreateDubbingResponse3? Type165 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Synthesia.DubbingOutputLanguage>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Synthesia.DubbingProjectVideoProgress>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Synthesia.DubbedVideosApiError>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Synthesia.AnyOf<global::Synthesia.DubbedAssetInProgress, global::Synthesia.DubbedAssetComplete, global::Synthesia.DubbedAssetError>>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Synthesia.AuditLogEvent>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Synthesia.UpsertVideoTranslationsRunningWorkflowApiItem>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Synthesia.TranslationsItem>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Synthesia.TemplateResponse>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Synthesia.ParentSoundtrackRegion>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Synthesia.Input>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Synthesia.VideoResponse>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Synthesia.WebhookResponse>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Synthesia.CreateWebhookRequestEvent>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Synthesia.GetTemplatesSourceItem>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Synthesia.GetVideosSourceItem>? ListType16 { get; set; }
    }
}