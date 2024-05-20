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
        public string? Id { get; init; }

        /// <summary>
        /// The outcomes resource type
        /// </summary>
        [JsonPropertyName("type")]
        public WorkflowFlowsOutcomesIfRejectedTypeField? Type { get; init; }

        /// <summary>
        /// The name of the outcome
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        [JsonPropertyName("action_type")]
        public WorkflowFlowsOutcomesIfRejectedActionTypeField? ActionType { get; init; }

        public WorkflowFlowsOutcomesIfRejectedField() {
            
        }
    }
}