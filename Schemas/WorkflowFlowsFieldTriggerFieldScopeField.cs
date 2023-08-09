using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class WorkflowFlowsFieldTriggerFieldScopeField {
        [JsonPropertyName("type")]
        public WorkflowFlowsFieldTriggerFieldScopeFieldTypeField Type { get; }

        [JsonPropertyName("ref")]
        public string Ref { get; }

        [JsonPropertyName("object")]
        public WorkflowFlowsFieldTriggerFieldScopeFieldObjectField Object { get; }

        public WorkflowFlowsFieldTriggerFieldScopeField(WorkflowFlowsFieldTriggerFieldScopeFieldTypeField type, string refParam, WorkflowFlowsFieldTriggerFieldScopeFieldObjectField objectParam) {
            Type = type;
            Ref = refParam;
            Object = objectParam;
        }
    }
}