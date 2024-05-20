using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class WorkflowFlowsTriggerField {
        /// <summary>
        /// The trigger's resource type
        /// </summary>
        [JsonPropertyName("type")]
        public WorkflowFlowsTriggerTypeField? Type { get; init; }

        /// <summary>
        /// The type of trigger selected for this flow
        /// </summary>
        [JsonPropertyName("trigger_type")]
        public WorkflowFlowsTriggerTriggerTypeField? TriggerType { get; init; }

        /// <summary>
        /// List of trigger scopes
        /// </summary>
        [JsonPropertyName("scope")]
        public IReadOnlyList<WorkflowFlowsTriggerScopeField>? Scope { get; init; }

        public WorkflowFlowsTriggerField() {
            
        }
    }
}