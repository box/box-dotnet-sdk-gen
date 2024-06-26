using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class WorkflowFlowsTriggerScopeObjectField {
        /// <summary>
        /// The type of the object
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<WorkflowFlowsTriggerScopeObjectTypeField>))]
        public StringEnum<WorkflowFlowsTriggerScopeObjectTypeField>? Type { get; init; }

        /// <summary>
        /// The id of the object
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        public WorkflowFlowsTriggerScopeObjectField() {
            
        }
    }
}