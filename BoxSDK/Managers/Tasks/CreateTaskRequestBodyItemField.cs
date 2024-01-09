using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateTaskRequestBodyItemField {
        /// <summary>
        /// The ID of the file
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `file`
        /// </summary>
        [JsonPropertyName("type")]
        public CreateTaskRequestBodyItemTypeField? Type { get; set; } = default;

        public CreateTaskRequestBodyItemField() {
            
        }
    }
}