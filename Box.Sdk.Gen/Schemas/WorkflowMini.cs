using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class WorkflowMini {
        /// <summary>
        /// The unique identifier for the workflow
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `workflow`
        /// </summary>
        [JsonPropertyName("type")]
        public WorkflowMiniTypeField? Type { get; set; } = default;

        /// <summary>
        /// The name of the workflow
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        /// <summary>
        /// The description for a workflow.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; } = default;

        /// <summary>
        /// Specifies if this workflow is enabled
        /// </summary>
        [JsonPropertyName("is_enabled")]
        public bool? IsEnabled { get; set; } = default;

        public WorkflowMini() {
            
        }
    }
}