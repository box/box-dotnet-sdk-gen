using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class WorkflowFlowsFieldTriggerField {
        [JsonPropertyName("type")]
        public WorkflowFlowsFieldTriggerFieldTypeField Type { get; }

        [JsonPropertyName("trigger_type")]
        public WorkflowFlowsFieldTriggerFieldTriggerTypeField TriggerType { get; }

        [JsonPropertyName("scope")]
        public IReadOnlyList<WorkflowFlowsFieldTriggerFieldScopeField> Scope { get; }

        public WorkflowFlowsFieldTriggerField(WorkflowFlowsFieldTriggerFieldTypeField type, WorkflowFlowsFieldTriggerFieldTriggerTypeField triggerType, IReadOnlyList<WorkflowFlowsFieldTriggerFieldScopeField> scope) {
            Type = type;
            TriggerType = triggerType;
            Scope = scope;
        }
    }
}