
#nullable enable

namespace Synthesia
{
    /// <summary>
    /// 
    /// </summary>
    public enum DubbingAuthorizeAction
    {
        /// <summary>
        /// 
        /// </summary>
        Edit,
        /// <summary>
        /// 
        /// </summary>
        View,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DubbingAuthorizeActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DubbingAuthorizeAction value)
        {
            return value switch
            {
                DubbingAuthorizeAction.Edit => "edit",
                DubbingAuthorizeAction.View => "view",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DubbingAuthorizeAction? ToEnum(string value)
        {
            return value switch
            {
                "edit" => DubbingAuthorizeAction.Edit,
                "view" => DubbingAuthorizeAction.View,
                _ => null,
            };
        }
    }
}