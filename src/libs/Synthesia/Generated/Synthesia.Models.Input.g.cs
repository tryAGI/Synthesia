
#nullable enable

namespace Synthesia
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Input
    {
        /// <summary>
        /// Use one of [Synthesia stock avatars or your custom avatar](https://developers.synthesia.io/docs/avatars). Accepts the avatar ID shown by "Copy ID" on an avatar in STUDIO, which renders that avatar's default look, or the ID of a specific look of an avatar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Avatar { get; set; }

        /// <summary>
        /// Avatar settings.<br/>
        /// Default Value: {"horizontalAlign":"center","scale":1.0,"style":"rectangular","voice":null,"seamless":false}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarSettings")]
        public global::Synthesia.ActorSettings? AvatarSettings { get; set; }

        /// <summary>
        /// Optional. Defaults to `off_white`. Applies to EXPRESS-1 avatars.<br/>
        /// **Deprecated for EXPRESS-3 avatars**: an EXPRESS-3 look carries its own outfit and setting (space), and a look with a space covers the whole frame, so the background has no visible effect. To choose the setting, pass that look's ID as `avatar`: in the Synthesia video editor, right-click the avatar and choose **Copy Avatar ID** (the Avatars page's **Copy ID** gives the avatar's default look). For a transparent or green-screen EXPRESS-3 avatar, pick **No space** in the editor's space picker before copying the ID: the background then shows behind the avatar, so set it to `green_screen`.<br/>
        /// Use Synthesia' stock backgrounds or your custom background. For the custom background, provide the ID of an uploaded asset (see [Create an asset](https://developers.synthesia.io/docs/create-an-asset)), or URL from where Synthesia should download the background.<br/>
        /// Transparent: `green_screen` Green screen background can be used if you want to replace background using FFMPEG or any of the video editing software.<br/>
        /// Solid: `off_white` / `warm_white` / `light_pink` / `soft_pink` / `light_blue` / `dark_blue` / `soft_cyan` / `strong_cyan` / `light_orange` / `soft_orange`<br/>
        /// Image: `white_studio` / `white_cafe` / `luxury_lobby` / `large_window` / `white_meeting_room` / `open_office`<br/>
        /// Default Value: off_white
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public string? Background { get; set; }

        /// <summary>
        /// Video Settings object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backgroundSettings")]
        public global::Synthesia.InputBackgroundSettings? BackgroundSettings { get; set; }

        /// <summary>
        /// As an alternative to `scriptText`, provide the ID of uploaded script audio. See [Upload script audio for details](https://developers.synthesia.io/docs/upload-script-audio).<br/>
        /// If you use `scriptAudio` you must provide `scriptLanguage`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scriptAudio")]
        public string? ScriptAudio { get; set; }

        /// <summary>
        /// Language code of the language the script audio was generated in. The scriptLanguage option must be used with `scriptAudio`.<br/>
        /// To control the language/voice of the scriptText, use `input[].avatarSettings.voice` option.<br/>
        /// Language code should be in the format: `en-US`, where the first two characters represent language and the second two-character represent the country.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scriptLanguage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Synthesia.JsonConverters.InputScriptLanguageJsonConverter))]
        public global::Synthesia.InputScriptLanguage? ScriptLanguage { get; set; }

        /// <summary>
        /// Script for text-to-voice can be entered in any of the [supported languages](https://developers.synthesia.io/docs/voices).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scriptText")]
        public string? ScriptText { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("soundSettings")]
        public global::Synthesia.InputSoundSettings? SoundSettings { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Synthesia.JsonConverters.InputTransitionJsonConverter))]
        public global::Synthesia.InputTransition? Transition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Input" /> class.
        /// </summary>
        /// <param name="avatar">
        /// Use one of [Synthesia stock avatars or your custom avatar](https://developers.synthesia.io/docs/avatars). Accepts the avatar ID shown by "Copy ID" on an avatar in STUDIO, which renders that avatar's default look, or the ID of a specific look of an avatar.
        /// </param>
        /// <param name="avatarSettings">
        /// Avatar settings.<br/>
        /// Default Value: {"horizontalAlign":"center","scale":1.0,"style":"rectangular","voice":null,"seamless":false}
        /// </param>
        /// <param name="background">
        /// Optional. Defaults to `off_white`. Applies to EXPRESS-1 avatars.<br/>
        /// **Deprecated for EXPRESS-3 avatars**: an EXPRESS-3 look carries its own outfit and setting (space), and a look with a space covers the whole frame, so the background has no visible effect. To choose the setting, pass that look's ID as `avatar`: in the Synthesia video editor, right-click the avatar and choose **Copy Avatar ID** (the Avatars page's **Copy ID** gives the avatar's default look). For a transparent or green-screen EXPRESS-3 avatar, pick **No space** in the editor's space picker before copying the ID: the background then shows behind the avatar, so set it to `green_screen`.<br/>
        /// Use Synthesia' stock backgrounds or your custom background. For the custom background, provide the ID of an uploaded asset (see [Create an asset](https://developers.synthesia.io/docs/create-an-asset)), or URL from where Synthesia should download the background.<br/>
        /// Transparent: `green_screen` Green screen background can be used if you want to replace background using FFMPEG or any of the video editing software.<br/>
        /// Solid: `off_white` / `warm_white` / `light_pink` / `soft_pink` / `light_blue` / `dark_blue` / `soft_cyan` / `strong_cyan` / `light_orange` / `soft_orange`<br/>
        /// Image: `white_studio` / `white_cafe` / `luxury_lobby` / `large_window` / `white_meeting_room` / `open_office`<br/>
        /// Default Value: off_white
        /// </param>
        /// <param name="backgroundSettings">
        /// Video Settings object
        /// </param>
        /// <param name="scriptAudio">
        /// As an alternative to `scriptText`, provide the ID of uploaded script audio. See [Upload script audio for details](https://developers.synthesia.io/docs/upload-script-audio).<br/>
        /// If you use `scriptAudio` you must provide `scriptLanguage`.
        /// </param>
        /// <param name="scriptLanguage">
        /// Language code of the language the script audio was generated in. The scriptLanguage option must be used with `scriptAudio`.<br/>
        /// To control the language/voice of the scriptText, use `input[].avatarSettings.voice` option.<br/>
        /// Language code should be in the format: `en-US`, where the first two characters represent language and the second two-character represent the country.
        /// </param>
        /// <param name="scriptText">
        /// Script for text-to-voice can be entered in any of the [supported languages](https://developers.synthesia.io/docs/voices).
        /// </param>
        /// <param name="soundSettings"></param>
        /// <param name="transition">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Input(
            string avatar,
            global::Synthesia.ActorSettings? avatarSettings,
            string? background,
            global::Synthesia.InputBackgroundSettings? backgroundSettings,
            string? scriptAudio,
            global::Synthesia.InputScriptLanguage? scriptLanguage,
            string? scriptText,
            global::Synthesia.InputSoundSettings? soundSettings,
            global::Synthesia.InputTransition? transition)
        {
            this.Avatar = avatar ?? throw new global::System.ArgumentNullException(nameof(avatar));
            this.AvatarSettings = avatarSettings;
            this.Background = background;
            this.BackgroundSettings = backgroundSettings;
            this.ScriptAudio = scriptAudio;
            this.ScriptLanguage = scriptLanguage;
            this.ScriptText = scriptText;
            this.SoundSettings = soundSettings;
            this.Transition = transition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Input" /> class.
        /// </summary>
        public Input()
        {
        }

    }
}