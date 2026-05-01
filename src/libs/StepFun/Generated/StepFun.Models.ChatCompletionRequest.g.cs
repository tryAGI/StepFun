
#nullable enable

namespace StepFun
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::StepFun.Message> Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::StepFun.Tool>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public float? TopP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::StepFun.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::StepFun.OneOf<string, global::System.Collections.Generic.IList<string>>? Stop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public float? FrequencyPenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::StepFun.ResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_format")]
        public object? ReasoningFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequest" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="messages"></param>
        /// <param name="tools"></param>
        /// <param name="maxTokens"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="n"></param>
        /// <param name="stream"></param>
        /// <param name="stop"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="responseFormat"></param>
        /// <param name="reasoningFormat"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequest(
            string model,
            global::System.Collections.Generic.IList<global::StepFun.Message> messages,
            global::System.Collections.Generic.IList<global::StepFun.Tool>? tools,
            int? maxTokens,
            float? temperature,
            float? topP,
            int? n,
            bool? stream,
            global::StepFun.OneOf<string, global::System.Collections.Generic.IList<string>>? stop,
            float? frequencyPenalty,
            global::StepFun.ResponseFormat? responseFormat,
            object? reasoningFormat)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Tools = tools;
            this.MaxTokens = maxTokens;
            this.Temperature = temperature;
            this.TopP = topP;
            this.N = n;
            this.Stream = stream;
            this.Stop = stop;
            this.FrequencyPenalty = frequencyPenalty;
            this.ResponseFormat = responseFormat;
            this.ReasoningFormat = reasoningFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequest" /> class.
        /// </summary>
        public ChatCompletionRequest()
        {
        }
    }
}