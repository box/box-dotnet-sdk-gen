using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class Workflow : WorkflowMini {
        /// <summary>
        /// A list of flows assigned to a workflow.
        /// </summary>
        [JsonPropertyName("flows")]
        public IReadOnlyList<WorkflowFlowsField>? Flows { get; set; } = default;

        public Workflow() {
            
        }
    }
}