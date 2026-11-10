
#nullable enable

namespace Synthesia
{
    /// <summary>
    ///
    /// </summary>
    public enum DubbingGenerationStage
    {
        /// <summary>
        ///
        /// </summary>
        ApplyingLipsync,
        /// <summary>
        ///
        /// </summary>
        DetectingSpeakers,
        /// <summary>
        ///
        /// </summary>
        Finalizing,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Rendering,
        /// <summary>
        ///
        /// </summary>
        RetimingAudioVideo,
        /// <summary>
        ///
        /// </summary>
        SynthesizingAudio,
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
                DubbingGenerationStage.ApplyingLipsync => "applying_lipsync",
                DubbingGenerationStage.DetectingSpeakers => "detecting_speakers",
                DubbingGenerationStage.Finalizing => "finalizing",
                DubbingGenerationStage.Pending => "pending",
                DubbingGenerationStage.Rendering => "rendering",
                DubbingGenerationStage.RetimingAudioVideo => "retiming_audio_video",
                DubbingGenerationStage.SynthesizingAudio => "synthesizing_audio",
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
                "applying_lipsync" => DubbingGenerationStage.ApplyingLipsync,
                "detecting_speakers" => DubbingGenerationStage.DetectingSpeakers,
                "finalizing" => DubbingGenerationStage.Finalizing,
                "pending" => DubbingGenerationStage.Pending,
                "rendering" => DubbingGenerationStage.Rendering,
                "retiming_audio_video" => DubbingGenerationStage.RetimingAudioVideo,
                "synthesizing_audio" => DubbingGenerationStage.SynthesizingAudio,
                "translating" => DubbingGenerationStage.Translating,
                "waiting_for_import" => DubbingGenerationStage.WaitingForImport,
                _ => null,
            };
        }
    }
}