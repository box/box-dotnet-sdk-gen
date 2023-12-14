using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateWorkflowStartRequestBodyFilesField {
        /// <summary>
        /// The type of the file object
        /// </summary>
        [JsonPropertyName("type")]
        public CreateWorkflowStartRequestBodyFilesTypeField? Type { get; set; } = default;

        /// <summary>
        /// The id of the file
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        public CreateWorkflowStartRequestBodyFilesField() {
            
        }
    }
}