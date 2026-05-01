
#nullable enable

namespace StepFun
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpeechRequestStreamFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Sse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechRequestStreamFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechRequestStreamFormat value)
        {
            return value switch
            {
                SpeechRequestStreamFormat.Audio => "audio",
                SpeechRequestStreamFormat.Sse => "sse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechRequestStreamFormat? ToEnum(string value)
        {
            return value switch
            {
                "audio" => SpeechRequestStreamFormat.Audio,
                "sse" => SpeechRequestStreamFormat.Sse,
                _ => null,
            };
        }
    }
}