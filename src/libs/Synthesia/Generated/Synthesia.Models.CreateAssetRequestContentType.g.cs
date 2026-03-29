
#nullable enable

namespace Synthesia
{
    /// <summary>
    /// The content type of the asset to upload. Must be one of: video/mp4, video/webm, or video/quicktime.<br/>
    /// Example: video/mp4
    /// </summary>
    public enum CreateAssetRequestContentType
    {
        /// <summary>
        /// video/mp4, video/webm, or video/quicktime.
        /// </summary>
        VideoDividemp4,
        /// <summary>
        /// video/mp4, video/webm, or video/quicktime.
        /// </summary>
        VideoDividequicktime,
        /// <summary>
        /// video/mp4, video/webm, or video/quicktime.
        /// </summary>
        VideoDividewebm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAssetRequestContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetRequestContentType value)
        {
            return value switch
            {
                CreateAssetRequestContentType.VideoDividemp4 => "video/mp4",
                CreateAssetRequestContentType.VideoDividequicktime => "video/quicktime",
                CreateAssetRequestContentType.VideoDividewebm => "video/webm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetRequestContentType? ToEnum(string value)
        {
            return value switch
            {
                "video/mp4" => CreateAssetRequestContentType.VideoDividemp4,
                "video/quicktime" => CreateAssetRequestContentType.VideoDividequicktime,
                "video/webm" => CreateAssetRequestContentType.VideoDividewebm,
                _ => null,
            };
        }
    }
}