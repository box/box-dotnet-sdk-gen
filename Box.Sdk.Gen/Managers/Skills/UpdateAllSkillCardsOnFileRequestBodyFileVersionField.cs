using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class UpdateAllSkillCardsOnFileRequestBodyFileVersionField {
        /// <summary>
        /// `file_version`
        /// </summary>
        [JsonPropertyName("type")]
        public UpdateAllSkillCardsOnFileRequestBodyFileVersionTypeField? Type { get; init; }

        /// <summary>
        /// The ID of the file version
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        public UpdateAllSkillCardsOnFileRequestBodyFileVersionField() {
            
        }
    }
}