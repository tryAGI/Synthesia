
#nullable enable

namespace Synthesia
{
    /// <summary>
    /// The stage of a dub's generation that the frontend shows.
    /// </summary>
    public enum DubbingGenerationStage
    {
        /// <summary>
        ///
        /// </summary>
        Finalizing,
        /// <summary>
        ///
        /// </summary>
        GeneratingAudio,
        /// <summary>
        ///
        /// </summary>
        GeneratingVideo,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Translating,
        /// <summary>
        ///
        /// </summary>
        WaitingForImport,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DubbingGenerationStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DubbingGenerationStage value)
        {
            return value switch
            {
                DubbingGenerationStage.Finalizing => "finalizing",
                DubbingGenerationStage.GeneratingAudio => "generating_audio",
                DubbingGenerationStage.GeneratingVideo => "generating_video",
                DubbingGenerationStage.Pending => "pending",
                DubbingGenerationStage.Translating => "translating",
                DubbingGenerationStage.WaitingForImport => "waiting_for_import",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DubbingGenerationStage? ToEnum(string value)
        {
            return value switch
            {
                "finalizing" => DubbingGenerationStage.Finalizing,
                "generating_audio" => DubbingGenerationStage.GeneratingAudio,
                "generating_video" => DubbingGenerationStage.GeneratingVideo,
                "pending" => DubbingGenerationStage.Pending,
                "translating" => DubbingGenerationStage.Translating,
                "waiting_for_import" => DubbingGenerationStage.WaitingForImport,
                _ => null,
            };
        }
    }
}