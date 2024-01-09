using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class WorkflowFlowsTriggerField {
        /// <summary>
        /// The trigger's resource type
        /// </summary>
        [JsonPropertyName("type")]
        public WorkflowFlowsTriggerTypeField? Type { get; set; } = default;

        /// <summary>
        /// The type of trigger selected for this flow
        /// </summary>
        [JsonPropertyName("trigger_type")]
        public WorkflowFlowsTriggerTriggerTypeField? TriggerType { get; set; } = default;

        /// <summary>
        /// List of trigger scopes
        /// </summary>
        [JsonPropertyName("scope")]
        public IReadOnlyList<WorkflowFlowsTriggerScopeField>? Scope { get; set; } = default;

        public WorkflowFlowsTriggerField() {
            
        }
    }
}