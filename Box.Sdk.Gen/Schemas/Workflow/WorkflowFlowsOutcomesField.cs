using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class WorkflowFlowsOutcomesField {
        /// <summary>
        /// The identifier of the outcome
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// The outcomes resource type
        /// </summary>
        [JsonPropertyName("type")]
        public WorkflowFlowsOutcomesTypeField? Type { get; set; } = default;

        /// <summary>
        /// The name of the outcome
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        [JsonPropertyName("action_type")]
        public WorkflowFlowsOutcomesActionTypeField? ActionType { get; set; } = default;

        /// <summary>
        /// If `action_type` is `assign_task` and the task is rejected, returns a
        /// list of outcomes to complete
        /// </summary>
        [JsonPropertyName("if_rejected")]
        public IReadOnlyList<WorkflowFlowsOutcomesIfRejectedField>? IfRejected { get; set; } = default;

        public WorkflowFlowsOutcomesField() {
            
        }
    }
}