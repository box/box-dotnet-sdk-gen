using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class CreateCollaborationRequestBodyItemField {
        /// <summary>
        /// The type of the item that this collaboration will be
        /// granted access to
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<CreateCollaborationRequestBodyItemTypeField>))]
        public StringEnum<CreateCollaborationRequestBodyItemTypeField>? Type { get; init; }

        /// <summary>
        /// The ID of the item that will be granted access to
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        public CreateCollaborationRequestBodyItemField() {
            
        }
    }
}