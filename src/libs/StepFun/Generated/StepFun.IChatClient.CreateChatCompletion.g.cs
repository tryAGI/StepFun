#nullable enable

namespace StepFun
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Create a chat completion
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StepFun.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::StepFun.ChatCompletionResponse> CreateChatCompletionAsync(

            global::StepFun.ChatCompletionRequest request,
            global::StepFun.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a chat completion
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StepFun.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::StepFun.AutoSDKHttpResponse<global::StepFun.ChatCompletionResponse>> CreateChatCompletionAsResponseAsync(

            global::StepFun.ChatCompletionRequest request,
            global::StepFun.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a chat completion
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::StepFun.ChatCompletionResponse> CreateChatCompletionAsync(
            string model,
            global::System.Collections.Generic.IList<global::StepFun.Message> messages,
            global::System.Collections.Generic.IList<global::StepFun.Tool>? tools = default,
            int? maxTokens = default,
            float? temperature = default,
            float? topP = default,
            int? n = default,
            bool? stream = default,
            global::StepFun.OneOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
            float? frequencyPenalty = default,
            global::StepFun.ResponseFormat? responseFormat = default,
            object? reasoningFormat = default,
            global::StepFun.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}