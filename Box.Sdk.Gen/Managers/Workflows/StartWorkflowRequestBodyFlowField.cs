using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Serializer;
using System;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class StartWorkflowRequestBodyFlowField {
        /// <summary>
        /// The type of the flow object
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; init; }

        /// <summary>
        /// The id of the flow
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        public StartWorkflowRequestBodyFlowField() {
            
        }
    }
}