using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class CreateTaskRequestBodyItemField {
        /// <summary>
        /// The ID of the file
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// `file`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<CreateTaskRequestBodyItemTypeField>))]
        public StringEnum<CreateTaskRequestBodyItemTypeField>? Type { get; init; }

        public CreateTaskRequestBodyItemField() {
            
        }
    }
}