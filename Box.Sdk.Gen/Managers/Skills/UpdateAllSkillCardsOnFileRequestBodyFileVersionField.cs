using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateAllSkillCardsOnFileRequestBodyFileVersionField {
        /// <summary>
        /// `file_version`
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<UpdateAllSkillCardsOnFileRequestBodyFileVersionTypeField>))]
        public StringEnum<UpdateAllSkillCardsOnFileRequestBodyFileVersionTypeField>? Type { get; init; }

        /// <summary>
        /// The ID of the file version
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        public UpdateAllSkillCardsOnFileRequestBodyFileVersionField() {
            
        }
    }
}