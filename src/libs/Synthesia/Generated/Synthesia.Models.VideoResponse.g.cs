
#nullable enable

namespace Synthesia
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoResponse
    {
        /// <summary>
        /// Downloadable captions files.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("captions")]
        public global::Synthesia.VideoAssetCaptionTypesResponse? Captions { get; set; }

        /// <summary>
        /// Optional folder ID. If provided, the new video will be created under this folder and inherit its permissions.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folderId")]
        public global::System.Guid? FolderId { get; set; }

        /// <summary>
        /// Aspect ratio of the video. Default is `landscape (16:9)`.<br/>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspectRatio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Synthesia.JsonConverters.VideoResponseAspectRatioJsonConverter))]
        public global::Synthesia.VideoResponseAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Settings for a call-to-action button.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ctaSettings")]
        public global::Synthesia.CtaSettings? CtaSettings { get; set; }

        /// <summary>
        /// Use callback ID to link videos back to the initial request. For example, if you are making a personalized video for a customer, you could enter the customer's email as a callback ID. This way, you can tell who the video is for, once its generated..
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callbackId")]
        public string? CallbackId { get; set; }

        /// <summary>
        /// Description of the video to be shown on the share page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// An array of objects that each describe a clip of a multi-clip video. You can think of the clips as different scenes in the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Synthesia.Input> Input { get; set; }

        /// <summary>
        /// soundtrack option is supported for backward compatibility. You should use the templates functionality for rich videos.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("soundtrack")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Synthesia.JsonConverters.VideoResponseSoundtrackJsonConverter))]
        public global::Synthesia.VideoResponseSoundtrack? Soundtrack { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("soundSettings")]
        public global::Synthesia.ParentSoundSettings? SoundSettings { get; set; }

        /// <summary>
        /// Test videos are free and not counted towards your quota. If you create a video in the “test” mode, we will overlay a watermark over your video.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test")]
        public bool? Test { get; set; }

        /// <summary>
        /// Title of the video to be shown on the share page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Public videos will be visible to anyone with a share URL.<br/>
        /// Private videos can only be downloaded via a time-limited download link. See Retrieve a video for details.<br/>
        /// Visibility can be changed also once the video is created via Update a video.<br/>
        /// Default Value: private
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Synthesia.JsonConverters.VideoResponseVisibilityJsonConverter))]
        public global::Synthesia.VideoResponseVisibility? Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download")]
        public string? Download { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public string? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUpdatedAt")]
        public int? LastUpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Synthesia.JsonConverters.VideoResponseStatusJsonConverter))]
        public global::Synthesia.VideoResponseStatus? Status { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail")]
        public global::Synthesia.VideoThumbnailTypesResponse? Thumbnail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoResponse" /> class.
        /// </summary>
        /// <param name="captions">
        /// Downloadable captions files.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="folderId">
        /// Optional folder ID. If provided, the new video will be created under this folder and inherit its permissions.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio of the video. Default is `landscape (16:9)`.<br/>
        /// Default Value: 16:9
        /// </param>
        /// <param name="ctaSettings">
        /// Settings for a call-to-action button.
        /// </param>
        /// <param name="callbackId">
        /// Use callback ID to link videos back to the initial request. For example, if you are making a personalized video for a customer, you could enter the customer's email as a callback ID. This way, you can tell who the video is for, once its generated..
        /// </param>
        /// <param name="description">
        /// Description of the video to be shown on the share page.
        /// </param>
        /// <param name="input">
        /// An array of objects that each describe a clip of a multi-clip video. You can think of the clips as different scenes in the video.
        /// </param>
        /// <param name="soundtrack">
        /// soundtrack option is supported for backward compatibility. You should use the templates functionality for rich videos.
        /// </param>
        /// <param name="soundSettings"></param>
        /// <param name="test">
        /// Test videos are free and not counted towards your quota. If you create a video in the “test” mode, we will overlay a watermark over your video.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="title">
        /// Title of the video to be shown on the share page.
        /// </param>
        /// <param name="visibility">
        /// Public videos will be visible to anyone with a share URL.<br/>
        /// Private videos can only be downloaded via a time-limited download link. See Retrieve a video for details.<br/>
        /// Visibility can be changed also once the video is created via Update a video.<br/>
        /// Default Value: private
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="download"></param>
        /// <param name="duration"></param>
        /// <param name="id"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="status"></param>
        /// <param name="thumbnail">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoResponse(
            global::System.Collections.Generic.IList<global::Synthesia.Input> input,
            global::Synthesia.VideoAssetCaptionTypesResponse? captions,
            global::System.Guid? folderId,
            global::Synthesia.VideoResponseAspectRatio? aspectRatio,
            global::Synthesia.CtaSettings? ctaSettings,
            string? callbackId,
            string? description,
            global::Synthesia.VideoResponseSoundtrack? soundtrack,
            global::Synthesia.ParentSoundSettings? soundSettings,
            bool? test,
            string? title,
            global::Synthesia.VideoResponseVisibility? visibility,
            int? createdAt,
            string? download,
            string? duration,
            global::System.Guid? id,
            int? lastUpdatedAt,
            global::Synthesia.VideoResponseStatus? status,
            global::Synthesia.VideoThumbnailTypesResponse? thumbnail)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Captions = captions;
            this.FolderId = folderId;
            this.AspectRatio = aspectRatio;
            this.CtaSettings = ctaSettings;
            this.CallbackId = callbackId;
            this.Description = description;
            this.Soundtrack = soundtrack;
            this.SoundSettings = soundSettings;
            this.Test = test;
            this.Title = title;
            this.Visibility = visibility;
            this.CreatedAt = createdAt;
            this.Download = download;
            this.Duration = duration;
            this.Id = id;
            this.LastUpdatedAt = lastUpdatedAt;
            this.Status = status;
            this.Thumbnail = thumbnail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoResponse" /> class.
        /// </summary>
        public VideoResponse()
        {
        }
    }
}