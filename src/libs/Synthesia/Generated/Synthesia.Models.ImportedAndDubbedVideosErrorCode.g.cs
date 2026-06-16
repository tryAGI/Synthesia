
#nullable enable

namespace Synthesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImportedAndDubbedVideosErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        InvalidTargetLanguage,
        /// <summary>
        /// 
        /// </summary>
        Moderation,
        /// <summary>
        /// 
        /// </summary>
        ProcessingError,
        /// <summary>
        /// 
        /// </summary>
        VideoDurationLimitReached,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImportedAndDubbedVideosErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportedAndDubbedVideosErrorCode value)
        {
            return value switch
            {
                ImportedAndDubbedVideosErrorCode.InvalidTargetLanguage => "invalid_target_language",
                ImportedAndDubbedVideosErrorCode.Moderation => "moderation",
                ImportedAndDubbedVideosErrorCode.ProcessingError => "processing_error",
                ImportedAndDubbedVideosErrorCode.VideoDurationLimitReached => "video_duration_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportedAndDubbedVideosErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "invalid_target_language" => ImportedAndDubbedVideosErrorCode.InvalidTargetLanguage,
                "moderation" => ImportedAndDubbedVideosErrorCode.Moderation,
                "processing_error" => ImportedAndDubbedVideosErrorCode.ProcessingError,
                "video_duration_limit_reached" => ImportedAndDubbedVideosErrorCode.VideoDurationLimitReached,
                _ => null,
            };
        }
    }
}