
#nullable enable

namespace StepFun
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpeechRequestResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Flac,
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Opus,
        /// <summary>
        /// 
        /// </summary>
        Pcm,
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechRequestResponseFormat value)
        {
            return value switch
            {
                SpeechRequestResponseFormat.Flac => "flac",
                SpeechRequestResponseFormat.Mp3 => "mp3",
                SpeechRequestResponseFormat.Opus => "opus",
                SpeechRequestResponseFormat.Pcm => "pcm",
                SpeechRequestResponseFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechRequestResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "flac" => SpeechRequestResponseFormat.Flac,
                "mp3" => SpeechRequestResponseFormat.Mp3,
                "opus" => SpeechRequestResponseFormat.Opus,
                "pcm" => SpeechRequestResponseFormat.Pcm,
                "wav" => SpeechRequestResponseFormat.Wav,
                _ => null,
            };
        }
    }
}