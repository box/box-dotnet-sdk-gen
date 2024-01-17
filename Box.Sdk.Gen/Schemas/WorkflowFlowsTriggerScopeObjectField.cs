using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class WorkflowFlowsTriggerScopeObjectField {
        /// <summary>
        /// The type of the object
        /// </summary>
        [JsonPropertyName("type")]
        public WorkflowFlowsTriggerScopeObjectTypeField? Type { get; set; } = default;

        /// <summary>
        /// The id of the object
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        public WorkflowFlowsTriggerScopeObjectField() {
            
        }
    }
}