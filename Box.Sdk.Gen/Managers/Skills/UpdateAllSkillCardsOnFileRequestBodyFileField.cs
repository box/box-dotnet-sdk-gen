using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class UpdateAllSkillCardsOnFileRequestBodyFileField {
        /// <summary>
        /// `file`
        /// </summary>
        [JsonPropertyName("type")]
        public UpdateAllSkillCardsOnFileRequestBodyFileTypeField? Type { get; init; }

        /// <summary>
        /// The ID of the file
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        public UpdateAllSkillCardsOnFileRequestBodyFileField() {
            
        }
    }
}