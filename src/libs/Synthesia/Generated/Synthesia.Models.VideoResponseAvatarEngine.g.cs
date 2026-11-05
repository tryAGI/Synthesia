
#nullable enable

namespace Synthesia
{
    /// <summary>
    /// The engine EXPRESS avatars are rendered with: `express_3`, also the default when omitted. Requires the expressive avatars API entitlement for the workspace.
    /// </summary>
    public enum VideoResponseAvatarEngine
    {
        /// <summary>
        /// `express_3`, also the default when omitted. Requires the expressive avatars API entitlement for the workspace.
        /// </summary>
        Express3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoResponseAvatarEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoResponseAvatarEngine value)
        {
            return value switch
            {
                VideoResponseAvatarEngine.Express3 => "express_3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoResponseAvatarEngine? ToEnum(string value)
        {
            return value switch
            {
                "express_3" => VideoResponseAvatarEngine.Express3,
                _ => null,
            };
        }
    }
}