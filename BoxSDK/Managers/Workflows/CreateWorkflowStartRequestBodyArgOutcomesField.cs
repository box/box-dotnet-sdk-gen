using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateWorkflowStartRequestBodyArgOutcomesField {
        /// <summary>
        /// The id of the outcome
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// The type of the outcome object
        /// </summary>
        [JsonPropertyName("type")]
        public CreateWorkflowStartRequestBodyArgOutcomesFieldTypeField? Type { get; set; } = default;

        /// <summary>
        /// This is a placeholder example for various objects that
        /// can be passed in - refer to the guides section to find
        /// out more information.
        /// </summary>
        [JsonPropertyName("parameter")]
        public string? Parameter { get; set; } = default;

        public CreateWorkflowStartRequestBodyArgOutcomesField() {
            
        }
    }
}