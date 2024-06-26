using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;

namespace Box.Sdk.Gen.Schemas {
    public class WorkflowMini {
        /// <summary>
        /// The unique identifier for the workflow
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// `workflow`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<WorkflowMiniTypeField>))]
        public StringEnum<WorkflowMiniTypeField>? Type { get; init; }

        /// <summary>
        /// The name of the workflow
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        /// <summary>
        /// The description for a workflow.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; init; }

        /// <summary>
        /// Specifies if this workflow is enabled
        /// </summary>
        [JsonPropertyName("is_enabled")]
        public bool? IsEnabled { get; init; }

        public WorkflowMini() {
            
        }
    }
}