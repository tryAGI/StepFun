/*
order: 10
title: Latest Text to Speech
slug: latest-text-to-speech

Generate speech end to end with StepAudio 2.5 TTS.
*/

namespace StepFun.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [Timeout(60_000)]
    public async Task Example_LatestTextToSpeech()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.Audio.CreateSpeechAsync(
            model: StepFunSpeechModels.StepAudio25Tts,
            input: "Hello from the latest StepFun speech model.",
            voice: "cixingnansheng",
            responseFormat: SpeechRequestResponseFormat.Mp3,
            returnUrl: true);

        response.Url.Should().NotBeNullOrWhiteSpace();
    }
}
