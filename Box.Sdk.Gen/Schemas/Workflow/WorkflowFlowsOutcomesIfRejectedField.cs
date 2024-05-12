using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class WorkflowFlowsOutcomesIfRejectedField {
        /// <summary>
        /// The identifier of the outcome
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// The outcomes resource type
        /// </summary>
        [JsonPropertyName("type")]
        public WorkflowFlowsOutcomesIfRejectedTypeField? Type { get; set; } = default;

        /// <summary>
        /// The name of the outcome
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        [JsonPropertyName("action_type")]
        public WorkflowFlowsOutcomesIfRejectedActionTypeField? ActionType { get; set; } = default;

        public WorkflowFlowsOutcomesIfRejectedField() {
            
        }
    }
}