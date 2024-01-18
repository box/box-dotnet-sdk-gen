using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateCollaborationRequestBodyItemField {
        /// <summary>
        /// The type of the item that this collaboration will be
        /// granted access to
        /// </summary>
        [JsonPropertyName("type")]
        public CreateCollaborationRequestBodyItemTypeField? Type { get; set; } = default;

        /// <summary>
        /// The ID of the item that will be granted access to
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        public CreateCollaborationRequestBodyItemField() {
            
        }
    }
}