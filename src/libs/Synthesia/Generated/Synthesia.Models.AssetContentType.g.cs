
#nullable enable

namespace Synthesia
{
    /// <summary>
    /// AssetContentType specifies the MIME type of a particular asset, and provides some helper methods and properties
    /// </summary>
    public enum AssetContentType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividefontWoff,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividejson,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividepdf,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividevndMsPowerpoint,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividevndOpenxmlformatsOfficedocumentPresentationmlPresentation,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividevndSynthesiaFolder,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividevndSynthesiaFontFamily,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividevndSynthesiaStudioDubbedVideo,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividevndSynthesiaStudioImportedVideo,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividevndSynthesiaStudioPhotoAvatarVideo,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividevndSynthesiaStudioSynthesiaAcademyVideo,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividevndSynthesiaStudioSynthesiaDemoVideo,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividevndSynthesiaStudioSynthesiaExampleVideo,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividevndSynthesiaStudioSynthesiaFeatureOverviewVideo,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividevndSynthesiaStudioSynthesiaProcessedGif,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividevndSynthesiaStudioSynthesiaTemplate,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividevndSynthesiaStudioSynthesiaWelcomeWebinarVideo,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividevndSynthesiaStudioUserCourse,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividevndSynthesiaStudioUserTemplate,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividevndSynthesiaStudioVideo,
        /// <summary>
        /// 
        /// </summary>
        ApplicationDividexXliffPlusxml,
        /// <summary>
        /// 
        /// </summary>
        AudioDivideaac,
        /// <summary>
        /// 
        /// </summary>
        AudioDivideflac,
        /// <summary>
        /// 
        /// </summary>
        AudioDividemp4,
        /// <summary>
        /// 
        /// </summary>
        AudioDividempeg,
        /// <summary>
        /// 
        /// </summary>
        AudioDivideogg,
        /// <summary>
        /// 
        /// </summary>
        AudioDividewav,
        /// <summary>
        /// 
        /// </summary>
        AudioDividewebm,
        /// <summary>
        /// 
        /// </summary>
        FontDivideotf,
        /// <summary>
        /// 
        /// </summary>
        FontDividettf,
        /// <summary>
        /// 
        /// </summary>
        FontDividewoff,
        /// <summary>
        /// 
        /// </summary>
        FontDividewoff2,
        /// <summary>
        /// 
        /// </summary>
        ImageDividegif,
        /// <summary>
        /// 
        /// </summary>
        ImageDividejpeg,
        /// <summary>
        /// 
        /// </summary>
        ImageDividepng,
        /// <summary>
        /// 
        /// </summary>
        ImageDividesvgPlusxml,
        /// <summary>
        /// 
        /// </summary>
        ImageDividewebp,
        /// <summary>
        /// 
        /// </summary>
        TextDividecsv,
        /// <summary>
        /// 
        /// </summary>
        VideoDividemp4,
        /// <summary>
        /// 
        /// </summary>
        VideoDividequicktime,
        /// <summary>
        /// 
        /// </summary>
        VideoDividewebm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetContentType value)
        {
            return value switch
            {
                AssetContentType.ApplicationDividefontWoff => "application/font-woff",
                AssetContentType.ApplicationDividejson => "application/json",
                AssetContentType.ApplicationDividepdf => "application/pdf",
                AssetContentType.ApplicationDividevndMsPowerpoint => "application/vnd.ms-powerpoint",
                AssetContentType.ApplicationDividevndOpenxmlformatsOfficedocumentPresentationmlPresentation => "application/vnd.openxmlformats-officedocument.presentationml.presentation",
                AssetContentType.ApplicationDividevndSynthesiaFolder => "application/vnd.synthesia.folder",
                AssetContentType.ApplicationDividevndSynthesiaFontFamily => "application/vnd.synthesia.font-family",
                AssetContentType.ApplicationDividevndSynthesiaStudioDubbedVideo => "application/vnd.synthesia.studio-dubbed-video",
                AssetContentType.ApplicationDividevndSynthesiaStudioImportedVideo => "application/vnd.synthesia.studio-imported-video",
                AssetContentType.ApplicationDividevndSynthesiaStudioPhotoAvatarVideo => "application/vnd.synthesia.studio-photo-avatar-video",
                AssetContentType.ApplicationDividevndSynthesiaStudioSynthesiaAcademyVideo => "application/vnd.synthesia.studio-synthesia-academy-video",
                AssetContentType.ApplicationDividevndSynthesiaStudioSynthesiaDemoVideo => "application/vnd.synthesia.studio-synthesia-demo-video",
                AssetContentType.ApplicationDividevndSynthesiaStudioSynthesiaExampleVideo => "application/vnd.synthesia.studio-synthesia-example-video",
                AssetContentType.ApplicationDividevndSynthesiaStudioSynthesiaFeatureOverviewVideo => "application/vnd.synthesia.studio-synthesia-feature-overview-video",
                AssetContentType.ApplicationDividevndSynthesiaStudioSynthesiaProcessedGif => "application/vnd.synthesia.studio-synthesia-processed-gif",
                AssetContentType.ApplicationDividevndSynthesiaStudioSynthesiaTemplate => "application/vnd.synthesia.studio-synthesia-template",
                AssetContentType.ApplicationDividevndSynthesiaStudioSynthesiaWelcomeWebinarVideo => "application/vnd.synthesia.studio-synthesia-welcome-webinar-video",
                AssetContentType.ApplicationDividevndSynthesiaStudioUserCourse => "application/vnd.synthesia.studio-user-course",
                AssetContentType.ApplicationDividevndSynthesiaStudioUserTemplate => "application/vnd.synthesia.studio-user-template",
                AssetContentType.ApplicationDividevndSynthesiaStudioVideo => "application/vnd.synthesia.studio-video",
                AssetContentType.ApplicationDividexXliffPlusxml => "application/x-xliff+xml",
                AssetContentType.AudioDivideaac => "audio/aac",
                AssetContentType.AudioDivideflac => "audio/flac",
                AssetContentType.AudioDividemp4 => "audio/mp4",
                AssetContentType.AudioDividempeg => "audio/mpeg",
                AssetContentType.AudioDivideogg => "audio/ogg",
                AssetContentType.AudioDividewav => "audio/wav",
                AssetContentType.AudioDividewebm => "audio/webm",
                AssetContentType.FontDivideotf => "font/otf",
                AssetContentType.FontDividettf => "font/ttf",
                AssetContentType.FontDividewoff => "font/woff",
                AssetContentType.FontDividewoff2 => "font/woff2",
                AssetContentType.ImageDividegif => "image/gif",
                AssetContentType.ImageDividejpeg => "image/jpeg",
                AssetContentType.ImageDividepng => "image/png",
                AssetContentType.ImageDividesvgPlusxml => "image/svg+xml",
                AssetContentType.ImageDividewebp => "image/webp",
                AssetContentType.TextDividecsv => "text/csv",
                AssetContentType.VideoDividemp4 => "video/mp4",
                AssetContentType.VideoDividequicktime => "video/quicktime",
                AssetContentType.VideoDividewebm => "video/webm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetContentType? ToEnum(string value)
        {
            return value switch
            {
                "application/font-woff" => AssetContentType.ApplicationDividefontWoff,
                "application/json" => AssetContentType.ApplicationDividejson,
                "application/pdf" => AssetContentType.ApplicationDividepdf,
                "application/vnd.ms-powerpoint" => AssetContentType.ApplicationDividevndMsPowerpoint,
                "application/vnd.openxmlformats-officedocument.presentationml.presentation" => AssetContentType.ApplicationDividevndOpenxmlformatsOfficedocumentPresentationmlPresentation,
                "application/vnd.synthesia.folder" => AssetContentType.ApplicationDividevndSynthesiaFolder,
                "application/vnd.synthesia.font-family" => AssetContentType.ApplicationDividevndSynthesiaFontFamily,
                "application/vnd.synthesia.studio-dubbed-video" => AssetContentType.ApplicationDividevndSynthesiaStudioDubbedVideo,
                "application/vnd.synthesia.studio-imported-video" => AssetContentType.ApplicationDividevndSynthesiaStudioImportedVideo,
                "application/vnd.synthesia.studio-photo-avatar-video" => AssetContentType.ApplicationDividevndSynthesiaStudioPhotoAvatarVideo,
                "application/vnd.synthesia.studio-synthesia-academy-video" => AssetContentType.ApplicationDividevndSynthesiaStudioSynthesiaAcademyVideo,
                "application/vnd.synthesia.studio-synthesia-demo-video" => AssetContentType.ApplicationDividevndSynthesiaStudioSynthesiaDemoVideo,
                "application/vnd.synthesia.studio-synthesia-example-video" => AssetContentType.ApplicationDividevndSynthesiaStudioSynthesiaExampleVideo,
                "application/vnd.synthesia.studio-synthesia-feature-overview-video" => AssetContentType.ApplicationDividevndSynthesiaStudioSynthesiaFeatureOverviewVideo,
                "application/vnd.synthesia.studio-synthesia-processed-gif" => AssetContentType.ApplicationDividevndSynthesiaStudioSynthesiaProcessedGif,
                "application/vnd.synthesia.studio-synthesia-template" => AssetContentType.ApplicationDividevndSynthesiaStudioSynthesiaTemplate,
                "application/vnd.synthesia.studio-synthesia-welcome-webinar-video" => AssetContentType.ApplicationDividevndSynthesiaStudioSynthesiaWelcomeWebinarVideo,
                "application/vnd.synthesia.studio-user-course" => AssetContentType.ApplicationDividevndSynthesiaStudioUserCourse,
                "application/vnd.synthesia.studio-user-template" => AssetContentType.ApplicationDividevndSynthesiaStudioUserTemplate,
                "application/vnd.synthesia.studio-video" => AssetContentType.ApplicationDividevndSynthesiaStudioVideo,
                "application/x-xliff+xml" => AssetContentType.ApplicationDividexXliffPlusxml,
                "audio/aac" => AssetContentType.AudioDivideaac,
                "audio/flac" => AssetContentType.AudioDivideflac,
                "audio/mp4" => AssetContentType.AudioDividemp4,
                "audio/mpeg" => AssetContentType.AudioDividempeg,
                "audio/ogg" => AssetContentType.AudioDivideogg,
                "audio/wav" => AssetContentType.AudioDividewav,
                "audio/webm" => AssetContentType.AudioDividewebm,
                "font/otf" => AssetContentType.FontDivideotf,
                "font/ttf" => AssetContentType.FontDividettf,
                "font/woff" => AssetContentType.FontDividewoff,
                "font/woff2" => AssetContentType.FontDividewoff2,
                "image/gif" => AssetContentType.ImageDividegif,
                "image/jpeg" => AssetContentType.ImageDividejpeg,
                "image/png" => AssetContentType.ImageDividepng,
                "image/svg+xml" => AssetContentType.ImageDividesvgPlusxml,
                "image/webp" => AssetContentType.ImageDividewebp,
                "text/csv" => AssetContentType.TextDividecsv,
                "video/mp4" => AssetContentType.VideoDividemp4,
                "video/quicktime" => AssetContentType.VideoDividequicktime,
                "video/webm" => AssetContentType.VideoDividewebm,
                _ => null,
            };
        }
    }
}