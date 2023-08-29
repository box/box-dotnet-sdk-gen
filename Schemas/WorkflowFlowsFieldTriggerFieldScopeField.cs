using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class WorkflowFlowsFieldTriggerFieldScopeField {
        /// <summary>
        /// The trigger scope's resource type
        /// </summary>
        [JsonPropertyName("type")]
        public WorkflowFlowsFieldTriggerFieldScopeFieldTypeField? Type { get; set; } = default;

        /// <summary>
        /// Indicates the path of the condition value to check
        /// </summary>
        [JsonPropertyName("ref")]
        public string? Ref { get; set; } = default;

        /// <summary>
        /// The object the `ref` points to
        /// </summary>
        [JsonPropertyName("object")]
        public WorkflowFlowsFieldTriggerFieldScopeFieldObjectField? Object { get; set; } = default;

        public WorkflowFlowsFieldTriggerFieldScopeField() {
            
        }
    }
}