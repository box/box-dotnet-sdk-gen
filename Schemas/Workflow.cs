using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class Workflow : WorkflowMini {
        [JsonPropertyName("flows")]
        public IReadOnlyList<WorkflowFlowsField> Flows { get; }

        public Workflow(string id, WorkflowMiniTypeField type, string name, string description, bool? isEnabled, IReadOnlyList<WorkflowFlowsField> flows) : base(id, type, name, description, isEnabled) {
            Flows = flows;
        }
    }
}