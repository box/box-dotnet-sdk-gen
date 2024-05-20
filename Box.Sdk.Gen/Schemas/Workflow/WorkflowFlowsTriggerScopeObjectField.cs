using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class WorkflowFlowsTriggerScopeObjectField {
        /// <summary>
        /// The type of the object
        /// </summary>
        [JsonPropertyName("type")]
        public WorkflowFlowsTriggerScopeObjectTypeField? Type { get; init; }

        /// <summary>
        /// The id of the object
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        public WorkflowFlowsTriggerScopeObjectField() {
            
        }
    }
}