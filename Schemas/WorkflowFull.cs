using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class WorkflowFull : Workflow {
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; }

        [JsonPropertyName("modified_at")]
        public string ModifiedAt { get; }

        [JsonPropertyName("created_by")]
        public UserBase CreatedBy { get; }

        [JsonPropertyName("modified_by")]
        public UserBase ModifiedBy { get; }

        public WorkflowFull(string id, WorkflowMiniTypeField type, string name, string description, bool? isEnabled, IReadOnlyList<WorkflowFlowsField> flows, string createdAt, string modifiedAt, UserBase createdBy, UserBase modifiedBy) : base(id, type, name, description, isEnabled, flows) {
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
            CreatedBy = createdBy;
            ModifiedBy = modifiedBy;
        }
    }
}