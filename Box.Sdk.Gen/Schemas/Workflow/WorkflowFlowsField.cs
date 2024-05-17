using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class WorkflowFlowsField {
        /// <summary>
        /// The identifier of the flow
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// The flow's resource type
        /// </summary>
        [JsonPropertyName("type")]
        public WorkflowFlowsTypeField? Type { get; init; }

        [JsonPropertyName("trigger")]
        public WorkflowFlowsTriggerField? Trigger { get; init; }

        [JsonPropertyName("outcomes")]
        public IReadOnlyList<WorkflowFlowsOutcomesField>? Outcomes { get; init; }

        /// <summary>
        /// When this flow was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        [JsonPropertyName("created_by")]
        public UserBase? CreatedBy { get; init; }

        public WorkflowFlowsField() {
            
        }
    }
}