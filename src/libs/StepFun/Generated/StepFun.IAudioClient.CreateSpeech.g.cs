#nullable enable

namespace StepFun
{
    public partial interface IAudioClient
    {
        /// <summary>
        /// Generate speech from text
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::StepFun.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::StepFun.SpeechResponse> CreateSpeechAsync(

            global::StepFun.SpeechRequest request,
            global::StepFun.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate speech from text
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::StepFun.SpeechResponse> CreateSpeechAsync(
            string model,
            string input,
            string voice,
            global::StepFun.SpeechRequestResponseFormat? responseFormat = default,
            float? speed = default,
            float? volume = default,
            string? instruction = default,
            int? sampleRate = default,
            global::StepFun.SpeechRequestStreamFormat? streamFormat = default,
            bool? markdownFilter = default,
            bool? returnUrl = default,
            object? voiceLabel = default,
            global::System.Collections.Generic.IList<object>? pronunciationMap = default,
            global::StepFun.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}