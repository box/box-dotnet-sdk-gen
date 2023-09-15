using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateWorkflowStartRequestBodyArgFlowField {
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

        public CreateWorkflowStartRequestBodyArgFlowField() {
            
        }
    }
}