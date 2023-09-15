using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class WorkflowFlowsFieldOutcomesFieldIfRejectedField {
        /// <summary>
        /// The identifier of the outcome
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// The outcomes resource type
        /// </summary>
        [JsonPropertyName("type")]
        public WorkflowFlowsFieldOutcomesFieldIfRejectedFieldTypeField? Type { get; set; } = default;

        /// <summary>
        /// The name of the outcome
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        [JsonPropertyName("action_type")]
        public WorkflowFlowsFieldOutcomesFieldIfRejectedFieldActionTypeField? ActionType { get; set; } = default;

        public WorkflowFlowsFieldOutcomesFieldIfRejectedField() {
            
        }
    }
}