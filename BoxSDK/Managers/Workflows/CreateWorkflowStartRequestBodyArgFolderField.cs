using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateWorkflowStartRequestBodyArgFolderField {
        /// <summary>
        /// The type of the folder object
        /// </summary>
        [JsonPropertyName("type")]
        public CreateWorkflowStartRequestBodyArgFolderFieldTypeField? Type { get; set; } = default;

        /// <summary>
        /// The id of the folder
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        public CreateWorkflowStartRequestBodyArgFolderField() {
            
        }
    }
}