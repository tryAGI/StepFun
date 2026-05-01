
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace StepFun
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::StepFun.JsonConverters.SpeechRequestResponseFormatJsonConverter),

            typeof(global::StepFun.JsonConverters.SpeechRequestResponseFormatNullableJsonConverter),

            typeof(global::StepFun.JsonConverters.SpeechRequestStreamFormatJsonConverter),

            typeof(global::StepFun.JsonConverters.SpeechRequestStreamFormatNullableJsonConverter),

            typeof(global::StepFun.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::StepFun.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::StepFun.ContentPart>>),

            typeof(global::StepFun.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StepFun.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StepFun.ChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::StepFun.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StepFun.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::StepFun.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StepFun.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StepFun.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StepFun.ResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StepFun.TokenCountRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StepFun.TokenCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StepFun.TokenCountResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StepFun.SpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StepFun.SpeechRequestResponseFormat), TypeInfoPropertyName = "SpeechRequestResponseFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StepFun.SpeechRequestStreamFormat), TypeInfoPropertyName = "SpeechRequestStreamFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StepFun.SpeechResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StepFun.ModelListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::StepFun.ModelObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StepFun.ModelObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StepFun.OneOf<string, global::System.Collections.Generic.IList<global::StepFun.ContentPart>>), TypeInfoPropertyName = "OneOfStringIListContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::StepFun.ContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StepFun.ContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::StepFun.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StepFun.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StepFun.FunctionDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StepFun.FunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StepFun.ChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::StepFun.Choice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StepFun.Choice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StepFun.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::StepFun.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::StepFun.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StepFun.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::StepFun.ModelObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::StepFun.OneOf<string, global::System.Collections.Generic.List<global::StepFun.ContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::StepFun.ContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::StepFun.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::StepFun.Choice>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}