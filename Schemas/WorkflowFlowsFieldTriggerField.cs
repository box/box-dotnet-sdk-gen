using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class WorkflowFlowsFieldTriggerField {
        /// <summary>
        /// The trigger's resource type
        /// </summary>
        [JsonPropertyName("type")]
        public WorkflowFlowsFieldTriggerFieldTypeField? Type { get; set; } = default;

        /// <summary>
        /// The type of trigger selected for this flow
        /// </summary>
        [JsonPropertyName("trigger_type")]
        public WorkflowFlowsFieldTriggerFieldTriggerTypeField? TriggerType { get; set; } = default;

        /// <summary>
        /// List of trigger scopes
        /// </summary>
        [JsonPropertyName("scope")]
        public IReadOnlyList<WorkflowFlowsFieldTriggerFieldScopeField>? Scope { get; set; } = default;

        public WorkflowFlowsFieldTriggerField() {
            
        }
    }
}