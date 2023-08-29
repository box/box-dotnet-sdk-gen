using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class WorkflowFlowsFieldOutcomesField {
        /// <summary>
        /// The identifier of the outcome
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// The outcomes resource type
        /// </summary>
        [JsonPropertyName("type")]
        public WorkflowFlowsFieldOutcomesFieldTypeField? Type { get; set; } = default;

        /// <summary>
        /// The name of the outcome
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        [JsonPropertyName("action_type")]
        public WorkflowFlowsFieldOutcomesFieldActionTypeField? ActionType { get; set; } = default;

        /// <summary>
        /// If `action_type` is `assign_task` and the task is rejected, returns a
        /// list of outcomes to complete
        /// </summary>
        [JsonPropertyName("if_rejected")]
        public IReadOnlyList<WorkflowFlowsFieldOutcomesFieldIfRejectedField>? IfRejected { get; set; } = default;

        public WorkflowFlowsFieldOutcomesField() {
            
        }
    }
}