using Unions;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class WorkflowFlowsOutcomesField {
        /// <summary>
        /// The identifier of the outcome
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// The outcomes resource type
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<WorkflowFlowsOutcomesTypeField>))]
        public StringEnum<WorkflowFlowsOutcomesTypeField>? Type { get; init; }

        /// <summary>
        /// The name of the outcome
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        [JsonPropertyName("action_type")]
        [JsonConverter(typeof(StringEnumConverter<WorkflowFlowsOutcomesActionTypeField>))]
        public StringEnum<WorkflowFlowsOutcomesActionTypeField>? ActionType { get; init; }

        /// <summary>
        /// If `action_type` is `assign_task` and the task is rejected, returns a
        /// list of outcomes to complete
        /// </summary>
        [JsonPropertyName("if_rejected")]
        public IReadOnlyList<WorkflowFlowsOutcomesIfRejectedField>? IfRejected { get; init; }

        public WorkflowFlowsOutcomesField() {
            
        }
    }
}