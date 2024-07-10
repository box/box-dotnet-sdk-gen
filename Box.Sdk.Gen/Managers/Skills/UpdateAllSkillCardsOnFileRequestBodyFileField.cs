using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateAllSkillCardsOnFileRequestBodyFileField {
        /// <summary>
        /// `file`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<UpdateAllSkillCardsOnFileRequestBodyFileTypeField>))]
        public StringEnum<UpdateAllSkillCardsOnFileRequestBodyFileTypeField>? Type { get; init; }

        /// <summary>
        /// The ID of the file
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        public UpdateAllSkillCardsOnFileRequestBodyFileField() {
            
        }
    }
}