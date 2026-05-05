#nullable enable

namespace StepFun
{
    public partial interface ITokensClient
    {
        /// <summary>
        /// Count tokens for a conversation
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StepFun.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::StepFun.TokenCountResponse> CountTokensAsync(

            global::StepFun.TokenCountRequest request,
            global::StepFun.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Count tokens for a conversation
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StepFun.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::StepFun.AutoSDKHttpResponse<global::StepFun.TokenCountResponse>> CountTokensAsResponseAsync(

            global::StepFun.TokenCountRequest request,
            global::StepFun.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Count tokens for a conversation
        /// </summary>
        /// <param name="model"></param>
        /// <param name="messages"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::StepFun.TokenCountResponse> CountTokensAsync(
            string model,
            global::System.Collections.Generic.IList<global::StepFun.Message> messages,
            global::StepFun.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}