using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class WorkflowFull : Workflow {
        /// <summary>
        /// The date and time when the workflow was created on Box
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; } = default;

        /// <summary>
        /// The date and time when the workflow was last updated on Box
        /// </summary>
        [JsonPropertyName("modified_at")]
        public string? ModifiedAt { get; set; } = default;

        [JsonPropertyName("created_by")]
        public UserBase? CreatedBy { get; set; } = default;

        [JsonPropertyName("modified_by")]
        public UserBase? ModifiedBy { get; set; } = default;

        public WorkflowFull() {
            
        }
    }
}