
#nullable enable

namespace StepFun
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::StepFun.ModelObject>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelListResponse" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelListResponse(
            string? @object,
            global::System.Collections.Generic.IList<global::StepFun.ModelObject>? data)
        {
            this.Object = @object;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelListResponse" /> class.
        /// </summary>
        public ModelListResponse()
        {
        }
    }
}