using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class WorkflowFlowsTriggerScopeField {
        /// <summary>
        /// The trigger scope's resource type
        /// </summary>
        [JsonPropertyName("type")]
        public WorkflowFlowsTriggerScopeTypeField? Type { get; init; }

        /// <summary>
        /// Indicates the path of the condition value to check
        /// </summary>
        [JsonPropertyName("ref")]
        public string? Ref { get; init; }

        /// <summary>
        /// The object the `ref` points to
        /// </summary>
        [JsonPropertyName("object")]
        public WorkflowFlowsTriggerScopeObjectField? Object { get; init; }

        public WorkflowFlowsTriggerScopeField() {
            
        }
    }
}