using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class StartWorkflowRequestBodyFlowField {
        /// <summary>
        /// The type of the flow object
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; } = default;

        /// <summary>
        /// The id of the flow
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        public StartWorkflowRequestBodyFlowField() {
            
        }
    }
}