using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class WorkflowFlowsFieldOutcomesFieldIfRejectedField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public WorkflowFlowsFieldOutcomesFieldIfRejectedFieldTypeField Type { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("action_type")]
        public WorkflowFlowsFieldOutcomesFieldIfRejectedFieldActionTypeField ActionType { get; }

        public WorkflowFlowsFieldOutcomesFieldIfRejectedField(string id, WorkflowFlowsFieldOutcomesFieldIfRejectedFieldTypeField type, string name, WorkflowFlowsFieldOutcomesFieldIfRejectedFieldActionTypeField actionType) {
            Id = id;
            Type = type;
            Name = name;
            ActionType = actionType;
        }
    }
}