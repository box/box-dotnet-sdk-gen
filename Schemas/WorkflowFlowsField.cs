using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class WorkflowFlowsField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public WorkflowFlowsFieldTypeField Type { get; }

        [JsonPropertyName("trigger")]
        public WorkflowFlowsFieldTriggerField Trigger { get; }

        [JsonPropertyName("outcomes")]
        public IReadOnlyList<WorkflowFlowsFieldOutcomesField> Outcomes { get; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("created_by")]
        public UserBase CreatedBy { get; }

        public WorkflowFlowsField(string id, WorkflowFlowsFieldTypeField type, WorkflowFlowsFieldTriggerField trigger, IReadOnlyList<WorkflowFlowsFieldOutcomesField> outcomes, string createdAt, UserBase createdBy) {
            Id = id;
            Type = type;
            Trigger = trigger;
            Outcomes = outcomes;
            CreatedAt = createdAt;
            CreatedBy = createdBy;
        }
    }
}