#nullable enable

namespace StepFun.JsonConverters
{
    /// <inheritdoc />
    public sealed class SpeechRequestStreamFormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::StepFun.SpeechRequestStreamFormat?>
    {
        /// <inheritdoc />
        public override global::StepFun.SpeechRequestStreamFormat? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::StepFun.SpeechRequestStreamFormatExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::StepFun.SpeechRequestStreamFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::StepFun.SpeechRequestStreamFormat?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::StepFun.SpeechRequestStreamFormat? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::StepFun.SpeechRequestStreamFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
