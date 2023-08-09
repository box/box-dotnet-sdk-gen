using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class WorkflowFlowsFieldOutcomesField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public WorkflowFlowsFieldOutcomesFieldTypeField Type { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("action_type")]
        public WorkflowFlowsFieldOutcomesFieldActionTypeField ActionType { get; }

        [JsonPropertyName("if_rejected")]
        public IReadOnlyList<WorkflowFlowsFieldOutcomesFieldIfRejectedField> IfRejected { get; }

        public WorkflowFlowsFieldOutcomesField(string id, WorkflowFlowsFieldOutcomesFieldTypeField type, string name, WorkflowFlowsFieldOutcomesFieldActionTypeField actionType, IReadOnlyList<WorkflowFlowsFieldOutcomesFieldIfRejectedField> ifRejected) {
            Id = id;
            Type = type;
            Name = name;
            ActionType = actionType;
            IfRejected = ifRejected;
        }
    }
}