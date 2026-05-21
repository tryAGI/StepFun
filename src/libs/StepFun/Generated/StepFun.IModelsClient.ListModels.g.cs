#nullable enable

namespace StepFun
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List models
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StepFun.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::StepFun.ModelListResponse> ListModelsAsync(
            global::StepFun.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List models
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StepFun.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::StepFun.AutoSDKHttpResponse<global::StepFun.ModelListResponse>> ListModelsAsResponseAsync(
            global::StepFun.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}