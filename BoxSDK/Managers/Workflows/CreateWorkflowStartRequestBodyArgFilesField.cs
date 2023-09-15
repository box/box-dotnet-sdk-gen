using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateWorkflowStartRequestBodyArgFilesField {
        /// <summary>
        /// The type of the file object
        /// </summary>
        [JsonPropertyName("type")]
        public CreateWorkflowStartRequestBodyArgFilesFieldTypeField? Type { get; set; } = default;

        /// <summary>
        /// The id of the file
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        public CreateWorkflowStartRequestBodyArgFilesField() {
            
        }
    }
}