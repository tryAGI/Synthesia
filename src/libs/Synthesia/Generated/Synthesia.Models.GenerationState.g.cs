
#nullable enable

namespace Synthesia
{
    /// <summary>
    ///
    /// </summary>
    public enum GenerationState
    {
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        ManualReview,
        /// <summary>
        ///
        /// </summary>
        Processing,
        /// <summary>
        ///
        /// </summary>
        Retrying,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationState value)
        {
            return value switch
            {
                GenerationState.Failed => "failed",
                GenerationState.ManualReview => "manual_review",
                GenerationState.Processing => "processing",
                GenerationState.Retrying => "retrying",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationState? ToEnum(string value)
        {
            return value switch
            {
                "failed" => GenerationState.Failed,
                "manual_review" => GenerationState.ManualReview,
                "processing" => GenerationState.Processing,
                "retrying" => GenerationState.Retrying,
                _ => null,
            };
        }
    }
}