
#nullable enable

namespace StepFun
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentPart
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public object? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        public object? VideoUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio")]
        public object? InputAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentPart" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="text"></param>
        /// <param name="imageUrl"></param>
        /// <param name="videoUrl"></param>
        /// <param name="inputAudio"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentPart(
            string? type,
            string? text,
            object? imageUrl,
            object? videoUrl,
            object? inputAudio)
        {
            this.Type = type;
            this.Text = text;
            this.ImageUrl = imageUrl;
            this.VideoUrl = videoUrl;
            this.InputAudio = inputAudio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentPart" /> class.
        /// </summary>
        public ContentPart()
        {
        }
    }
}