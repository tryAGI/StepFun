#nullable enable

namespace StepFun
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Retrieve a model
        /// </summary>
        /// <param name="model"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StepFun.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::StepFun.ModelObject> RetrieveModelAsync(
            string model,
            global::StepFun.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}