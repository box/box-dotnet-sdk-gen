using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class WorkflowFlowsField {
        /// <summary>
        /// The identifier of the flow
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// The flow's resource type
        /// </summary>
        [JsonPropertyName("type")]
        public WorkflowFlowsTypeField? Type { get; set; } = default;

        [JsonPropertyName("trigger")]
        public WorkflowFlowsTriggerField? Trigger { get; set; } = default;

        [JsonPropertyName("outcomes")]
        public IReadOnlyList<WorkflowFlowsOutcomesField>? Outcomes { get; set; } = default;

        /// <summary>
        /// When this flow was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; } = default;

        [JsonPropertyName("created_by")]
        public UserBase? CreatedBy { get; set; } = default;

        public WorkflowFlowsField() {
            
        }
    }
}