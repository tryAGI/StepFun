
#nullable enable

namespace StepFun
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeechRequest
    {
        /// <summary>
        /// Supports step-tts-2, step-tts-mini, and stepaudio-2.5-tts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Voice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StepFun.JsonConverters.SpeechRequestResponseFormatJsonConverter))]
        public global::StepFun.SpeechRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public float? Speed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        public float? Volume { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        public string? Instruction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StepFun.JsonConverters.SpeechRequestStreamFormatJsonConverter))]
        public global::StepFun.SpeechRequestStreamFormat? StreamFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown_filter")]
        public bool? MarkdownFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_url")]
        public bool? ReturnUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_label")]
        public object? VoiceLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_map")]
        public global::System.Collections.Generic.IList<object>? PronunciationMap { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Supports step-tts-2, step-tts-mini, and stepaudio-2.5-tts.
        /// </param>
        /// <param name="input"></param>
        /// <param name="voice"></param>
        /// <param name="responseFormat"></param>
        /// <param name="speed"></param>
        /// <param name="volume"></param>
        /// <param name="instruction"></param>
        /// <param name="sampleRate"></param>
        /// <param name="streamFormat"></param>
        /// <param name="markdownFilter"></param>
        /// <param name="returnUrl"></param>
        /// <param name="voiceLabel"></param>
        /// <param name="pronunciationMap"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechRequest(
            string model,
            string input,
            string voice,
            global::StepFun.SpeechRequestResponseFormat? responseFormat,
            float? speed,
            float? volume,
            string? instruction,
            int? sampleRate,
            global::StepFun.SpeechRequestStreamFormat? streamFormat,
            bool? markdownFilter,
            bool? returnUrl,
            object? voiceLabel,
            global::System.Collections.Generic.IList<object>? pronunciationMap)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.ResponseFormat = responseFormat;
            this.Speed = speed;
            this.Volume = volume;
            this.Instruction = instruction;
            this.SampleRate = sampleRate;
            this.StreamFormat = streamFormat;
            this.MarkdownFilter = markdownFilter;
            this.ReturnUrl = returnUrl;
            this.VoiceLabel = voiceLabel;
            this.PronunciationMap = pronunciationMap;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechRequest" /> class.
        /// </summary>
        public SpeechRequest()
        {
        }

    }
}