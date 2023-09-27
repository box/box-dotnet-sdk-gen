using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateCollaborationRequestBodyArgItemField {
        /// <summary>
        /// The type of the item that this collaboration will be
        /// granted access to
        /// </summary>
        [JsonPropertyName("type")]
        public CreateCollaborationRequestBodyArgItemFieldTypeField? Type { get; set; } = default;

        /// <summary>
        /// The ID of the item that will be granted access to
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        public CreateCollaborationRequestBodyArgItemField() {
            
        }
    }
}